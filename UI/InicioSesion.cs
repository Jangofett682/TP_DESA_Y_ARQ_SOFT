using BLL;
using Entity;
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
        JugadorBusiness jugadorBusiness = new JugadorBusiness();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                JugadorEntity jugadorAutenticado = jugadorBusiness.Autenticar(txtUsuario.Text);

                if(jugadorAutenticado != null)
                {
                    SesionJugador.GetInstance().IniciarSesion(jugadorAutenticado);
                    //Inicio de sesión exitoso
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al iniciar sesión, regístrese de ser necesario");
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancio formulario
                Registro registro = new Registro();
                DialogResult resultado = registro.ShowDialog();

                using(Registro formReg =  new Registro())
                {
                    if(formReg.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Registro exitoso. Proceda a iniciar sesión");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abrir formulario de registro");
            }
        }
    }
}
