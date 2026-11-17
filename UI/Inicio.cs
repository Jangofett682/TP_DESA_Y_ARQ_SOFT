using BLL;
using Entity;
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
            CargarMensajeBienvenida();
            AutocompletarUsuario();
            CargarComboJuegos();
            CargarComboServidores();
        }

        private void AutocompletarUsuario()
        {
            try
            {
                txtUsuarioAlta.Text = SesionJugador.GetInstance().NombreUsuario;
                txtUsuarioAlta.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en autocompletar el usuario");
            }
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

        private void CargarMensajeBienvenida()
        {
            try
            {
                string usuarioActivo = SesionJugador.GetInstance().NombreUsuario;
                double saldoActivo = SesionJugador.GetInstance().SaldoDisponible;

                lblUsuario.Text = string.Empty;
                lblUsuario.Text = $"Bienvenido, {usuarioActivo};\nSaldo actual ${saldoActivo:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CargarJuegos()
        {
            try
            {
                dgvJuegos.DataSource = null;
                dgvJuegos.DataSource = juegoBusiness.GetAll();
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cambiar de cuenta");
            }
        }

        private void txtCargarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                using (CargarSaldo formCargarSaldo = new CargarSaldo())
                {
                    if (formCargarSaldo.ShowDialog() == DialogResult.OK)
                    {
                        CargarMensajeBienvenida();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en redirigir a cargar saldo");
            }
        }

        private void CargarComboJuegos()
        {
            try
            {
                cbJuegoIDAlta.DataSource = null;
                cbJuegoIDAlta.DataSource = juegoBusiness.GetAll();
                cbJuegoIDAlta.ValueMember = "idJuego";
                cbJuegoIDAlta.DisplayMember = "titulo";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de juegos");
            }
        }

        private void CargarComboServidores()
        {
            try
            {
                ServidorIDAlta.DataSource = null;
                ServidorIDAlta.DataSource = servidorBusiness.GetAll();
                ServidorIDAlta.ValueMember = "idServidor";
                ServidorIDAlta.DisplayMember = "idServidor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de juegos");
            }
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtMontoTotalAlta.Text, out double monto)||!double.TryParse(txtHorasReservadasAlta.Text, out double horas))
                {
                    MessageBox.Show("Por favor ingrese monto y horas en formato numérico");
                    return;
                }
                SesionEntity nuevaSesion = new SesionEntity
                {
                    NombreUsuario = txtUsuarioAlta.Text,
                    JuegoId = Convert.ToInt32(cbJuegoIDAlta.SelectedValue),
                    ServidorId = Convert.ToInt32(ServidorIDAlta.SelectedValue),
                    HorasReservadas = horas,
                    MontoTotal = monto,
                };
                sesionBusiness.GuardarSesion(nuevaSesion);
                MessageBox.Show("Sesión guardada exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en agregar sesión");
            }
        }
    }
}
