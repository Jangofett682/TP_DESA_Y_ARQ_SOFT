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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServidores).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvServidores);
            groupBox1.Location = new Point(39, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 552);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servidores";
            // 
            // dgvServidores
            // 
            dgvServidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServidores.Location = new Point(6, 27);
            dgvServidores.Name = "dgvServidores";
            dgvServidores.RowHeadersWidth = 51;
            dgvServidores.Size = new Size(361, 519);
            dgvServidores.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvJuegos);
            groupBox2.Location = new Point(458, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 546);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Juegos";
            // 
            // dgvJuegos
            // 
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(9, 27);
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.RowHeadersWidth = 51;
            dgvJuegos.Size = new Size(361, 519);
            dgvJuegos.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(39, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Bienvenido";
            // 
            // btnCambiarCuenta
            // 
            btnCambiarCuenta.Location = new Point(1004, 4);
            btnCambiarCuenta.Name = "btnCambiarCuenta";
            btnCambiarCuenta.Size = new Size(149, 31);
            btnCambiarCuenta.TabIndex = 3;
            btnCambiarCuenta.Text = "Cambiar cuenta";
            btnCambiarCuenta.UseVisualStyleBackColor = true;
            btnCambiarCuenta.Click += btnCambiarCuenta_Click;
            // 
            // txtCargarSaldo
            // 
            txtCargarSaldo.Location = new Point(1164, 4);
            txtCargarSaldo.Name = "txtCargarSaldo";
            txtCargarSaldo.Size = new Size(149, 31);
            txtCargarSaldo.TabIndex = 4;
            txtCargarSaldo.Text = "Cargar saldo";
            txtCargarSaldo.UseVisualStyleBackColor = true;
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
            groupBox3.Location = new Point(881, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 430);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nueva sesión";
            // 
            // txtMontoTotalAlta
            // 
            txtMontoTotalAlta.Location = new Point(204, 295);
            txtMontoTotalAlta.Name = "txtMontoTotalAlta";
            txtMontoTotalAlta.Size = new Size(191, 27);
            txtMontoTotalAlta.TabIndex = 10;
            // 
            // txtHorasReservadasAlta
            // 
            txtHorasReservadasAlta.Location = new Point(204, 235);
            txtHorasReservadasAlta.Name = "txtHorasReservadasAlta";
            txtHorasReservadasAlta.Size = new Size(191, 27);
            txtHorasReservadasAlta.TabIndex = 9;
            // 
            // txtUsuarioAlta
            // 
            txtUsuarioAlta.Location = new Point(204, 181);
            txtUsuarioAlta.Name = "txtUsuarioAlta";
            txtUsuarioAlta.Size = new Size(191, 27);
            txtUsuarioAlta.TabIndex = 8;
            // 
            // btnAgregarSesion
            // 
            btnAgregarSesion.Location = new Point(192, 373);
            btnAgregarSesion.Name = "btnAgregarSesion";
            btnAgregarSesion.Size = new Size(143, 29);
            btnAgregarSesion.TabIndex = 7;
            btnAgregarSesion.Text = "Agregar sesión";
            btnAgregarSesion.UseVisualStyleBackColor = true;
            btnAgregarSesion.Click += btnAgregarSesion_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 295);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 6;
            label5.Text = "Monto total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 235);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 5;
            label4.Text = "Horas reservadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 181);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre Usuario";
            // 
            // ServidorIDAlta
            // 
            ServidorIDAlta.FormattingEnabled = true;
            ServidorIDAlta.Location = new Point(204, 113);
            ServidorIDAlta.Name = "ServidorIDAlta";
            ServidorIDAlta.Size = new Size(191, 28);
            ServidorIDAlta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 113);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Servidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Juego";
            // 
            // cbJuegoIDAlta
            // 
            cbJuegoIDAlta.FormattingEnabled = true;
            cbJuegoIDAlta.Location = new Point(204, 50);
            cbJuegoIDAlta.Name = "cbJuegoIDAlta";
            cbJuegoIDAlta.Size = new Size(191, 28);
            cbJuegoIDAlta.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 647);
            Controls.Add(groupBox3);
            Controls.Add(txtCargarSaldo);
            Controls.Add(btnCambiarCuenta);
            Controls.Add(lblUsuario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}
