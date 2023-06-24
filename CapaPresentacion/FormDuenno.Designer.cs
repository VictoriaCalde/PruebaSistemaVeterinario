namespace CapaPresentacion
{
    partial class frmDuenno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_Duenno_cedula = new System.Windows.Forms.Label();
            this.label2_Duenno_nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4_Duenno_telefono = new System.Windows.Forms.Label();
            this.label5_Duenno_direccion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarDuenno = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.txtDuenno_cedula = new System.Windows.Forms.TextBox();
            this.txtDuenno_nombre = new System.Windows.Forms.TextBox();
            this.txtDuenno_apellido = new System.Windows.Forms.TextBox();
            this.txtDuenno_telefono = new System.Windows.Forms.TextBox();
            this.txtDuenno_direccion = new System.Windows.Forms.TextBox();
            this.dgvDuennos = new System.Windows.Forms.DataGridView();
            this.cbxDuenno = new System.Windows.Forms.ComboBox();
            this.btnModificarDuenno = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInactivar_duenno = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.cbxDuennoEliminado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuennos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Duenno_cedula
            // 
            this.label1_Duenno_cedula.AutoSize = true;
            this.label1_Duenno_cedula.Location = new System.Drawing.Point(32, 21);
            this.label1_Duenno_cedula.Name = "label1_Duenno_cedula";
            this.label1_Duenno_cedula.Size = new System.Drawing.Size(43, 13);
            this.label1_Duenno_cedula.TabIndex = 0;
            this.label1_Duenno_cedula.Text = "Cédula:";
            // 
            // label2_Duenno_nombre
            // 
            this.label2_Duenno_nombre.AutoSize = true;
            this.label2_Duenno_nombre.Location = new System.Drawing.Point(32, 48);
            this.label2_Duenno_nombre.Name = "label2_Duenno_nombre";
            this.label2_Duenno_nombre.Size = new System.Drawing.Size(47, 13);
            this.label2_Duenno_nombre.TabIndex = 1;
            this.label2_Duenno_nombre.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4_Duenno_telefono
            // 
            this.label4_Duenno_telefono.AutoSize = true;
            this.label4_Duenno_telefono.Location = new System.Drawing.Point(32, 101);
            this.label4_Duenno_telefono.Name = "label4_Duenno_telefono";
            this.label4_Duenno_telefono.Size = new System.Drawing.Size(52, 13);
            this.label4_Duenno_telefono.TabIndex = 3;
            this.label4_Duenno_telefono.Text = "Teléfono:";
            // 
            // label5_Duenno_direccion
            // 
            this.label5_Duenno_direccion.AutoSize = true;
            this.label5_Duenno_direccion.Location = new System.Drawing.Point(27, 131);
            this.label5_Duenno_direccion.Name = "label5_Duenno_direccion";
            this.label5_Duenno_direccion.Size = new System.Drawing.Size(55, 13);
            this.label5_Duenno_direccion.TabIndex = 4;
            this.label5_Duenno_direccion.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // btnInsertarDuenno
            // 
            this.btnInsertarDuenno.Location = new System.Drawing.Point(60, 168);
            this.btnInsertarDuenno.Name = "btnInsertarDuenno";
            this.btnInsertarDuenno.Size = new System.Drawing.Size(88, 23);
            this.btnInsertarDuenno.TabIndex = 6;
            this.btnInsertarDuenno.Text = "Insertar ";
            this.btnInsertarDuenno.UseVisualStyleBackColor = true;
            this.btnInsertarDuenno.Click += new System.EventHandler(this.btnInsertarDuenno_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(102, 231);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 7;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // txtDuenno_cedula
            // 
            this.txtDuenno_cedula.Location = new System.Drawing.Point(81, 22);
            this.txtDuenno_cedula.Name = "txtDuenno_cedula";
            this.txtDuenno_cedula.Size = new System.Drawing.Size(100, 20);
            this.txtDuenno_cedula.TabIndex = 8;
            // 
            // txtDuenno_nombre
            // 
            this.txtDuenno_nombre.Location = new System.Drawing.Point(81, 48);
            this.txtDuenno_nombre.Name = "txtDuenno_nombre";
            this.txtDuenno_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtDuenno_nombre.TabIndex = 9;
            // 
            // txtDuenno_apellido
            // 
            this.txtDuenno_apellido.Location = new System.Drawing.Point(81, 74);
            this.txtDuenno_apellido.Name = "txtDuenno_apellido";
            this.txtDuenno_apellido.Size = new System.Drawing.Size(100, 20);
            this.txtDuenno_apellido.TabIndex = 10;
            // 
            // txtDuenno_telefono
            // 
            this.txtDuenno_telefono.Location = new System.Drawing.Point(81, 98);
            this.txtDuenno_telefono.Name = "txtDuenno_telefono";
            this.txtDuenno_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtDuenno_telefono.TabIndex = 11;
            // 
            // txtDuenno_direccion
            // 
            this.txtDuenno_direccion.Location = new System.Drawing.Point(81, 128);
            this.txtDuenno_direccion.Name = "txtDuenno_direccion";
            this.txtDuenno_direccion.Size = new System.Drawing.Size(100, 20);
            this.txtDuenno_direccion.TabIndex = 12;
            // 
            // dgvDuennos
            // 
            this.dgvDuennos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuennos.Location = new System.Drawing.Point(224, 12);
            this.dgvDuennos.Name = "dgvDuennos";
            this.dgvDuennos.Size = new System.Drawing.Size(538, 212);
            this.dgvDuennos.TabIndex = 13;
            this.dgvDuennos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuennos_CellClick);
            // 
            // cbxDuenno
            // 
            this.cbxDuenno.FormattingEnabled = true;
            this.cbxDuenno.Location = new System.Drawing.Point(12, 231);
            this.cbxDuenno.Name = "cbxDuenno";
            this.cbxDuenno.Size = new System.Drawing.Size(84, 21);
            this.cbxDuenno.TabIndex = 14;
            // 
            // btnModificarDuenno
            // 
            this.btnModificarDuenno.Location = new System.Drawing.Point(12, 290);
            this.btnModificarDuenno.Name = "btnModificarDuenno";
            this.btnModificarDuenno.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDuenno.TabIndex = 16;
            this.btnModificarDuenno.Text = "Modificar ";
            this.btnModificarDuenno.UseVisualStyleBackColor = true;
            this.btnModificarDuenno.Click += new System.EventHandler(this.btnModificarDuenno_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInactivar_duenno
            // 
            this.btnInactivar_duenno.Location = new System.Drawing.Point(106, 290);
            this.btnInactivar_duenno.Name = "btnInactivar_duenno";
            this.btnInactivar_duenno.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar_duenno.TabIndex = 19;
            this.btnInactivar_duenno.Text = "Eliminar";
            this.btnInactivar_duenno.UseVisualStyleBackColor = true;
            this.btnInactivar_duenno.Click += new System.EventHandler(this.btnInactivar_duenno_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(549, 273);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 23;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // cbxDuennoEliminado
            // 
            this.cbxDuennoEliminado.FormattingEnabled = true;
            this.cbxDuennoEliminado.Location = new System.Drawing.Point(422, 275);
            this.cbxDuennoEliminado.Name = "cbxDuennoEliminado";
            this.cbxDuennoEliminado.Size = new System.Drawing.Size(121, 21);
            this.cbxDuennoEliminado.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dueños eliminados";
            // 
            // frmDuenno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.cbxDuennoEliminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInactivar_duenno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarDuenno);
            this.Controls.Add(this.cbxDuenno);
            this.Controls.Add(this.dgvDuennos);
            this.Controls.Add(this.txtDuenno_direccion);
            this.Controls.Add(this.txtDuenno_telefono);
            this.Controls.Add(this.txtDuenno_apellido);
            this.Controls.Add(this.txtDuenno_nombre);
            this.Controls.Add(this.txtDuenno_cedula);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnInsertarDuenno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5_Duenno_direccion);
            this.Controls.Add(this.label4_Duenno_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2_Duenno_nombre);
            this.Controls.Add(this.label1_Duenno_cedula);
            this.Name = "frmDuenno";
            this.Text = "Sistema Veterinario: Dueño";
            this.Load += new System.EventHandler(this.frmDuenno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuennos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Duenno_cedula;
        private System.Windows.Forms.Label label2_Duenno_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4_Duenno_telefono;
        private System.Windows.Forms.Label label5_Duenno_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertarDuenno;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.TextBox txtDuenno_cedula;
        private System.Windows.Forms.TextBox txtDuenno_nombre;
        private System.Windows.Forms.TextBox txtDuenno_apellido;
        private System.Windows.Forms.TextBox txtDuenno_telefono;
        private System.Windows.Forms.TextBox txtDuenno_direccion;
        private System.Windows.Forms.DataGridView dgvDuennos;
        private System.Windows.Forms.ComboBox cbxDuenno;
        private System.Windows.Forms.Button btnModificarDuenno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInactivar_duenno;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.ComboBox cbxDuennoEliminado;
        private System.Windows.Forms.Label label5;
    }
}

