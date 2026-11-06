using UI;

namespace PlantillaCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
