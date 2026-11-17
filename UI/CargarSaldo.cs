using BLL;
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
    public partial class CargarSaldo : Form
    {
        private JugadorBusiness jugadorBusiness = new JugadorBusiness();
        public CargarSaldo()
        {
            InitializeComponent();
        }

        private void CargarSaldo_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(numMonto.Value);
                string usuarioActivo = SesionJugador.GetInstance().NombreUsuario;

                jugadorBusiness.CargarSaldo(usuarioActivo, monto);

                MessageBox.Show("Saldo cargado con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar saldo");
            }
        }
    }
}
