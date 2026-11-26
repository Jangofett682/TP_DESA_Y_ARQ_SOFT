using BLL;
using DAL;
using Entity;
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
            CargarSesionesUsuario();
            CargarComboEliminar();
            CargarComboModificar();
            CargarMensajeBienvenida();
        }

        private void CargarMensajeBienvenida()
        {
            try
            {
                string usuarioActivo = SesionJugador.GetInstance().NombreUsuario;
                double saldoActivo = SesionJugador.GetInstance().SaldoDisponible;

                lblUsuario.Text = string.Empty;
                lblUsuario.Text = $"Gestione sus sesiones, {usuarioActivo}. \nSaldo actual ${saldoActivo:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarComboModificar()
        {
            try
            {
                cbIDModificar.DataSource = null;
                cbIDModificar.DataSource = sesionBusiness.ObtenerSesionesUsuarioActivo();
                cbIDModificar.ValueMember = "idSesion";
                cbIDModificar.DisplayMember = "idSesion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar lista de ID para modificar");
            }
        }

        private void CargarComboEliminar()
        {
            try
            {
                cbIDEliminar.DataSource = null;
                cbIDEliminar.DataSource = sesionBusiness.ObtenerSesionesUsuarioActivo();
                cbIDEliminar.ValueMember = "idSesion";
                cbIDEliminar.DisplayMember = "idSesion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar lista de ID para eliminar");
            }
        }

        private void CargarSesionesUsuario()
        {
            try
            {
                var listaSesiones = sesionBusiness.ObtenerSesionesUsuarioActivo();
                dgvSesionesUsuario.DataSource = null;
                dgvSesionesUsuario.DataSource = listaSesiones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                sesionBusiness.Eliminar(Convert.ToInt32(cbIDEliminar.SelectedValue));
                MessageBox.Show($"Sesión eliminada exitosamente");
                CargarSesionesUsuario();
                CargarComboEliminar();
                CargarComboModificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar sesión");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SesionEntity sesionModificada = new SesionEntity
                {
                    IdSesion = Convert.ToInt32(cbIDModificar.SelectedValue),
                    HorasReservadas = Convert.ToDouble(numHorasModificacion.Value),
                    NombreUsuario = SesionJugador.GetInstance().JugadorUsuario,
                };
                sesionBusiness.Modificar(sesionModificada);
                MessageBox.Show("Sesion modificada exitosamente");
                CargarSesionesUsuario();
                CargarMensajeBienvenida();
                CargarComboModificar();
                CargarComboEliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar sesión");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numHorasModificacion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
