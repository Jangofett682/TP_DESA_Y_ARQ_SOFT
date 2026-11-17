namespace UI
{
    partial class CargarSaldo
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
            numMonto = new NumericUpDown();
            btnCargar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lblUsuarioActivo = new Label();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // numMonto
            // 
            numMonto.Location = new Point(168, 77);
            numMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMonto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(150, 27);
            numMonto.TabIndex = 0;
            numMonto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(68, 143);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(224, 143);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 79);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 3;
            label1.Text = "Monto a cargar:";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Location = new Point(3, 9);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(110, 20);
            lblUsuarioActivo.TabIndex = 4;
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // CargarSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 197);
            Controls.Add(lblUsuarioActivo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            Controls.Add(numMonto);
            Name = "CargarSaldo";
            Text = "CargarSaldo";
            Load += CargarSaldo_Load;
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMonto;
        private Button btnCargar;
        private Button btnCancelar;
        private Label label1;
        private Label lblUsuarioActivo;
    }
}