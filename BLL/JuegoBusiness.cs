using DAL;
using DAL.Models;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JuegoBusiness
    {
        JuegoDAO juegoDAO = new JuegoDAO();
        public List<JuegoEntity> GetAll()
        {
            try
            {
                List<JuegoEntity> listaJuegos = juegoDAO.getAll();
                foreach (var juego in listaJuegos)
                {
                    juego.CostoPuntos = ServidorBusiness.ObtenerCostoPuntos(juego);
                }
                return listaJuegos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void Agregar(JuegoEntity nuevoJuego)
        {
            try
            {
                if (string.IsNullOrEmpty(nuevoJuego.Titulo) || string.IsNullOrEmpty(nuevoJuego.Resolucion) || string.IsNullOrEmpty(nuevoJuego.Configuracion))
                {
                    throw new Exception("Por favor complete los campos con las especificaciones del juego");
                }

                JuegoEntity juegoExistente = juegoDAO.BuscarPorTitulo(nuevoJuego.Titulo);

                if(juegoExistente != null)
                {
                    throw new Exception("El juego ingresado ya se encuentra cargado");
                }

                juegoDAO.Guardar(nuevoJuego);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void AltaConjunta(List<JuegoEntity> listaJuegos)
        {
            try
            {
                if (listaJuegos == null || !listaJuegos.Any())
                {
                    throw new Exception("La lista de juegos a registrar está vacía.");
                }
                foreach (var juego in listaJuegos)
                {
                    if (string.IsNullOrWhiteSpace(juego.Titulo) || string.IsNullOrWhiteSpace(juego.Resolucion) || string.IsNullOrWhiteSpace(juego.Configuracion))
                    {
                        throw new Exception($"El juego '{juego?.Titulo}' contiene datos incompletos.");
                    }
                    JuegoEntity juegoExistente = juegoDAO.BuscarPorTitulo(juego.Titulo);
                    if(juegoExistente != null)
                    {
                        throw new Exception($"El juego {juego.Titulo} ya se encuentra cargado");
                    }
                }
                var duplicadosEnLista = listaJuegos.GroupBy(j => j.Titulo, StringComparer.OrdinalIgnoreCase)
                    .Where(g =>g.Count() > 1)
                    .Select(g =>g.Key);
                if (duplicadosEnLista.Any())
                {
                    throw new Exception($"La lista enviada contiene títulos repetidos entre sí: {string.Join(", ", duplicadosEnLista)}.");
                }
                CloudGamingContext.EjecutarTransaccion(db =>
                {
                    foreach (var juego in listaJuegos)
                    {
                        var juegoBD = JuegoMapper.Map(juego);
                        db.Juego.Add(juegoBD);
                    } 
                    db.SaveChanges(); });
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                JuegoEntity juegoExistente = juegoDAO.BuscarPorID(id);
                if (juegoExistente == null)
                {
                    throw new Exception("ID no válido");
                }
                juegoDAO.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
