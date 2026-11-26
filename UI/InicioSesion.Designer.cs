namespace UI
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            label1 = new Label();
            txtUsuario = new TextBox();
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 95);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(186, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(145, 34);
            txtUsuario.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(64, 64, 64);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(219, 158);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(140, 43);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 12F);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(64, 158);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(140, 43);
            btnRegistrarse.TabIndex = 5;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(121, 26);
            label3.Name = "label3";
            label3.Size = new Size(165, 34);
            label3.TabIndex = 6;
            label3.Text = "Cloud Gaming";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(417, 225);
            Controls.Add(label3);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
        private Label label3;
    }
}