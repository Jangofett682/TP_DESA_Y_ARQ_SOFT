using BLL;
using Entity;
using Mapper;
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
            ServidorIDAlta.DropDown += (_, _) => CargarServidores();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CargarJuegos();
            CargarMensajeBienvenida();
            AutocompletarUsuario();
            DeshabilitarCampoPrecio();
            CargarComboJuegos();
            CargarServidores();
            MostrarOpcionesAdmin();
        }

        private void MostrarOpcionesAdmin()
        {
            try
            {
                bool esAdmin = SesionJugador.GetInstance().EsAdmin;

                groupBox3.Visible = !esAdmin;
                txtCargarSaldo.Enabled = !esAdmin;
                txtVerSesionesUsuario.Enabled = !esAdmin;
                btnCatalogoJuegos.Visible = esAdmin;
                lblSaldoActual.Visible = !esAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en mostrar opciones admin");
            }
        }

        private void DeshabilitarCampoPrecio()
        {
            try
            {
                txtMontoTotalAlta.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en autocompletar precio");
            }
        }

        private void AutocompletarUsuario()
        {
            try
            {
                txtUsuarioAlta.Text = SesionJugador.GetInstance().JugadorUsuario;
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
                if (cbJuegoIDAlta.SelectedItem is not JuegoEntity juego)
                {
                    return;
                }

                var idSeleccionado = ServidorIDAlta.SelectedValue;
                var servidores = servidorBusiness.ObtenerServidoresCompatiblesDisponibles(juego.IdJuego, incluirSinCupo: true);
                dgvServidores.DataSource = servidores;
                dgvServidores.Columns[nameof(ServidorEntity.PuntosLibres)].HeaderText = "Puntos libres";
                dgvServidores.Columns[nameof(ServidorEntity.CapacidadPuntos)].HeaderText = "Puntos totales";
                dgvServidores.Columns[nameof(ServidorEntity.PuntosOcupados)].Visible = false;

                int costo = juego.CostoPuntos;
                ServidorIDAlta.ValueMember = nameof(ServidorEntity.IdServidor);
                ServidorIDAlta.DisplayMember = nameof(ServidorEntity.IdServidor);
                var conCupo = servidores.Where(s => s.PuntosLibres >= costo).ToList();
                ServidorIDAlta.DataSource = conCupo;
                if (conCupo.Any(s => Equals(s.IdServidor, idSeleccionado)))
                {
                    ServidorIDAlta.SelectedValue = idSeleccionado;
                }
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
                lblUsuario.Text = $"Bienvenido,";
                lblUsuarioNombre.Text = usuarioActivo;

                lblSaldoActual.Text = $"Saldo actual ${saldoActivo:N2}";
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
                dgvJuegos.Columns[nameof(JuegoEntity.CostoPuntos)].HeaderText = "Costo en puntos";
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
                SesionJugador.GetInstance().CerrarSesion();
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
                cbJuegoIDAlta.ValueMember = nameof(JuegoEntity.IdJuego);
                cbJuegoIDAlta.DisplayMember = nameof(JuegoEntity.Titulo);
                cbJuegoIDAlta.DataSource = dgvJuegos.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de juegos");
            }
        }

        private void CalcularMontoEstimado()
        {
            try
            {
                if (ServidorIDAlta.SelectedItem is ServidorEntity servidor && double.TryParse(txtHorasReservadasAlta.Text, out double horas) && horas > 0)
                {
                    double totalEstimado = horas * servidor.PrecioHora;
                    txtMontoTotalAlta.Text = $"${totalEstimado:N2}";

                }
                else
                {
                    txtMontoTotalAlta.Text = "$0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en calcular estimación del monto");
            }
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtHorasReservadasAlta.Text, out double horas))
                {
                    MessageBox.Show("Por favor ingrese horas en formato numérico");
                    return;
                }


                SesionEntity nuevaSesion = new SesionEntity
                {
                    NombreUsuario = txtUsuarioAlta.Text,
                    JuegoId = Convert.ToInt32(cbJuegoIDAlta.SelectedValue),
                    ServidorId = Convert.ToInt32(ServidorIDAlta.SelectedValue),
                    HorasReservadas = horas,
                    PorcentajeDescuento = Convert.ToDouble(SesionMapper.CalcularPorcentajeHoras(horas)),
                };

                sesionBusiness.GuardarSesion(nuevaSesion);
                CargarServidores();
                CargarMensajeBienvenida();
                MessageBox.Show("Sesión guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en agregar sesión");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbJuegoIDAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verifico que se haya inicializado correctamente el combobox y no como null
            if (cbJuegoIDAlta.SelectedItem is JuegoEntity)
            {
                CargarServidores();
            }
        }

        private void txtVerSesionesUsuario_Click(object sender, EventArgs e)
        {
            using (SesionesUsuario sesionesUsuario = new SesionesUsuario())
            {
                sesionesUsuario.ShowDialog();
                CargarServidores();
                CargarMensajeBienvenida();
            }
        }

        private void txtHorasReservadasAlta_TextChanged(object sender, EventArgs e)
        {
            CalcularMontoEstimado();
        }

        private void ServidorIDAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoEstimado();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCatalogoJuegos_Click(object sender, EventArgs e)
        {
            try
            {
                using (CatalogoJuegos catalogo = new CatalogoJuegos())
                {
                    if (catalogo.ShowDialog() == DialogResult.OK)
                    {
                        CargarJuegos();
                        CargarComboJuegos();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en mostrar catálogo de juegos");
            }
        }
    }
}
