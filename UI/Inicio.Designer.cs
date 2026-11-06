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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServidores).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
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
            btnCambiarCuenta.Location = new Point(298, 4);
            btnCambiarCuenta.Name = "btnCambiarCuenta";
            btnCambiarCuenta.Size = new Size(149, 31);
            btnCambiarCuenta.TabIndex = 3;
            btnCambiarCuenta.Text = "Cambiar cuenta";
            btnCambiarCuenta.UseVisualStyleBackColor = true;
            btnCambiarCuenta.Click += btnCambiarCuenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 647);
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
    }
}
