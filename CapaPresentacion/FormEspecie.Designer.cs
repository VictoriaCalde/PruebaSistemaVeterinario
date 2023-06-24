namespace CapaPresentacion
{
    partial class FrmEspecie
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
            this.txtEspecie_descripcion = new System.Windows.Forms.TextBox();
            this.dgvEspecies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarDescripcion_especie = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargar_datos = new System.Windows.Forms.Button();
            this.cbxDatosEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.cbxEspeEliminado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEspecie_descripcion
            // 
            this.txtEspecie_descripcion.Location = new System.Drawing.Point(18, 45);
            this.txtEspecie_descripcion.Multiline = true;
            this.txtEspecie_descripcion.Name = "txtEspecie_descripcion";
            this.txtEspecie_descripcion.Size = new System.Drawing.Size(150, 32);
            this.txtEspecie_descripcion.TabIndex = 1;
            // 
            // dgvEspecies
            // 
            this.dgvEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecies.Location = new System.Drawing.Point(366, 45);
            this.dgvEspecies.Name = "dgvEspecies";
            this.dgvEspecies.Size = new System.Drawing.Size(134, 124);
            this.dgvEspecies.TabIndex = 2;
            this.dgvEspecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecies_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripciones";
            // 
            // btnInsertarDescripcion_especie
            // 
            this.btnInsertarDescripcion_especie.Location = new System.Drawing.Point(57, 81);
            this.btnInsertarDescripcion_especie.Name = "btnInsertarDescripcion_especie";
            this.btnInsertarDescripcion_especie.Size = new System.Drawing.Size(75, 38);
            this.btnInsertarDescripcion_especie.TabIndex = 4;
            this.btnInsertarDescripcion_especie.Text = "Insertar ";
            this.btnInsertarDescripcion_especie.UseVisualStyleBackColor = true;
            this.btnInsertarDescripcion_especie.Click += new System.EventHandler(this.btnInsertarDescripcion_especie_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(93, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 206);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 25);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargar_datos
            // 
            this.btnCargar_datos.Location = new System.Drawing.Point(138, 159);
            this.btnCargar_datos.Name = "btnCargar_datos";
            this.btnCargar_datos.Size = new System.Drawing.Size(75, 35);
            this.btnCargar_datos.TabIndex = 7;
            this.btnCargar_datos.Text = "Cargar información";
            this.btnCargar_datos.UseVisualStyleBackColor = true;
            this.btnCargar_datos.Click += new System.EventHandler(this.btnCargar_datos_Click);
            // 
            // cbxDatosEspecie
            // 
            this.cbxDatosEspecie.FormattingEnabled = true;
            this.cbxDatosEspecie.Location = new System.Drawing.Point(11, 167);
            this.cbxDatosEspecie.Name = "cbxDatosEspecie";
            this.cbxDatosEspecie.Size = new System.Drawing.Size(121, 21);
            this.cbxDatosEspecie.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descripcion";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(481, 228);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 26;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // cbxEspeEliminado
            // 
            this.cbxEspeEliminado.FormattingEnabled = true;
            this.cbxEspeEliminado.Location = new System.Drawing.Point(354, 228);
            this.cbxEspeEliminado.Name = "cbxEspeEliminado";
            this.cbxEspeEliminado.Size = new System.Drawing.Size(121, 21);
            this.cbxEspeEliminado.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Especies eliminadas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(531, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 378);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.cbxEspeEliminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDatosEspecie);
            this.Controls.Add(this.btnCargar_datos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertarDescripcion_especie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEspecies);
            this.Controls.Add(this.txtEspecie_descripcion);
            this.Name = "FrmEspecie";
            this.Text = "Sistema Veterinario: Especie";
            this.Load += new System.EventHandler(this.FrmEspecie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEspecie_descripcion;
        private System.Windows.Forms.DataGridView dgvEspecies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarDescripcion_especie;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar_datos;
        private System.Windows.Forms.ComboBox cbxDatosEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.ComboBox cbxEspeEliminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
    }
}