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
            groupBox1 = new GroupBox();
            label1 = new Label();
            cbIDEliminar = new ComboBox();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            numHorasModificacion = new NumericUpDown();
            cbIDModificar = new ComboBox();
            btnModificar = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSesionesUsuario).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHorasModificacion).BeginInit();
            SuspendLayout();
            // 
            // dgvSesionesUsuario
            // 
            dgvSesionesUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesionesUsuario.Location = new Point(7, 87);
            dgvSesionesUsuario.Name = "dgvSesionesUsuario";
            dgvSesionesUsuario.RowHeadersWidth = 51;
            dgvSesionesUsuario.Size = new Size(830, 394);
            dgvSesionesUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbIDEliminar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Location = new Point(843, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eliminar sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // cbIDEliminar
            // 
            cbIDEliminar.FormattingEnabled = true;
            cbIDEliminar.Location = new Point(62, 37);
            cbIDEliminar.Name = "cbIDEliminar";
            cbIDEliminar.Size = new Size(135, 28);
            cbIDEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(103, 81);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numHorasModificacion);
            groupBox2.Controls.Add(cbIDModificar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(843, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 233);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 44);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // numHorasModificacion
            // 
            numHorasModificacion.Location = new Point(62, 113);
            numHorasModificacion.Name = "numHorasModificacion";
            numHorasModificacion.Size = new Size(134, 27);
            numHorasModificacion.TabIndex = 3;
            // 
            // cbIDModificar
            // 
            cbIDModificar.FormattingEnabled = true;
            cbIDModificar.Location = new Point(62, 36);
            cbIDModificar.Name = "cbIDModificar";
            cbIDModificar.Size = new Size(134, 28);
            cbIDModificar.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(89, 175);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Bienvenido";
            // 
            // SesionesUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 502);
            Controls.Add(lblUsuario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvSesionesUsuario);
            Name = "SesionesUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SesionesUsuario";
            Load += SesionesUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSesionesUsuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHorasModificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSesionesUsuario;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private ComboBox cbIDEliminar;
        private GroupBox groupBox2;
        private NumericUpDown numHorasModificacion;
        private ComboBox cbIDModificar;
        private Button btnModificar;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblUsuario;
    }
}