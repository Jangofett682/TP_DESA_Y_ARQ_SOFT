
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

        public List<ServidorEntity> ObtenerServidoresConOcupacion(DateTime ahoraUtc)
        {
            using var db = new CloudGamingContext();
            var servidores = db.Servidor.Select(servidor => new
            {
                Servidor = servidor,
                Ocupacion = servidor.Sesión
                    .Where(s => s.InicioUtc <= ahoraUtc && s.FinUtc > ahoraUtc)
                    .Sum(s => s.PuntosConsumidos) ?? 0
            }).ToList();

            return servidores.Select(fila =>
            {
                var servidor = ServidorMapper.Map(fila.Servidor);
                servidor.PuntosOcupados = fila.Ocupacion;
                return servidor;
            }).ToList();
        }

        public ServidorEntity ObtenerPorID(int idServidor)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var servidorBD = db.Servidor
                        .FirstOrDefault(s => s.IdServidor == idServidor);
                    if (servidorBD == null)
                    {
                        return null;
                    }

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
