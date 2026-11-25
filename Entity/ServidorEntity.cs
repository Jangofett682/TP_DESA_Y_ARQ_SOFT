namespace Entity
{
    public class ServidorEntity
    {
        private int idServidor;
        private string gpu;
        private string cpu;
        private string ram;
        private double precioHora;
        private string estado;

        public int IdServidor { get => idServidor; set => idServidor = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Ram { get => ram; set => ram = value; }
        public double PrecioHora { get => precioHora; set => precioHora = value; }
        public int PuntosOcupados { get; set; }
        public int CapacidadPuntos { get; set; }
        public int PuntosLibres { get; set; }
        public string Estado { get => estado; set => estado = value; }
    }
}
