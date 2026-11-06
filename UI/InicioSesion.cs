using PlantillaCapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicio de sesión exitoso
                Form1 inicio = new Form1();
                inicio.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancio formulario
                Registro registro = new Registro();
                DialogResult resultado = registro.ShowDialog();

                registro.Dispose();  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abrir formulario de registro");
            }
        }
    }
}
