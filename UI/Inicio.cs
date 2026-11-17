using BLL;
using UI;

namespace PlantillaCapas
{
    public partial class Form1 : Form
    {
        JuegoBusiness juegoBusiness = new JuegoBusiness();
        JugadorBusiness jugadorBusiness = new JugadorBusiness();
        ServidorBusiness servidorBusiness = new ServidorBusiness();
        SesionBusiness sesionBusiness = new SesionBusiness();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CargarServidores();
            CargarJuegos();
        }

        private void CargarServidores()
        {
            try
            {
                dgvServidores.DataSource = null;
                dgvServidores.DataSource = servidorBusiness.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de servidores");
            }
        }

        private void CargarJuegos()
        {
            try
            {
                dgvJuegos.DataSource = null;
                dgvJuegos.DataSource = juegoBusiness.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de juegos");
            }
        }

        private void btnCambiarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                InicioSesion inicio = new InicioSesion();
                inicio.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cambiar de cuenta");
            }
        }
    }
}
