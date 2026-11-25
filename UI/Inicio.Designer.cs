namespace PlantillaCapas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvServidores = new DataGridView();
            groupBox2 = new GroupBox();
            dgvJuegos = new DataGridView();
            lblUsuario = new Label();
            btnCambiarCuenta = new Button();
            txtCargarSaldo = new Button();
            groupBox3 = new GroupBox();
            txtMontoTotalAlta = new TextBox();
            txtHorasReservadasAlta = new TextBox();
            txtUsuarioAlta = new TextBox();
            btnAgregarSesion = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ServidorIDAlta = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbJuegoIDAlta = new ComboBox();
            txtVerSesionesUsuario = new Button();
            lblUsuarioNombre = new Label();
            lblSaldoActual = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServidores).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvServidores);
            groupBox1.Font = new Font("Bahnschrift SemiCondensed", 16.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 92);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(714, 607);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servidores";
            // 
            // dgvServidores
            // 
            dgvServidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvServidores.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvServidores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvServidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServidores.GridColor = Color.SeaGreen;
            dgvServidores.Location = new Point(8, 36);
            dgvServidores.Margin = new Padding(4);
            dgvServidores.Name = "dgvServidores";
            dgvServidores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvServidores.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dgvServidores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServidores.Size = new Size(699, 564);
            dgvServidores.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvJuegos);
            groupBox2.Font = new Font("Bahnschrift SemiCondensed", 16.2F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(753, 92);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(621, 607);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Juegos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvJuegos
            // 
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvJuegos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvJuegos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.GridColor = Color.SeaGreen;
            dgvJuegos.Location = new Point(11, 36);
            dgvJuegos.Margin = new Padding(4);
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvJuegos.RowHeadersWidth = 51;
            dgvJuegos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvJuegos.Size = new Size(602, 559);
            dgvJuegos.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.SeaGreen;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(49, 10);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Bienvenido";
            // 
            // btnCambiarCuenta
            // 
            btnCambiarCuenta.BackColor = Color.FromArgb(64, 64, 64);
            btnCambiarCuenta.FlatStyle = FlatStyle.Flat;
            btnCambiarCuenta.Font = new Font("Segoe UI", 12F);
            btnCambiarCuenta.ForeColor = Color.White;
            btnCambiarCuenta.Location = new Point(1021, 2);
            btnCambiarCuenta.Margin = new Padding(4);
            btnCambiarCuenta.Name = "btnCambiarCuenta";
            btnCambiarCuenta.Size = new Size(186, 41);
            btnCambiarCuenta.TabIndex = 3;
            btnCambiarCuenta.Text = "Cambiar cuenta";
            btnCambiarCuenta.UseVisualStyleBackColor = false;
            btnCambiarCuenta.Click += btnCambiarCuenta_Click;
            // 
            // txtCargarSaldo
            // 
            txtCargarSaldo.BackColor = Color.FromArgb(64, 64, 64);
            txtCargarSaldo.FlatStyle = FlatStyle.Flat;
            txtCargarSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargarSaldo.ForeColor = Color.White;
            txtCargarSaldo.Location = new Point(1455, 4);
            txtCargarSaldo.Margin = new Padding(4);
            txtCargarSaldo.Name = "txtCargarSaldo";
            txtCargarSaldo.Size = new Size(186, 39);
            txtCargarSaldo.TabIndex = 4;
            txtCargarSaldo.Text = "Cargar saldo";
            txtCargarSaldo.UseVisualStyleBackColor = false;
            txtCargarSaldo.Click += txtCargarSaldo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMontoTotalAlta);
            groupBox3.Controls.Add(txtHorasReservadasAlta);
            groupBox3.Controls.Add(txtUsuarioAlta);
            groupBox3.Controls.Add(btnAgregarSesion);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(ServidorIDAlta);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cbJuegoIDAlta);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(1416, 92);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(464, 473);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nueva sesión";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtMontoTotalAlta
            // 
            txtMontoTotalAlta.Font = new Font("Microsoft Sans Serif", 12F);
            txtMontoTotalAlta.ForeColor = Color.Black;
            txtMontoTotalAlta.Location = new Point(195, 327);
            txtMontoTotalAlta.Margin = new Padding(4);
            txtMontoTotalAlta.Name = "txtMontoTotalAlta";
            txtMontoTotalAlta.Size = new Size(251, 30);
            txtMontoTotalAlta.TabIndex = 10;
            // 
            // txtHorasReservadasAlta
            // 
            txtHorasReservadasAlta.Font = new Font("Microsoft Sans Serif", 12F);
            txtHorasReservadasAlta.ForeColor = Color.Black;
            txtHorasReservadasAlta.Location = new Point(195, 262);
            txtHorasReservadasAlta.Margin = new Padding(4);
            txtHorasReservadasAlta.Name = "txtHorasReservadasAlta";
            txtHorasReservadasAlta.Size = new Size(251, 30);
            txtHorasReservadasAlta.TabIndex = 9;
            txtHorasReservadasAlta.TextChanged += txtHorasReservadasAlta_TextChanged;
            // 
            // txtUsuarioAlta
            // 
            txtUsuarioAlta.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuarioAlta.ForeColor = Color.Black;
            txtUsuarioAlta.Location = new Point(195, 202);
            txtUsuarioAlta.Margin = new Padding(4);
            txtUsuarioAlta.Name = "txtUsuarioAlta";
            txtUsuarioAlta.Size = new Size(251, 30);
            txtUsuarioAlta.TabIndex = 8;
            // 
            // btnAgregarSesion
            // 
            btnAgregarSesion.BackColor = Color.SeaGreen;
            btnAgregarSesion.FlatStyle = FlatStyle.Flat;
            btnAgregarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSesion.ForeColor = Color.White;
            btnAgregarSesion.Location = new Point(195, 409);
            btnAgregarSesion.Margin = new Padding(4);
            btnAgregarSesion.Name = "btnAgregarSesion";
            btnAgregarSesion.Size = new Size(179, 38);
            btnAgregarSesion.TabIndex = 7;
            btnAgregarSesion.Text = "Agregar sesión";
            btnAgregarSesion.UseVisualStyleBackColor = false;
            btnAgregarSesion.Click += btnAgregarSesion_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 333);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 6;
            label5.Text = "Monto total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 5;
            label4.Text = "Horas reservadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre Usuario";
            // 
            // ServidorIDAlta
            // 
            ServidorIDAlta.Font = new Font("Microsoft Sans Serif", 12F);
            ServidorIDAlta.ForeColor = Color.Black;
            ServidorIDAlta.FormattingEnabled = true;
            ServidorIDAlta.Location = new Point(195, 128);
            ServidorIDAlta.Margin = new Padding(4);
            ServidorIDAlta.Name = "ServidorIDAlta";
            ServidorIDAlta.Size = new Size(251, 33);
            ServidorIDAlta.TabIndex = 3;
            ServidorIDAlta.SelectedIndexChanged += ServidorIDAlta_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 2;
            label2.Text = "Servidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Juego";
            // 
            // cbJuegoIDAlta
            // 
            cbJuegoIDAlta.Font = new Font("Microsoft Sans Serif", 12F);
            cbJuegoIDAlta.ForeColor = Color.Black;
            cbJuegoIDAlta.FormattingEnabled = true;
            cbJuegoIDAlta.Location = new Point(195, 58);
            cbJuegoIDAlta.Margin = new Padding(4);
            cbJuegoIDAlta.Name = "cbJuegoIDAlta";
            cbJuegoIDAlta.Size = new Size(251, 33);
            cbJuegoIDAlta.TabIndex = 0;
            cbJuegoIDAlta.SelectedIndexChanged += cbJuegoIDAlta_SelectedIndexChanged;
            // 
            // txtVerSesionesUsuario
            // 
            txtVerSesionesUsuario.BackColor = Color.FromArgb(64, 64, 64);
            txtVerSesionesUsuario.FlatStyle = FlatStyle.Flat;
            txtVerSesionesUsuario.Font = new Font("Segoe UI", 12F);
            txtVerSesionesUsuario.ForeColor = Color.White;
            txtVerSesionesUsuario.Location = new Point(1269, 3);
            txtVerSesionesUsuario.Margin = new Padding(4);
            txtVerSesionesUsuario.Name = "txtVerSesionesUsuario";
            txtVerSesionesUsuario.Size = new Size(179, 40);
            txtVerSesionesUsuario.TabIndex = 11;
            txtVerSesionesUsuario.Text = "Vea sus sesiones";
            txtVerSesionesUsuario.UseVisualStyleBackColor = false;
            txtVerSesionesUsuario.Click += txtVerSesionesUsuario_Click;
            // 
            // lblUsuarioNombre
            // 
            lblUsuarioNombre.AutoSize = true;
            lblUsuarioNombre.BackColor = Color.SeaGreen;
            lblUsuarioNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuarioNombre.ForeColor = Color.White;
            lblUsuarioNombre.Location = new Point(159, 10);
            lblUsuarioNombre.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioNombre.Name = "lblUsuarioNombre";
            lblUsuarioNombre.Size = new Size(20, 25);
            lblUsuarioNombre.TabIndex = 12;
            lblUsuarioNombre.Text = "-";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Microsoft Sans Serif", 12F);
            lblSaldoActual.ForeColor = Color.White;
            lblSaldoActual.Location = new Point(49, 48);
            lblSaldoActual.Margin = new Padding(4, 0, 4, 0);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(143, 25);
            lblSaldoActual.TabIndex = 13;
            lblSaldoActual.Text = "Saldo actual:  -";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SeaGreen;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1893, 45);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1893, 730);
            Controls.Add(lblSaldoActual);
            Controls.Add(lblUsuarioNombre);
            Controls.Add(txtVerSesionesUsuario);
            Controls.Add(groupBox3);
            Controls.Add(txtCargarSaldo);
            Controls.Add(btnCambiarCuenta);
            Controls.Add(lblUsuario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 10.8F);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServidores).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvServidores;
        private GroupBox groupBox2;
        private DataGridView dgvJuegos;
        private Label lblUsuario;
        private Button btnCambiarCuenta;
        private Button txtCargarSaldo;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox cbJuegoIDAlta;
        private ComboBox ServidorIDAlta;
        private Label label2;
        private Button btnAgregarSesion;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMontoTotalAlta;
        private TextBox txtHorasReservadasAlta;
        private TextBox txtUsuarioAlta;
        private Button txtVerSesionesUsuario;
        private Label lblUsuarioNombre;
        private Label lblSaldoActual;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
