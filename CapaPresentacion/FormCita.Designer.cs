namespace CapaPresentacion
{
    partial class FrmCita
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbxMascota = new System.Windows.Forms.ComboBox();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCargarDatosCita = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.cbxDatosCita = new System.Windows.Forms.ComboBox();
            this.dgvCita = new System.Windows.Forms.DataGridView();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.cbxCitaEliminada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veterinario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(79, 93);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(121, 20);
            this.txtHora.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(79, 128);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // cbxMascota
            // 
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(79, 25);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(121, 21);
            this.cbxMascota.TabIndex = 9;
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(79, 60);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(121, 21);
            this.cbxVeterinario.TabIndex = 10;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 164);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCargarDatosCita
            // 
            this.btnCargarDatosCita.Location = new System.Drawing.Point(139, 245);
            this.btnCargarDatosCita.Name = "btnCargarDatosCita";
            this.btnCargarDatosCita.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatosCita.TabIndex = 12;
            this.btnCargarDatosCita.Text = "Cargar datos";
            this.btnCargarDatosCita.UseVisualStyleBackColor = true;
            this.btnCargarDatosCita.Click += new System.EventHandler(this.btnCargarDatosCita_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(93, 280);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(12, 280);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 14;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // cbxDatosCita
            // 
            this.cbxDatosCita.FormattingEnabled = true;
            this.cbxDatosCita.Location = new System.Drawing.Point(12, 247);
            this.cbxDatosCita.Name = "cbxDatosCita";
            this.cbxDatosCita.Size = new System.Drawing.Size(121, 21);
            this.cbxDatosCita.TabIndex = 15;
            // 
            // dgvCita
            // 
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCita.Location = new System.Drawing.Point(289, 12);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.Size = new System.Drawing.Size(417, 210);
            this.dgvCita.TabIndex = 16;
            this.dgvCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCita_CellClick);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(522, 261);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 22;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // cbxCitaEliminada
            // 
            this.cbxCitaEliminada.FormattingEnabled = true;
            this.cbxCitaEliminada.Location = new System.Drawing.Point(395, 261);
            this.cbxCitaEliminada.Name = "cbxCitaEliminada";
            this.cbxCitaEliminada.Size = new System.Drawing.Size(121, 21);
            this.cbxCitaEliminada.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Citas eliminadas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(590, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Código cita";
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.cbxCitaEliminada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCita);
            this.Controls.Add(this.cbxDatosCita);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnCargarDatosCita);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbxVeterinario);
            this.Controls.Add(this.cbxMascota);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmCita";
            this.Text = "Sistema Veterinario: Cita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCargarDatosCita;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.ComboBox cbxDatosCita;
        private System.Windows.Forms.DataGridView dgvCita;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.ComboBox cbxCitaEliminada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
    }
}