namespace CapaPresentacion
{
    partial class FrmVeterinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar_Veterinario = new System.Windows.Forms.Button();
            this.btnModificar_Veterinario = new System.Windows.Forms.Button();
            this.txtVeterinario_cedula = new System.Windows.Forms.TextBox();
            this.txtVeterinario_nombre = new System.Windows.Forms.TextBox();
            this.txtVeterinario_telefono = new System.Windows.Forms.TextBox();
            this.txtVeterinario_direccion = new System.Windows.Forms.TextBox();
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnCargarDatosInactivos_veterinario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxVeteEliminado = new System.Windows.Forms.ComboBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Télefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // btnInsertar_Veterinario
            // 
            this.btnInsertar_Veterinario.Location = new System.Drawing.Point(20, 167);
            this.btnInsertar_Veterinario.Name = "btnInsertar_Veterinario";
            this.btnInsertar_Veterinario.Size = new System.Drawing.Size(71, 23);
            this.btnInsertar_Veterinario.TabIndex = 4;
            this.btnInsertar_Veterinario.Text = "Insertar";
            this.btnInsertar_Veterinario.UseVisualStyleBackColor = true;
            this.btnInsertar_Veterinario.Click += new System.EventHandler(this.btnInsertar_Veterinario_Click);
            // 
            // btnModificar_Veterinario
            // 
            this.btnModificar_Veterinario.Location = new System.Drawing.Point(12, 283);
            this.btnModificar_Veterinario.Name = "btnModificar_Veterinario";
            this.btnModificar_Veterinario.Size = new System.Drawing.Size(79, 21);
            this.btnModificar_Veterinario.TabIndex = 5;
            this.btnModificar_Veterinario.Text = "Modificar";
            this.btnModificar_Veterinario.UseVisualStyleBackColor = true;
            this.btnModificar_Veterinario.Click += new System.EventHandler(this.btnModificar_Veterinario_Click);
            // 
            // txtVeterinario_cedula
            // 
            this.txtVeterinario_cedula.Location = new System.Drawing.Point(94, 18);
            this.txtVeterinario_cedula.Name = "txtVeterinario_cedula";
            this.txtVeterinario_cedula.Size = new System.Drawing.Size(100, 20);
            this.txtVeterinario_cedula.TabIndex = 6;
            // 
            // txtVeterinario_nombre
            // 
            this.txtVeterinario_nombre.Location = new System.Drawing.Point(94, 54);
            this.txtVeterinario_nombre.Name = "txtVeterinario_nombre";
            this.txtVeterinario_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtVeterinario_nombre.TabIndex = 7;
            // 
            // txtVeterinario_telefono
            // 
            this.txtVeterinario_telefono.Location = new System.Drawing.Point(94, 89);
            this.txtVeterinario_telefono.Name = "txtVeterinario_telefono";
            this.txtVeterinario_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtVeterinario_telefono.TabIndex = 8;
            // 
            // txtVeterinario_direccion
            // 
            this.txtVeterinario_direccion.Location = new System.Drawing.Point(94, 118);
            this.txtVeterinario_direccion.Name = "txtVeterinario_direccion";
            this.txtVeterinario_direccion.Size = new System.Drawing.Size(100, 20);
            this.txtVeterinario_direccion.TabIndex = 9;
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Location = new System.Drawing.Point(325, 12);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.Size = new System.Drawing.Size(389, 158);
            this.dgvVeterinarios.TabIndex = 10;
            this.dgvVeterinarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeterinarios_CellClick);
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(12, 237);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(121, 21);
            this.cbxVeterinario.TabIndex = 12;
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(129, 283);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 13;
            this.btnInactivar.Text = "Eliminar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnCargarDatosInactivos_veterinario
            // 
            this.btnCargarDatosInactivos_veterinario.Location = new System.Drawing.Point(151, 237);
            this.btnCargarDatosInactivos_veterinario.Name = "btnCargarDatosInactivos_veterinario";
            this.btnCargarDatosInactivos_veterinario.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatosInactivos_veterinario.TabIndex = 16;
            this.btnCargarDatosInactivos_veterinario.Text = "Cargar datos";
            this.btnCargarDatosInactivos_veterinario.UseVisualStyleBackColor = true;
            this.btnCargarDatosInactivos_veterinario.Click += new System.EventHandler(this.btnCargarDatosInactivos_veterinario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Veterinarios eliminados";
            // 
            // cbxVeteEliminado
            // 
            this.cbxVeteEliminado.FormattingEnabled = true;
            this.cbxVeteEliminado.Location = new System.Drawing.Point(423, 227);
            this.cbxVeteEliminado.Name = "cbxVeteEliminado";
            this.cbxVeteEliminado.Size = new System.Drawing.Size(121, 21);
            this.cbxVeteEliminado.TabIndex = 18;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(568, 225);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 19;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(608, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 404);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.cbxVeteEliminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargarDatosInactivos_veterinario);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.cbxVeterinario);
            this.Controls.Add(this.dgvVeterinarios);
            this.Controls.Add(this.txtVeterinario_direccion);
            this.Controls.Add(this.txtVeterinario_telefono);
            this.Controls.Add(this.txtVeterinario_nombre);
            this.Controls.Add(this.txtVeterinario_cedula);
            this.Controls.Add(this.btnModificar_Veterinario);
            this.Controls.Add(this.btnInsertar_Veterinario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVeterinario";
            this.Text = "Sistema Veterinario: Veterinario";
            this.Load += new System.EventHandler(this.FrmVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar_Veterinario;
        private System.Windows.Forms.Button btnModificar_Veterinario;
        private System.Windows.Forms.TextBox txtVeterinario_cedula;
        private System.Windows.Forms.TextBox txtVeterinario_nombre;
        private System.Windows.Forms.TextBox txtVeterinario_telefono;
        private System.Windows.Forms.TextBox txtVeterinario_direccion;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnCargarDatosInactivos_veterinario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxVeteEliminado;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnSalir;
    }
}