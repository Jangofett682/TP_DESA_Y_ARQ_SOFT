using DAL;
using Entity;
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
                return listaJuegos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
