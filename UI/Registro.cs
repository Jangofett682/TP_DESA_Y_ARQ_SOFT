using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Registro : Form
    {
        JugadorBusiness jugadorBusiness = new JugadorBusiness();
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtContraseña.Text)|| string.IsNullOrEmpty(txtMail.Text)|| string.IsNullOrEmpty(txtNombreApellido.Text) || string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos");
                    return;
                }
                if(!double.TryParse(txtSaldo.Text, out double saldo))
                {
                    MessageBox.Show("Por favor ingrese un saldo numérico");
                    return;
                }

                JugadorEntity nuevoJugador = new JugadorEntity
                {
                    NombreUsuario = txtUsuario.Text,
                    NombreApellido = txtNombreApellido.Text,
                    Mail = txtMail.Text,
                    SaldoDisponible = saldo,
                };

                jugadorBusiness.Agregar(nuevoJugador);
                //Al registrarse, se inicia sesión automáticamente
                SesionJugador.GetInstance().IniciarSesion(nuevoJugador);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en registrarse");
            }
        }
    }
}
