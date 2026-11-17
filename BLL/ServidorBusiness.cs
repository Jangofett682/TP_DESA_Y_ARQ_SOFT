
using DAL;
using Entity;

namespace BLL
{
    public class ServidorBusiness
    {
        ServidorDAO servidorDAO = new ServidorDAO();
        public List<ServidorEntity> GetAll()
        {
            try
            {
                List<ServidorEntity> listaServidores = servidorDAO.getAll();
                return listaServidores;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
