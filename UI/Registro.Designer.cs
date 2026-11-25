namespace UI
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtMail = new TextBox();
            txtNombreApellido = new TextBox();
            txtSaldo = new TextBox();
            btnRegistrarse = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 2;
            label3.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 372);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 4;
            label5.Text = "Saldo Disponible";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(227, 90);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 34);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(227, 178);
            txtMail.Margin = new Padding(4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(280, 34);
            txtMail.TabIndex = 6;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Font = new Font("Segoe UI", 12F);
            txtNombreApellido.Location = new Point(227, 277);
            txtNombreApellido.Margin = new Padding(4);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(280, 34);
            txtNombreApellido.TabIndex = 8;
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 12F);
            txtSaldo.Location = new Point(227, 372);
            txtSaldo.Margin = new Padding(4);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(280, 34);
            txtSaldo.TabIndex = 9;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.SeaGreen;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 12F);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(338, 462);
            btnRegistrarse.Margin = new Padding(4);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(170, 53);
            btnRegistrarse.TabIndex = 10;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(19, 462);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 53);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(199, 26);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 36);
            label6.TabIndex = 12;
            label6.Text = "Regístrese";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(568, 543);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtSaldo);
            Controls.Add(txtNombreApellido);
            Controls.Add(txtMail);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtMail;
        private TextBox txtNombreApellido;
        private TextBox txtSaldo;
        private Button btnRegistrarse;
        private Button btnCancelar;
        private Label label6;
    }
}