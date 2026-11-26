using BLL;
using DAL.Models;
using Entity;
using Mapper;
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
    public partial class CatalogoJuegos : Form
    {
        JuegoBusiness juegoBusiness = new JuegoBusiness();
        List<JuegoEntity> listaBorrador = new List<JuegoEntity>();
        public CatalogoJuegos()
        {
            InitializeComponent();
        }

        private void CatalogoJuegos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarResoluciones();
            CargarConfiguracion();
            CargarComboJuegosEliminar();
        }

        private void CargarComboJuegosEliminar()
        {
            try
            {
                cbTituloEliminar.DataSource = null;
                cbTituloEliminar.DataSource = juegoBusiness.GetAll();
                cbTituloEliminar.ValueMember = "IdJuego";
                cbTituloEliminar.DisplayMember = "Titulo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar opciones de juegos para eliminar");
            }
        }

        public void CargarGrilla()
        {
            try
            {
                dgvCatalogo.DataSource = null;
                dgvCatalogo.DataSource = juegoBusiness.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar catálogo");
            }
        }

        public void CargarResoluciones()
        {
            try
            {
                cbResolucion.Items.Clear();
                cbResolucion.Items.AddRange(new string[] { "4k", "1080p", "720p" });

                cbResolucionAltaLotes.Items.Clear();
                cbResolucionAltaLotes.Items.AddRange(new string[] { "4k", "1080p", "720p" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de resoluciones");
            }
        }

        public void CargarConfiguracion()
        {
            try
            {
                cbConfiguracion.Items.Clear();
                cbConfiguracion.Items.AddRange(new string[] { "Ultra", "Alta", "Media" });

                cbConfiguracionAltaLotes.Items.Clear();
                cbConfiguracionAltaLotes.Items.AddRange(new string[] { "Ultra", "Alta", "Media" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista de configuraciones");
            }
        }




        private void btnAgregarJuego_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbConfiguracion.SelectedItem == null || string.IsNullOrEmpty(cbConfiguracion.Text))
                {
                    MessageBox.Show("Por favor seleccione una configuración válida");
                    return;
                }
                if (cbResolucion.SelectedItem == null || string.IsNullOrEmpty(cbResolucion.Text))
                {
                    MessageBox.Show("Por favor seleccione una resolución válida");
                    return;
                }
                JuegoEntity nuevoJuego = new JuegoEntity
                {
                    Titulo = txtTituloJuego.Text,
                    Resolucion = cbResolucion.SelectedItem.ToString(),
                    Configuracion = cbConfiguracion.SelectedItem.ToString(),
                    CostoPuntos = Convert.ToInt32(numPuntos.Value),
                };

                juegoBusiness.Agregar(nuevoJuego);
                CargarGrilla();
                MessageBox.Show($"Juego {nuevoJuego.Titulo} guardado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en agregar juego");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                JuegoEntity juegoTemp = new JuegoEntity
                {
                    Titulo = txtTituloAltaLotes.Text,
                    Resolucion = cbResolucionAltaLotes.SelectedItem?.ToString(),
                    Configuracion = cbConfiguracionAltaLotes.SelectedItem?.ToString(),
                    CostoPuntos = Convert.ToInt32(numPuntos.Value)
                };
                listaBorrador.Add(juegoTemp);
                CargarBorrador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar al borrador");
            }
        }

        private void CargarBorrador()
        {
            try
            {
                dgvBorrador.DataSource = null;
                dgvBorrador.DataSource = listaBorrador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargar lista borrador"); ;
            }
        }

        private void btnAltaLote_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaBorrador.Count == 0)
                {
                    MessageBox.Show("La lista borrador está vacía");
                    return;
                }
                juegoBusiness.AltaConjunta(listaBorrador);
                listaBorrador.Clear();
                MessageBox.Show("Juegos dados de alta exitosamente");
                CargarBorrador();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en dar de alta lote de juegos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en volver al menú principal");
            }
        }

        private void btnBorrarJuego_Click(object sender, EventArgs e)
        {
            try
            {
                juegoBusiness.Eliminar(Convert.ToInt32(cbTituloEliminar.SelectedValue));
                CargarComboJuegosEliminar();
                CargarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en borrar el juego");
            }
        }
    }
}
