namespace CapaPresentacion
{
    partial class FrmTratamiento
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
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxDatosTratamiento = new System.Windows.Forms.ComboBox();
            this.cbxMedicamento = new System.Windows.Forms.ComboBox();
            this.dgvTratamiento = new System.Windows.Forms.DataGridView();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxTrataEliminadas = new System.Windows.Forms.ComboBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observaciones:";
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(107, 81);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(104, 20);
            this.txtDosis.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(107, 141);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(104, 20);
            this.txtObservaciones.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(30, 184);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 292);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 292);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxDatosTratamiento
            // 
            this.cbxDatosTratamiento.FormattingEnabled = true;
            this.cbxDatosTratamiento.Location = new System.Drawing.Point(16, 235);
            this.cbxDatosTratamiento.Name = "cbxDatosTratamiento";
            this.cbxDatosTratamiento.Size = new System.Drawing.Size(92, 21);
            this.cbxDatosTratamiento.TabIndex = 9;
            // 
            // cbxMedicamento
            // 
            this.cbxMedicamento.FormattingEnabled = true;
            this.cbxMedicamento.Location = new System.Drawing.Point(107, 25);
            this.cbxMedicamento.Name = "cbxMedicamento";
            this.cbxMedicamento.Size = new System.Drawing.Size(104, 21);
            this.cbxMedicamento.TabIndex = 10;
            // 
            // dgvTratamiento
            // 
            this.dgvTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamiento.Location = new System.Drawing.Point(382, 33);
            this.dgvTratamiento.Name = "dgvTratamiento";
            this.dgvTratamiento.Size = new System.Drawing.Size(330, 163);
            this.dgvTratamiento.TabIndex = 11;
            this.dgvTratamiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTratamiento_CellClick);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(114, 233);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 12;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxTrataEliminadas
            // 
            this.cbxTrataEliminadas.FormattingEnabled = true;
            this.cbxTrataEliminadas.Location = new System.Drawing.Point(429, 237);
            this.cbxTrataEliminadas.Name = "cbxTrataEliminadas";
            this.cbxTrataEliminadas.Size = new System.Drawing.Size(121, 21);
            this.cbxTrataEliminadas.TabIndex = 28;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(556, 235);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 27;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tratamientos eliminados";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(637, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 442);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxTrataEliminadas);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.dgvTratamiento);
            this.Controls.Add(this.cbxMedicamento);
            this.Controls.Add(this.cbxDatosTratamiento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTratamiento";
            this.Text = "Sistema Veterinario: Tratamiento";
            this.Load += new System.EventHandler(this.FrmTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxDatosTratamiento;
        private System.Windows.Forms.ComboBox cbxMedicamento;
        private System.Windows.Forms.DataGridView dgvTratamiento;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxTrataEliminadas;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
    }
}