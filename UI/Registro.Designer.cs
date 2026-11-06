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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtMail = new TextBox();
            txtContraseña = new TextBox();
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
            label1.Location = new Point(45, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 293);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 147);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 211);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 361);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Saldo Disponible";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(187, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 27);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(187, 147);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(205, 27);
            txtMail.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(187, 208);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(205, 27);
            txtContraseña.TabIndex = 7;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(187, 293);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(205, 27);
            txtNombreApellido.TabIndex = 8;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(187, 361);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(205, 27);
            txtSaldo.TabIndex = 9;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(301, 425);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(124, 56);
            btnRegistrarse.TabIndex = 10;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(122, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 29);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "Regístrese";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 502);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtSaldo);
            Controls.Add(txtNombreApellido);
            Controls.Add(txtContraseña);
            Controls.Add(txtMail);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtMail;
        private TextBox txtContraseña;
        private TextBox txtNombreApellido;
        private TextBox txtSaldo;
        private Button btnRegistrarse;
        private Button btnCancelar;
        private Label label6;
    }
}