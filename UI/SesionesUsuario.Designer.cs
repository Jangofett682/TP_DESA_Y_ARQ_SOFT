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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvSesionesUsuario).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHorasModificacion).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSesionesUsuario
            // 
            dgvSesionesUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSesionesUsuario.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvSesionesUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSesionesUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSesionesUsuario.GridColor = Color.SeaGreen;
            dgvSesionesUsuario.Location = new Point(7, 87);
            dgvSesionesUsuario.Name = "dgvSesionesUsuario";
            dgvSesionesUsuario.RowHeadersWidth = 51;
            dgvSesionesUsuario.Size = new Size(830, 418);
            dgvSesionesUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbIDEliminar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(866, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eliminar sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // cbIDEliminar
            // 
            cbIDEliminar.FormattingEnabled = true;
            cbIDEliminar.Location = new Point(83, 39);
            cbIDEliminar.Name = "cbIDEliminar";
            cbIDEliminar.Size = new Size(135, 36);
            cbIDEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(89, 81);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numHorasModificacion);
            groupBox2.Controls.Add(cbIDModificar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(866, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 257);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 5;
            label3.Text = "Horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // numHorasModificacion
            // 
            numHorasModificacion.Location = new Point(89, 107);
            numHorasModificacion.Name = "numHorasModificacion";
            numHorasModificacion.Size = new Size(134, 34);
            numHorasModificacion.TabIndex = 3;
            // 
            // cbIDModificar
            // 
            cbIDModificar.FormattingEnabled = true;
            cbIDModificar.Location = new Point(89, 36);
            cbIDModificar.Name = "cbIDModificar";
            cbIDModificar.Size = new Size(134, 36);
            cbIDModificar.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SeaGreen;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(89, 175);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(129, 34);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += button1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(3, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(198, 28);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Gestione sus sesiones";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SeaGreen;
            flowLayoutPanel1.Controls.Add(lblUsuario);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1125, 35);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // SesionesUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1125, 531);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvSesionesUsuario);
            Controls.Add(flowLayoutPanel1);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}