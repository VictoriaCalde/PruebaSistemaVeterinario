using SistemaVeterinario.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMascota : Form
    {

        DataSet dsMascota = new DataSet();
        DataTable dtMascota = new DataTable();

      
        public FrmMascota()
        {
            InitializeComponent();

        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorMascota nuevaMascota = new GestorMascota()) { 
            nuevaMascota.InsertarMascota(int.Parse(cbxEspecie.SelectedValue.ToString()),int.Parse(cbxDuenno.SelectedValue.ToString()),
                                              txtNombre.Text, txtGenero.Text, txtColor.Text, txtPeso.Text, txtFechaN.Text, "A");
        }
            CargarGridMascota();
            CargarComboMascota();

        }
    private void ComboEspecie()
    {
            using (GestorEspecie especie = new GestorEspecie())
            {
                cbxEspecie.DataSource = especie.ListarEspecies();
                cbxEspecie.ValueMember = "Especie_id";
                cbxEspecie.DisplayMember = "Especie_descripcion" ;
                
            }
   }

   private void ComboDuenno()
    {
            using (GestorDuenno duenno = new GestorDuenno())
            {
                cbxDuenno.DataSource = duenno.ListarDuennos();
                cbxDuenno.ValueMember = "Duenno_id";
                cbxDuenno.DisplayMember = "Duenno_nombre";
            }
   }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
           CargarGridMascota();
           CargarComboMascota();
           ComboEspecie();
           ComboDuenno();
           CargarComboMascotaInac();
        }

        private void CargarGridMascota()
        {
            using (GestorMascota laMascota = new GestorMascota())
            {
                dgvMascotas.DataSource = laMascota.ListarMascotas();
                dgvMascotas.Columns["Mascota_id"].Visible = false;
                dgvMascotas.Columns["Mascota_nombre"].HeaderText = "Nombre" ;
                dgvMascotas.Columns["Mascota_genero"].HeaderText = "Género";
                dgvMascotas.Columns["Mascota_color"].HeaderText = "Color";
                dgvMascotas.Columns["Mascota_peso"].HeaderText = "Peso";
                dgvMascotas.Columns["Mascota_fechaNacimiento"].HeaderText = "Fecha Nacimiento";
                dgvMascotas.Columns["Mascota_estado"].Visible = false;
                dgvMascotas.Columns["Especie_descripcion"].HeaderText = "Especie";
                dgvMascotas.Columns["Duenno_nombre"].HeaderText = "Nombre Dueño";
            }
        }
        private void CargarComboMascota()
        { 
            using (GestorMascota laMascota = new GestorMascota())
            {
                cbxCargarDatos.DataSource = laMascota.ListarMascotas();
                cbxCargarDatos.ValueMember = "Mascota_id";
                cbxCargarDatos.DisplayMember = "Mascota_nombre";
            }
        }
        private void CargarComboMascotaInac()
        {
            using (GestorMascota laMascota = new GestorMascota())
            {
                cbxMascoEliminadas.DataSource = laMascota.ListarMascotasInactivas();
                cbxMascoEliminadas.ValueMember = "Mascota_id";
                cbxMascoEliminadas.DisplayMember = "Mascota_nombre";
            }
        }
        private void BuscarMascota()
        {
            int Mascota_id = int.Parse(cbxCargarDatos.SelectedValue.ToString());
            using (GestorMascota laMascota = new GestorMascota())
            {
                this.dsMascota = laMascota.ConsultarMascota(Mascota_id);
                this.dtMascota = this.dsMascota.Tables[0];
            }

            CargarDatosMascota();
            CargarComboMascotaInac();

            }
        private void CargarDatosMascota()
        {

            txtNombre.Text = this.dtMascota.Rows[0]["Mascota_nombre"].ToString();
            txtGenero.Text = this.dtMascota.Rows[0]["Mascota_genero"].ToString();
            txtColor.Text = this.dtMascota.Rows[0]["Mascota_color"].ToString();
            txtPeso.Text = this.dtMascota.Rows[0]["Mascota_peso"].ToString();
            txtFechaN.Text = this.dtMascota.Rows[0]["Mascota_fechaNacimiento"].ToString();
            cbxEspecie.Text = this.dtMascota.Rows[0]["Especie_id"].ToString();
            cbxDuenno.Text = this.dtMascota.Rows[0]["Duenno_id"].ToString();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorMascota nuevaMascota = new GestorMascota())
            {
                nuevaMascota.ModificarMascota(int.Parse(cbxCargarDatos.SelectedValue.ToString()),int.Parse(cbxEspecie.SelectedValue.ToString()), int.Parse(cbxDuenno.SelectedValue.ToString()),
                                                  txtNombre.Text, txtGenero.Text, txtColor.Text, txtPeso.Text, txtFechaN.Text, "A");
            }
            CargarGridMascota();
            CargarComboMascota();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarMascota();

        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxCargarDatos.Text = ("");
                int numFila = dgvMascotas.CurrentCell.RowIndex;
                int Mascota_id = int.Parse(this.dgvMascotas[0, numFila].Value.ToString());

                using (GestorMascota Mascota = new GestorMascota())
                {
                    this.dsMascota = Mascota.ConsultarMascota(Mascota_id);
                    this.dtMascota = this.dsMascota.Tables[0];
                }
                CargarDatosMascota();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMascota laMascota = new GestorMascota())
            {
                laMascota.InactivarMascota(int.Parse(cbxCargarDatos.SelectedValue.ToString()));
                MessageBox.Show("Mascota eliminada");
            }
            CargarGridMascota();
            CargarComboMascota();
            CargarComboMascotaInac();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorMascota laMascota = new GestorMascota())
            {
                laMascota.ActivarMascota(int.Parse(cbxMascoEliminadas.SelectedValue.ToString()));
                MessageBox.Show("Mascota recuperada");
            }
            CargarGridMascota();
            CargarComboMascota();
            CargarComboMascotaInac();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio mascota", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }
