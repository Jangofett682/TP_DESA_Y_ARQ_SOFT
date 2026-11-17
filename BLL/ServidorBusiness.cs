
using DAL;
using Entity;

namespace BLL
{
    public class ServidorBusiness
    {
        ServidorDAO servidorDAO = new ServidorDAO();
        SesionBusiness sesionBusiness = new SesionBusiness();
        JuegoDAO juegoDAO = new JuegoDAO();

        private int ObtenerGamaGPU(string gpu)
        {
            try
            {
                if (string.IsNullOrEmpty(gpu))
                {
                    return 0;
                }
                string g = gpu.ToUpper();

                //Nivel 4 - Ultra
                if (g.Contains("4090") || g.Contains("4080") || g.Contains("3080"))
                {
                    return 4;
                }
                //Nivel 3 - Alta
                if (g.Contains("3070") || g.Contains("3060") || g.Contains("2080"))
                {
                    return 3;
                }
                //Nivel 2 - Media
                if (g.Contains("1660") || g.Contains("1060"))
                {
                    return 2;
                }
                //Si no reconoce el modelo, asigna nivel medio por defecto
                return 2;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private int ExtraerGB(string registro)
        {
            try
            {
                if (string.IsNullOrEmpty(registro))
                {
                    return 0;
                }
                //Filtro digitos con LINQ y lo paso a un vector
                string digitos = new string(registro.Where(char.IsDigit).ToArray());
                return int.TryParse(digitos, out int resultado) ? resultado : 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private int ObtenerGamaCPU(string gpu)
        {
            try
            {
                if (string.IsNullOrEmpty(gpu))
                {
                    return 0;
                }
                string c = gpu.ToUpper();
                //Nivel 4 - ultra
                if (c.Contains("Ryzen 9") || c.Contains("Ryzen 7"))
                {
                    return 4;
                }
                //Nivel 3 - alta
                if (c.Contains("Ryzen 7") || c.Contains("Ryzen 5"))
                {
                    return 3;
                }
                //Nivel 2 - media
                if (c.Contains("Ryzen 5"))
                {
                    return 2;
                }
                return 2;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Validaciones de negocio para verificar si el servidor es compatible con la configuración del juego
        //Se utiliza también en SesionBusiness
        public bool EsCompatible(ServidorEntity servidor, JuegoEntity juego)
        {
            try
            {
                string configuracionRequerida = juego.Configuracion.Trim().ToUpper();
                int gamaGPUServidor = ObtenerGamaGPU(servidor.Gpu);
                int gamaCPUServidor = ObtenerGamaCPU(servidor.Cpu);
                int ramServidor = ExtraerGB(servidor.Ram);


                switch (configuracionRequerida)
                {
                    case "ULTRA":
                        return gamaGPUServidor >= 4 && gamaCPUServidor >= 4 && ramServidor >= 16;
                    case "ALTA":
                        return gamaGPUServidor >= 3 && gamaCPUServidor >= 3 && ramServidor >= 16;
                    case "MEDIA":
                        return gamaGPUServidor >= 2 && gamaCPUServidor >= 2 && ramServidor >= 8;
                    default:
                        return gamaCPUServidor >= 3 && gamaCPUServidor >= 3;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ServidorEntity>ObtenerServidoresCompatiblesDisponibles(int idJuego)
        {
            try
            {
                List<ServidorEntity> listaServidores = servidorDAO.getAll();
                JuegoEntity juego = juegoDAO.BuscarPorID(idJuego);

                if(juego == null)
                {
                    return new List<ServidorEntity>();
                }
                //LINQ para filtrar servidores compatibles y disponibles
                var servidoresHabilitados = listaServidores
                    .Where(s=>s.Estado != null && s.Estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase))
                    .Where(s => EsCompatible(s, juego))
                    .ToList();
                return servidoresHabilitados;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
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
