using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JugadorBusiness
    {
        JugadorDAO jugadorDAO = new JugadorDAO();
        public List<JugadorEntity> GetAll()
        {
            try
            {
                List<JugadorEntity> listaJugadores = jugadorDAO.getAll();
                return listaJugadores;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
