using DAL.Models;
using Entity;

namespace Mapper
{
    public class ServidorMapper
    {
        public static ServidorEntity Map(Servidor servidor)
        {
            try
            {
                if(servidor == null)
                {
                    return null;
                }
                return new ServidorEntity
                {
                    IdServidor = servidor.IdServidor,
                    Gpu = servidor.Gpu,
                    Cpu = servidor.Cpu,
                    Ram = servidor.Ram,
                    PrecioHora = Convert.ToDouble(servidor.PrecioHora),
                    Estado = servidor.Estado,
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Servidor Map(ServidorEntity servidor)
        {
            try
            {
                if (servidor == null)
                {
                    return null;
                }
                return new Servidor
                {
                    IdServidor = servidor.IdServidor,
                    Gpu = servidor.Gpu,
                    Cpu = servidor.Cpu,
                    Ram = servidor.Ram,
                    PrecioHora = Convert.ToDecimal(servidor.PrecioHora),
                    Estado = servidor.Estado,
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Mappeo de listas
        public static List<ServidorEntity> Map(List<Servidor> listaServidores)
        {
            if (listaServidores == null)
            {
                return new List<ServidorEntity>();
            }
            return listaServidores.Select(s => Map(s)).ToList();
        }

        public static List<Servidor> MapBD(List<ServidorEntity> listaServidores)
        {
            if (listaServidores == null)
            {
                return new List<Servidor>();
            }
            return listaServidores.Select(s => Map(s)).ToList();
        }
    }
}
