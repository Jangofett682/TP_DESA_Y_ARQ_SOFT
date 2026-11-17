
using DAL.Models;
using Entity;
using Mapper;

namespace DAL
{
    public class ServidorDAO
    {
        public List<ServidorEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Servidor
                        .ToList();
                    return ServidorMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ServidorEntity ObtenerPorID(int idServidor)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var servidorBD = db.Servidor
                        .FirstOrDefault(s => s.IdServidor == idServidor);
                    return ServidorMapper.Map(servidorBD);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
