namespace UI
{
    partial class CatalogoJuegos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoJuegos));
            dgvCatalogo = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCatalogo = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            numPuntos = new NumericUpDown();
            cbConfiguracion = new ComboBox();
            cbResolucion = new ComboBox();
            txtTituloJuego = new TextBox();
            btnAgregarJuego = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            numCostoPuntosAltaLotes = new NumericUpDown();
            cbConfiguracionAltaLotes = new ComboBox();
            cbResolucionAltaLotes = new ComboBox();
            txtTituloAltaLotes = new TextBox();
            btnAgregarBorrador = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dgvBorrador = new DataGridView();
            btnAltaLote = new Button();
            btnVolver = new Button();
            btnEliminar = new GroupBox();
            cbTituloEliminar = new ComboBox();
            btnBorrarJuego = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPuntos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCostoPuntosAltaLotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrador).BeginInit();
            btnEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCatalogo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvCatalogo.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvCatalogo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.SeaGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCatalogo.EnableHeadersVisualStyles = false;
            dgvCatalogo.GridColor = Color.SeaGreen;
            dgvCatalogo.Location = new Point(35, 60);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCatalogo.RowHeadersWidth = 51;
            dgvCatalogo.Size = new Size(985, 371);
            dgvCatalogo.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SeaGreen;
            flowLayoutPanel1.Controls.Add(lblCatalogo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1571, 35);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // lblCatalogo
            // 
            lblCatalogo.AutoSize = true;
            lblCatalogo.BackColor = Color.Transparent;
            lblCatalogo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatalogo.ForeColor = Color.White;
            lblCatalogo.Location = new Point(3, 0);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(182, 28);
            lblCatalogo.TabIndex = 4;
            lblCatalogo.Text = "Catálogo de juegos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(numPuntos);
            groupBox3.Controls.Add(cbConfiguracion);
            groupBox3.Controls.Add(cbResolucion);
            groupBox3.Controls.Add(txtTituloJuego);
            groupBox3.Controls.Add(btnAgregarJuego);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(35, 438);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(454, 382);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nuevo juego";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 256);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 15;
            label1.Text = "Costo puntos";
            // 
            // numPuntos
            // 
            numPuntos.Location = new Point(171, 256);
            numPuntos.Name = "numPuntos";
            numPuntos.Size = new Size(251, 35);
            numPuntos.TabIndex = 14;
            // 
            // cbConfiguracion
            // 
            cbConfiguracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConfiguracion.FormattingEnabled = true;
            cbConfiguracion.Location = new Point(171, 188);
            cbConfiguracion.Name = "cbConfiguracion";
            cbConfiguracion.Size = new Size(251, 36);
            cbConfiguracion.TabIndex = 13;
            // 
            // cbResolucion
            // 
            cbResolucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResolucion.FormattingEnabled = true;
            cbResolucion.Location = new Point(171, 128);
            cbResolucion.Name = "cbResolucion";
            cbResolucion.Size = new Size(251, 36);
            cbResolucion.TabIndex = 12;
            // 
            // txtTituloJuego
            // 
            txtTituloJuego.BackColor = Color.White;
            txtTituloJuego.Font = new Font("Segoe UI", 12F);
            txtTituloJuego.ForeColor = Color.Black;
            txtTituloJuego.Location = new Point(171, 54);
            txtTituloJuego.Margin = new Padding(4);
            txtTituloJuego.Name = "txtTituloJuego";
            txtTituloJuego.Size = new Size(251, 34);
            txtTituloJuego.TabIndex = 11;
            // 
            // btnAgregarJuego
            // 
            btnAgregarJuego.BackColor = Color.SeaGreen;
            btnAgregarJuego.FlatStyle = FlatStyle.Flat;
            btnAgregarJuego.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarJuego.ForeColor = Color.White;
            btnAgregarJuego.Location = new Point(243, 319);
            btnAgregarJuego.Margin = new Padding(4);
            btnAgregarJuego.Name = "btnAgregarJuego";
            btnAgregarJuego.Size = new Size(179, 55);
            btnAgregarJuego.TabIndex = 7;
            btnAgregarJuego.Text = "Agregar juego";
            btnAgregarJuego.UseVisualStyleBackColor = false;
            btnAgregarJuego.Click += btnAgregarJuego_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 188);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 5;
            label4.Text = "Configuración";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 4;
            label3.Text = "Resolución";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numCostoPuntosAltaLotes);
            groupBox1.Controls.Add(cbConfiguracionAltaLotes);
            groupBox1.Controls.Add(cbResolucionAltaLotes);
            groupBox1.Controls.Add(txtTituloAltaLotes);
            groupBox1.Controls.Add(btnAgregarBorrador);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(527, 438);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(451, 382);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta en lotes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 269);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 15;
            label6.Text = "Costo puntos";
            // 
            // numCostoPuntosAltaLotes
            // 
            numCostoPuntosAltaLotes.Location = new Point(173, 268);
            numCostoPuntosAltaLotes.Name = "numCostoPuntosAltaLotes";
            numCostoPuntosAltaLotes.Size = new Size(251, 35);
            numCostoPuntosAltaLotes.TabIndex = 14;
            // 
            // cbConfiguracionAltaLotes
            // 
            cbConfiguracionAltaLotes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConfiguracionAltaLotes.FormattingEnabled = true;
            cbConfiguracionAltaLotes.Location = new Point(173, 200);
            cbConfiguracionAltaLotes.Name = "cbConfiguracionAltaLotes";
            cbConfiguracionAltaLotes.Size = new Size(251, 36);
            cbConfiguracionAltaLotes.TabIndex = 13;
            // 
            // cbResolucionAltaLotes
            // 
            cbResolucionAltaLotes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResolucionAltaLotes.FormattingEnabled = true;
            cbResolucionAltaLotes.Location = new Point(173, 140);
            cbResolucionAltaLotes.Name = "cbResolucionAltaLotes";
            cbResolucionAltaLotes.Size = new Size(251, 36);
            cbResolucionAltaLotes.TabIndex = 12;
            // 
            // txtTituloAltaLotes
            // 
            txtTituloAltaLotes.BackColor = Color.White;
            txtTituloAltaLotes.Font = new Font("Segoe UI", 12F);
            txtTituloAltaLotes.ForeColor = Color.Black;
            txtTituloAltaLotes.Location = new Point(173, 66);
            txtTituloAltaLotes.Margin = new Padding(4);
            txtTituloAltaLotes.Name = "txtTituloAltaLotes";
            txtTituloAltaLotes.Size = new Size(251, 34);
            txtTituloAltaLotes.TabIndex = 11;
            // 
            // btnAgregarBorrador
            // 
            btnAgregarBorrador.BackColor = Color.SeaGreen;
            btnAgregarBorrador.FlatStyle = FlatStyle.Flat;
            btnAgregarBorrador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarBorrador.ForeColor = Color.White;
            btnAgregarBorrador.Location = new Point(190, 325);
            btnAgregarBorrador.Margin = new Padding(4);
            btnAgregarBorrador.Name = "btnAgregarBorrador";
            btnAgregarBorrador.Size = new Size(234, 49);
            btnAgregarBorrador.TabIndex = 7;
            btnAgregarBorrador.Text = "Agregar borrador";
            btnAgregarBorrador.UseVisualStyleBackColor = false;
            btnAgregarBorrador.Click += btnAgregarBorrador_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 201);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 28);
            label7.TabIndex = 5;
            label7.Text = "Configuración";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(45, 141);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 4;
            label8.Text = "Resolución";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(89, 67);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 28);
            label9.TabIndex = 2;
            label9.Text = "Título";
            // 
            // dgvBorrador
            // 
            dgvBorrador.AllowUserToAddRows = false;
            dgvBorrador.AllowUserToDeleteRows = false;
            dgvBorrador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBorrador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvBorrador.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvBorrador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBorrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBorrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBorrador.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBorrador.EnableHeadersVisualStyles = false;
            dgvBorrador.GridColor = Color.SeaGreen;
            dgvBorrador.Location = new Point(1017, 449);
            dgvBorrador.Name = "dgvBorrador";
            dgvBorrador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvBorrador.RowHeadersWidth = 51;
            dgvBorrador.Size = new Size(524, 371);
            dgvBorrador.TabIndex = 20;
            // 
            // btnAltaLote
            // 
            btnAltaLote.BackColor = Color.SeaGreen;
            btnAltaLote.FlatStyle = FlatStyle.Flat;
            btnAltaLote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaLote.ForeColor = Color.White;
            btnAltaLote.Location = new Point(1017, 777);
            btnAltaLote.Margin = new Padding(4);
            btnAltaLote.Name = "btnAltaLote";
            btnAltaLote.Size = new Size(524, 43);
            btnAltaLote.TabIndex = 16;
            btnAltaLote.Text = "Dar de alta lote";
            btnAltaLote.UseVisualStyleBackColor = false;
            btnAltaLote.Click += btnAltaLote_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(64, 64, 64);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1092, 0);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(479, 35);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver y refrescar catálogo";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Controls.Add(cbTituloEliminar);
            btnEliminar.Controls.Add(btnBorrarJuego);
            btnEliminar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1037, 116);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(4);
            btnEliminar.Size = new Size(451, 221);
            btnEliminar.TabIndex = 22;
            btnEliminar.TabStop = false;
            btnEliminar.Text = "Eliminar juego";
            // 
            // cbTituloEliminar
            // 
            cbTituloEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTituloEliminar.FormattingEnabled = true;
            cbTituloEliminar.Location = new Point(116, 80);
            cbTituloEliminar.Name = "cbTituloEliminar";
            cbTituloEliminar.Size = new Size(251, 36);
            cbTituloEliminar.TabIndex = 16;
            // 
            // btnBorrarJuego
            // 
            btnBorrarJuego.BackColor = Color.SeaGreen;
            btnBorrarJuego.FlatStyle = FlatStyle.Flat;
            btnBorrarJuego.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarJuego.ForeColor = Color.White;
            btnBorrarJuego.Location = new Point(154, 143);
            btnBorrarJuego.Margin = new Padding(4);
            btnBorrarJuego.Name = "btnBorrarJuego";
            btnBorrarJuego.Size = new Size(234, 49);
            btnBorrarJuego.TabIndex = 7;
            btnBorrarJuego.Text = "Borrar juego";
            btnBorrarJuego.UseVisualStyleBackColor = false;
            btnBorrarJuego.Click += btnBorrarJuego_Click;
            // 
            // CatalogoJuegos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1571, 833);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(btnAltaLote);
            Controls.Add(dgvBorrador);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dgvCatalogo);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CatalogoJuegos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catálogo de juegos";
            Load += CatalogoJuegos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPuntos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCostoPuntosAltaLotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrador).EndInit();
            btnEliminar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCatalogo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCatalogo;
        private GroupBox groupBox3;
        private TextBox txtMontoTotalAlta;
        private TextBox txtHorasReservadasAlta;
        private TextBox txtUsuarioAlta;
        private Button btnAgregarJuego;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox ServidorIDAlta;
        private Label label2;
        private ComboBox cbConfiguracion;
        private ComboBox cbResolucion;
        private TextBox txtTituloJuego;
        private NumericUpDown numPuntos;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private NumericUpDown numCostoPuntosAltaLotes;
        private ComboBox cbConfiguracionAltaLotes;
        private ComboBox cbResolucionAltaLotes;
        private TextBox txtTituloAltaLotes;
        private Button btnAgregarBorrador;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgvBorrador;
        private Button btnAltaLote;
        private Button btnVolver;
        private GroupBox btnEliminar;
        private ComboBox cbTituloEliminar;
        private Button btnBorrarJuego;
    }
}