namespace DemoPatronProductorConsumidor
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
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TxtCorreoElectronico = new TextBox();
            label2 = new Label();
            TxtNombre = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            BtnProcesar = new Button();
            DgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtCorreoElectronico);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 163);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = SystemColors.Info;
            BtnRegistrar.Location = new Point(303, 133);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(81, 27);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtCorreoElectronico
            // 
            TxtCorreoElectronico.Location = new Point(14, 101);
            TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            TxtCorreoElectronico.Size = new Size(379, 23);
            TxtCorreoElectronico.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico :";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(10, 35);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(383, 23);
            TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(DgvUsuarios);
            panel2.Location = new Point(12, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 182);
            panel2.TabIndex = 1;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = SystemColors.Info;
            BtnProcesar.Location = new Point(464, 3);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(75, 23);
            BtnProcesar.TabIndex = 1;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += button2_Click;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.AllowUserToAddRows = false;
            DgvUsuarios.AllowUserToDeleteRows = false;
            DgvUsuarios.BackgroundColor = SystemColors.ActiveCaption;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            DgvUsuarios.Location = new Point(0, 0);
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.ReadOnly = true;
            DgvUsuarios.Size = new Size(458, 182);
            DgvUsuarios.TabIndex = 0;
            DgvUsuarios.CellContentClick += DgvUsuarios_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 425);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostración patrón Productor - Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox TxtNombre;
        private Label label1;
        private TextBox TxtCorreoElectronico;
        private Button BtnRegistrar;
        private Panel panel2;
        private DataGridView DgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Button BtnProcesar;
    }
}
