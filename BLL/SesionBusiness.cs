using DAL;
using Entity;
using Mapper;
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
        ServidorDAO servidorDAO = new ServidorDAO();
        JuegoDAO juegoDAO = new JuegoDAO();
        JugadorDAO jugadorDAO = new JugadorDAO();

        ServidorBusiness servidorBusiness = new ServidorBusiness();

        SesionDAO sesionDAO = new SesionDAO();


        private double CalcularPorcentajeDescuento(double horas)
        {
            if (horas >= 10)
            {
                return 20;
            }

            if (horas >= 5)
            {
                return 10;
            }

            return 0;
        }

        public List<SesionEntity> GetAll()
        {
            try
            {
                //Obtengo la lista de DAL
                return sesionDAO.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ValidarReglasNegocio(SesionEntity sesion)
        {
            if (sesion == null)
            {
                throw new ArgumentNullException(nameof(sesion));
            }

            sesion.HorasReservadas = Math.Round(sesion.HorasReservadas, 4);
            if (!double.IsFinite(sesion.HorasReservadas) || sesion.HorasReservadas <= 0)
            {
                throw new Exception("Las horas reservadas deben ser más de 0");
            }

            if (sesion.ServidorId <= 0)
            {
                throw new Exception("Debe seleccionar un servidor con id válido");
            }
            if (sesion.JuegoId <= 0)
            {
                throw new Exception("Debe seleccionar un juego con id válido");
            }
        }

        private double CalcularMontoTotal(double horas, double precioHora,out double descuento)
        {
            if (!double.IsFinite(precioHora) || precioHora <= 0)
            {
                throw new Exception("El precio por hora no es válido");
            }
            descuento = CalcularPorcentajeDescuento(horas);

            double total = horas * precioHora;

            return total * (1 - descuento / 100.0);
        }
        public void GuardarSesion(SesionEntity nuevaSesion)
        {
            try
            {
                ValidarReglasNegocio(nuevaSesion);
                ServidorEntity servidor = PrepararCapacidad(nuevaSesion);
                double monto = CalcularMontoTotal(nuevaSesion.HorasReservadas,servidor.PrecioHora,out double descuento);

                nuevaSesion.PrecioHoraServidor = servidor.PrecioHora;
                nuevaSesion.MontoTotal = monto;
                nuevaSesion.PorcentajeDescuento = descuento;

                JugadorEntity jugador = jugadorDAO.Autenticar(nuevaSesion.NombreUsuario);
                if (jugador.SaldoDisponible < monto)
                {
                    throw new Exception("Saldo insuficiente para alquilar servidor");
                }
                //Persistencia y actualización de singleton
                double nuevoSaldo = jugador.SaldoDisponible - monto;
                sesionDAO.RegistrarSesionSaldo(nuevaSesion, nuevoSaldo);
                if (SesionJugador.GetInstance().JugadorUsuario == nuevaSesion.NombreUsuario)
                {
                    SesionJugador.GetInstance()
                        .ActualizarSaldoDisponible(nuevoSaldo);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private ServidorEntity PrepararCapacidad(SesionEntity sesion)
        {
            //Obtenemos precio por hora
            ServidorEntity servidor = servidorDAO.ObtenerPorID(sesion.ServidorId);
            JuegoEntity juego = juegoDAO.BuscarPorID(sesion.JuegoId);

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
            //Valido compatibilidad de hardware
            if (!servidorBusiness.EsCompatible(servidor, juego))
            {
                throw new Exception($"El servidor no cumple con las especificaciones para la configuración requerida ({juego.Configuracion}) por el juego {juego.Titulo}");
            }
            sesion.CapacidadPuntosServidor = servidorBusiness.ObtenerCapacidadPuntos(servidor);
            sesion.PuntosConsumidos = ServidorBusiness.ObtenerCostoPuntos(juego);
            return servidor;
        }

        public void GuardarConjunto(List<SesionEntity> listaSesiones)
        {
            try
            {
                if (listaSesiones == null || listaSesiones.Count == 0)
                {
                    throw new Exception("La lista está vacía");
                }
                foreach (var sesion in listaSesiones)
                {
                    ValidarReglasNegocio(sesion);
                    PrepararCapacidad(sesion);
                }
                sesionDAO.AltaConjunta(listaSesiones);
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
                SesionEntity aplicacionExistente = sesionDAO.BuscarPorID(id);
                if (aplicacionExistente == null)
                {
                    throw new Exception("ID no válido");
                }
                sesionDAO.Eliminar(id);
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
                if (sesionModificada == null)
                {
                    throw new ArgumentNullException(nameof(sesionModificada));
                }
                SesionEntity sesionExistente = sesionDAO.BuscarPorID(sesionModificada.IdSesion);
                if (sesionExistente == null)
                {
                    throw new Exception("ID no válido");
                }
                ServidorEntity servidor = servidorDAO.ObtenerPorID(sesionExistente.ServidorId);
                if(servidor == null)
                {
                    throw new Exception("El servidor no existe");
                }
                //Mantengo valores ID originales sin pisarlos
                if (sesionModificada.ServidorId <= 0)
                {
                    sesionModificada.ServidorId = sesionExistente.ServidorId;
                }
                if(sesionModificada.JuegoId <= 0)
                {
                    sesionModificada.JuegoId = sesionExistente.JuegoId;
                }
                ValidarReglasNegocio(sesionModificada);
                sesionModificada.CapacidadPuntosServidor = servidorBusiness.ObtenerCapacidadPuntos(servidor);
                double nuevoTotal = sesionModificada.HorasReservadas * servidor.PrecioHora;
                double porcentajeDescuento = SesionMapper.CalcularPorcentajeHoras(sesionModificada.HorasReservadas);
                double diferenciaMonto = nuevoTotal - sesionExistente.MontoTotal;
                //Reasigno montos
                sesionModificada.MontoTotal = nuevoTotal;
                sesionModificada.PorcentajeDescuento = porcentajeDescuento;

                JugadorEntity jugadorExistente = jugadorDAO.Autenticar(sesionExistente.NombreUsuario);
                if(jugadorExistente== null)
                {
                    throw new Exception("El jugador no existe");
                }

                //Valido si el saldo es suficiente
                if(diferenciaMonto > 0 && jugadorExistente.SaldoDisponible < diferenciaMonto)
                {
                    throw new Exception($"Saldo insuficiente. Cargue más o reajuste según sea necesario. Costo extra: {diferenciaMonto:N2}");
                }
                //Calculo de nuevo saldo para el jugador
                double nuevoSaldoJugador = jugadorExistente.SaldoDisponible - diferenciaMonto;

                sesionDAO.Modificar(sesionModificada, nuevoSaldoJugador);

                if (SesionJugador.GetInstance().JugadorUsuario == sesionExistente.NombreUsuario)
                {
                    SesionJugador.GetInstance().ActualizarSaldoDisponible(jugadorDAO.Autenticar(sesionExistente.NombreUsuario).SaldoDisponible);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<SesionEntity> ObtenerSesionesUsuarioActivo()
        {
            try
            {
                string usuarioActivo = SesionJugador.GetInstance().JugadorUsuario;
                if (string.IsNullOrEmpty(usuarioActivo))
                {
                    throw new Exception("No hay ninguna sesión activa");
                }
                return sesionDAO.ObtenerPorUsuario(usuarioActivo);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
