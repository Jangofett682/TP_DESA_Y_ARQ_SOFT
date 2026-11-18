namespace UI
{
    partial class SesionesUsuario
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
            dgvSesionesUsuario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSesionesUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvSesionesUsuario
            // 
            dgvSesionesUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesionesUsuario.Location = new Point(41, 30);
            dgvSesionesUsuario.Name = "dgvSesionesUsuario";
            dgvSesionesUsuario.RowHeadersWidth = 51;
            dgvSesionesUsuario.Size = new Size(678, 394);
            dgvSesionesUsuario.TabIndex = 0;
            // 
            // SesionesUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSesionesUsuario);
            Name = "SesionesUsuario";
            Text = "SesionesUsuario";
            Load += SesionesUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSesionesUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSesionesUsuario;
    }
}