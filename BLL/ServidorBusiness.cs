
using DAL;
using Entity;

namespace BLL
{
    public class ServidorBusiness
    {
        ServidorDAO servidorDAO = new ServidorDAO();
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
                if (g.Contains("4090") || g.Contains("4080") || g.Contains("3080")||g.Contains("5090"))
                {
                    return 4;
                }
                //Nivel 3 - Alta
                if (g.Contains("3070") || g.Contains("3060") || g.Contains("2080")||g.Contains("3050"))
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
                if (c.Contains("RYZEN 9"))
                {
                    return 4;
                }
                //Nivel 3 - alta
                if (c.Contains("RYZEN 7"))
                {
                    return 3;
                }
                //Nivel 2 - media
                if (c.Contains("RYZEN 5"))
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


                switch (configuracionRequerida.ToUpper())
                {
                    case "ULTRA":
                        return gamaGPUServidor >= 4 && gamaCPUServidor >= 4 && ramServidor >= 16;
                    case "ALTA":
                        return gamaGPUServidor >= 3 && gamaCPUServidor >= 2 && ramServidor >= 16;
                    case "MEDIA":
                        return gamaGPUServidor >= 2 && gamaCPUServidor >= 2 && ramServidor >= 8;
                    default:
                        return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ObtenerCapacidadPuntos(ServidorEntity servidor)
        {
            int cpu = ObtenerGamaCPU(servidor.Cpu);
            int gpu = ObtenerGamaGPU(servidor.Gpu);
            long ram = ExtraerGB(servidor.Ram);
            return (int)Math.Min(Math.Min(cpu * 25, gpu * 25), ram * 5);
        }

        public static int ObtenerCostoPuntos(JuegoEntity juego)
        {
            return juego.Configuracion.Trim().ToUpperInvariant() switch
            {
                "MEDIA" => 25,
                "ALTA" => 40,
                "ULTRA" => 60,
                _ => 0
            };
        }

        public List<ServidorEntity> ObtenerServidoresCompatiblesDisponibles(int idJuego, bool incluirSinCupo = false)
        {
            try
            {
                List<ServidorEntity> listaServidores = servidorDAO.ObtenerServidoresConOcupacion(DateTime.UtcNow);
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
                foreach (var servidor in servidoresHabilitados)
                {
                    servidor.CapacidadPuntos = ObtenerCapacidadPuntos(servidor);
                    servidor.PuntosLibres = Math.Max(0, servidor.CapacidadPuntos - servidor.PuntosOcupados);
                }

                int costo = ObtenerCostoPuntos(juego);
                return incluirSinCupo
                    ? servidoresHabilitados
                    : servidoresHabilitados.Where(s => s.PuntosLibres >= costo).ToList();
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
                return servidorDAO.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
