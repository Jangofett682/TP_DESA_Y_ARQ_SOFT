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
            groupBox2 = new GroupBox();
            dgvServidores = new DataGridView();
            dgvJuegos = new DataGridView();
            lblUsuario = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServidores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvServidores);
            groupBox1.Location = new Point(39, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 530);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servidores";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvJuegos);
            groupBox2.Location = new Point(461, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 529);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Juegos";
            // 
            // dgvServidores
            // 
            dgvServidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServidores.Location = new Point(6, 27);
            dgvServidores.Name = "dgvServidores";
            dgvServidores.RowHeadersWidth = 51;
            dgvServidores.Size = new Size(361, 497);
            dgvServidores.TabIndex = 0;
            // 
            // dgvJuegos
            // 
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(6, 32);
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.RowHeadersWidth = 51;
            dgvJuegos.Size = new Size(361, 491);
            dgvJuegos.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Bienvenido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 578);
            Controls.Add(lblUsuario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServidores).EndInit();
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
    }
}
