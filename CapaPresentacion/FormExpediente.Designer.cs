namespace CapaPresentacion
{
    partial class FrmExpediente
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
            this.cbxMascota = new System.Windows.Forms.ComboBox();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.cbxTratamiento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbxDatosExpediente = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.dgvExpediente = new System.Windows.Forms.DataGridView();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.cbxExpeEliminado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veterinario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tratamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // cbxMascota
            // 
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(91, 11);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(121, 21);
            this.cbxMascota.TabIndex = 4;
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(91, 57);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(121, 21);
            this.cbxVeterinario.TabIndex = 5;
            // 
            // cbxTratamiento
            // 
            this.cbxTratamiento.FormattingEnabled = true;
            this.cbxTratamiento.Location = new System.Drawing.Point(91, 105);
            this.cbxTratamiento.Name = "cbxTratamiento";
            this.cbxTratamiento.Size = new System.Drawing.Size(121, 21);
            this.cbxTratamiento.TabIndex = 6;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(91, 146);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // cbxDatosExpediente
            // 
            this.cbxDatosExpediente.FormattingEnabled = true;
            this.cbxDatosExpediente.Location = new System.Drawing.Point(27, 277);
            this.cbxDatosExpediente.Name = "cbxDatosExpediente";
            this.cbxDatosExpediente.Size = new System.Drawing.Size(121, 21);
            this.cbxDatosExpediente.TabIndex = 8;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(27, 210);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(27, 323);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(137, 323);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(154, 277);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 12;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // dgvExpediente
            // 
            this.dgvExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpediente.Location = new System.Drawing.Point(350, 6);
            this.dgvExpediente.Name = "dgvExpediente";
            this.dgvExpediente.Size = new System.Drawing.Size(384, 160);
            this.dgvExpediente.TabIndex = 13;
            this.dgvExpediente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpediente_CellClick);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(542, 227);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 26;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // cbxExpeEliminado
            // 
            this.cbxExpeEliminado.FormattingEnabled = true;
            this.cbxExpeEliminado.Location = new System.Drawing.Point(415, 229);
            this.cbxExpeEliminado.Name = "cbxExpeEliminado";
            this.cbxExpeEliminado.Size = new System.Drawing.Size(121, 21);
            this.cbxExpeEliminado.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Expedientes eliminados";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(613, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Código expediente";
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 429);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.cbxExpeEliminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvExpediente);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbxDatosExpediente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cbxTratamiento);
            this.Controls.Add(this.cbxVeterinario);
            this.Controls.Add(this.cbxMascota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExpediente";
            this.Text = "Sistema Veterinario: Expediente";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.ComboBox cbxTratamiento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbxDatosExpediente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.DataGridView dgvExpediente;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.ComboBox cbxExpeEliminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
    }
}