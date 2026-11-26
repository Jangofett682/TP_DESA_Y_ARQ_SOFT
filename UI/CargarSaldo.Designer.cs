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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarSaldo));
            numMonto = new NumericUpDown();
            btnCargar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lblUsuarioActivo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // numMonto
            // 
            numMonto.Font = new Font("Segoe UI", 12F);
            numMonto.Location = new Point(209, 83);
            numMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMonto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(129, 34);
            numMonto.TabIndex = 0;
            numMonto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.SeaGreen;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Segoe UI", 12F);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(57, 143);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(116, 50);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(213, 143);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 3;
            label1.Text = "Monto a cargar:    $";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.BackColor = Color.SeaGreen;
            lblUsuarioActivo.Font = new Font("Segoe UI", 12F);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(3, 0);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(146, 28);
            lblUsuarioActivo.TabIndex = 4;
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SeaGreen;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(394, 31);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // CargarSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(394, 235);
            Controls.Add(lblUsuarioActivo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            Controls.Add(numMonto);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CargarSaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar saldo";
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}