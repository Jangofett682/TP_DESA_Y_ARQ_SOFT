using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class SesionBusiness
    {
        SesionDAO aplicacionDAO = new SesionDAO();
        ServidorDAO servidorDAO = new ServidorDAO();
        JuegoDAO juegoDAO = new JuegoDAO();
        JugadorDAO jugadorDAO = new JugadorDAO();

        ServidorBusiness servidorBusiness = new ServidorBusiness();

        SesionDAO sesionDAO = new SesionDAO();
        public List<SesionEntity> GetAll()
        {
            try
            {
                //Obtengo la lista de DAL
                List<SesionEntity> listaSesiones = aplicacionDAO.getAll();

                //Recorro cada sesión en la lista y aplico reglas
                foreach (var sesion in listaSesiones)
                {
                    //Si el jugador tiene más de 25 mil de saldo o reserva más de 5 horas, 20% de descuento
                    if (sesion.HorasReservadas >= 5)
                    {
                        sesion.PorcentajeDescuento = 15;
                    }
                    else
                    {
                        sesion.PorcentajeDescuento = 0;
                    }
                    //Cálculo general
                    double total = sesion.HorasReservadas * sesion.PrecioHoraServidor;
                    sesion.MontoTotal = total - (1 * (sesion.PorcentajeDescuento / 100.0));
                }
                return listaSesiones;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ValidarReglasNegocio(SesionEntity sesion)
        {
            if (string.IsNullOrEmpty(sesion.NombreUsuario) || sesion.NombreUsuario.Length < 5)
            {
                throw new Exception("Debe contener un usuario con al menos 5 caracteres");
            }
            if (sesion.HorasReservadas <= 0)
            {
                throw new Exception("Las horas reservadas deben ser más de 0");
            }

            if (sesion.IdSesion <= 0)
            {
                throw new Exception("Debe seleccionar una categoría con id válido");
            }
        }


   

        public void GuardarSesion(SesionEntity nuevaSesion)
        {
            try
            {
                if(nuevaSesion.HorasReservadas <= 0)
                {
                    throw new Exception("Debe reservar más de 0 hs");
                }
                //Obtenemos precio por hora
                ServidorEntity servidor = servidorDAO.ObtenerPorID(nuevaSesion.IdSesion);
                JuegoEntity juego = juegoDAO.BuscarPorID(nuevaSesion.JuegoId);

                if(servidor == null)
                {
                    throw new Exception("El servidor no existe");
                }
                if(juego == null)
                {
                    throw new Exception("El juego no existe");
                }
                //Valido estado
                if(!servidor.Estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception("El servidor seleccionado no está disponible");
                }
                //Valido compatibilidad juego
                if (!servidorBusiness.EsCompatible(servidor, juego))
                {
                    throw new Exception($"El servidor no cumple con las especificaciones para la configuración requerida ({juego.Configuracion}) por el juego {juego.Titulo}");
                }
                double monto = nuevaSesion.HorasReservadas * servidor.PrecioHora;
                nuevaSesion.MontoTotal = monto;

                JugadorEntity jugador = jugadorDAO.Autenticar(nuevaSesion.NombreUsuario);
                if (jugador.SaldoDisponible < monto)
                {
                    throw new Exception("Saldo insuficiente para alquilar servidor");
                }
                //Persistencia y actualización de singleton
                double nuevoSaldo = jugador.SaldoDisponible - monto;
                sesionDAO.RegistrarSesionSaldo(nuevaSesion, nuevoSaldo);
                SesionJugador.GetInstance().ActualizarSaldoDisponible(nuevoSaldo);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void GuardarConjunto(List<SesionEntity> listaSesiones)
        {
            try
            {
                if (listaSesiones == null || listaSesiones.Count == 0)
                {
                    throw new Exception("La lista está vacía");
                }
                //Utilizo transacción para validar reglas de negocio
                using (var trx = new TransactionScope())
                {
                    foreach (var sesion in listaSesiones)
                    {
                        ValidarReglasNegocio(sesion);
                    }
                    aplicacionDAO.AltaConjunta(listaSesiones);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                SesionEntity aplicacionExistente = aplicacionDAO.BuscarPorID(id);
                if (aplicacionExistente == null)
                {
                    throw new Exception("ID no válido");
                }
                aplicacionDAO.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Paso como parámetro objeto entity completo
        public void Modificar(SesionEntity sesionModificada)
        {
            try
            {
                SesionEntity sesionExistente = aplicacionDAO.BuscarPorID(sesionModificada.IdSesion);
                if (sesionExistente == null)
                {
                    throw new Exception("ID no válido");
                }
                ValidarReglasNegocio(sesionModificada);
                aplicacionDAO.Modificar(sesionModificada);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
