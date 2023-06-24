namespace CapaPresentacion
{
    partial class FrmMascota
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtFechaN = new System.Windows.Forms.TextBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.cbxDuenno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxCargarDatos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.cbxMascoEliminadas = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de\r\nnacimiento:\r\n";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(91, 54);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(91, 91);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(91, 129);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // txtFechaN
            // 
            this.txtFechaN.Location = new System.Drawing.Point(91, 178);
            this.txtFechaN.Name = "txtFechaN";
            this.txtFechaN.Size = new System.Drawing.Size(100, 20);
            this.txtFechaN.TabIndex = 9;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(298, 17);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(479, 222);
            this.dgvMascotas.TabIndex = 10;
            this.dgvMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellClick);
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(91, 218);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(129, 21);
            this.cbxEspecie.TabIndex = 11;
            this.cbxEspecie.Text = "Selecione una opción";
            // 
            // cbxDuenno
            // 
            this.cbxDuenno.FormattingEnabled = true;
            this.cbxDuenno.Location = new System.Drawing.Point(91, 266);
            this.cbxDuenno.Name = "cbxDuenno";
            this.cbxDuenno.Size = new System.Drawing.Size(129, 21);
            this.cbxDuenno.TabIndex = 12;
            this.cbxDuenno.Text = "Seleccione una opción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Especie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dueño:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(91, 315);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(26, 424);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(156, 377);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 17;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxCargarDatos
            // 
            this.cbxCargarDatos.FormattingEnabled = true;
            this.cbxCargarDatos.Location = new System.Drawing.Point(12, 377);
            this.cbxCargarDatos.Name = "cbxCargarDatos";
            this.cbxCargarDatos.Size = new System.Drawing.Size(121, 21);
            this.cbxCargarDatos.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mascotas eliminadas";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(567, 300);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 21;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // cbxMascoEliminadas
            // 
            this.cbxMascoEliminadas.FormattingEnabled = true;
            this.cbxMascoEliminadas.Location = new System.Drawing.Point(440, 302);
            this.cbxMascoEliminadas.Name = "cbxMascoEliminadas";
            this.cbxMascoEliminadas.Size = new System.Drawing.Size(121, 21);
            this.cbxMascoEliminadas.TabIndex = 22;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(674, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxMascoEliminadas);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxCargarDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDuenno);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.txtFechaN);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMascota";
            this.Text = "Sistema Veterinario: Mascota";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtFechaN;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.ComboBox cbxDuenno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxCargarDatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.ComboBox cbxMascoEliminadas;
        private System.Windows.Forms.Button btnSalir;
    }
}