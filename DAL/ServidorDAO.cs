
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
    }
}
