using DAL.Models;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JuegoDAO
    {
        //Método para listar
        public List<JuegoEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Juego
                        .ToList();
                    return JuegoMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JuegoEntity BuscarPorID(int id)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    Juego juego = db.Juego
                        .FirstOrDefault(j => j.IdJuego == id);
                    if (juego != null)
                    {
                        return JuegoMapper.Map(juego);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JuegoEntity BuscarPorTitulo(string titulo)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    Juego juego = db.Juego
                        .FirstOrDefault(j => j.Titulo == titulo);
                    if (juego != null)
                    {
                        return JuegoMapper.Map(juego);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Guardar(JuegoEntity juego)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var juegoBD = JuegoMapper.Map(juego);

                    db.Juego.Add(juegoBD);
                    db.SaveChanges();
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
                using (var db = new CloudGamingContext())
                {
                    Juego juego = db.Juego.FirstOrDefault(j => j.IdJuego == id);

                    if (juego != null)
                    {
                        db.Juego.Remove(juego);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
