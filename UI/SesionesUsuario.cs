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
    public partial class SesionesUsuario : Form
    {
        SesionBusiness sesionBusiness = new SesionBusiness();
        public SesionesUsuario()
        {
            InitializeComponent();
        }

        private void SesionesUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CargarSesionesUsuario()
        {
            try
            {
                var listaSesiones = sesionBusiness.ObtenerSesionesUsuarioActivo();
                dgvSesionesUsuario.DataSource = null;
                dgvSesionesUsuario.DataSource = listaSesiones;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
