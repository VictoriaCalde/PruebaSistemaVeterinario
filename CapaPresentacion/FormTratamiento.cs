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
    public partial class FrmTratamiento : Form
    {
        DataSet dsTratamiento = new DataSet();
        DataTable dtTratamiento = new DataTable();
        public FrmTratamiento()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento nuevoTratamiento = new GestorTratamiento())
            {
                nuevoTratamiento.InsertarTratamiento(int.Parse(cbxMedicamento.SelectedValue.ToString()),
                                                  txtDosis.Text, txtObservaciones.Text, "A");
            }
            CargarGridTratamiento();
        }
        private void ComboDatosTratamiento()
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                cbxDatosTratamiento.DataSource = tratamiento.ListarTratamientos();
                cbxDatosTratamiento.ValueMember = "Tratamiento_id";
                cbxDatosTratamiento.DisplayMember = "Medicamento_nombre";

            }
        }
        private void ComboDatosTratamientoInac()
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                cbxTrataEliminadas.DataSource = tratamiento.ListarTratamientosInactivos();
                cbxTrataEliminadas.ValueMember = "Tratamiento_id";
                cbxTrataEliminadas.DisplayMember = "Medicamento_nombre";

            }
        }


        private void ComboMedicamento()
        {
            using (GestorMedicamento Medicamento = new GestorMedicamento())
            {
                cbxMedicamento.DataSource = Medicamento.ListarMedicamentos();
                cbxMedicamento.ValueMember = "Medicamento_id";
                cbxMedicamento.DisplayMember = "Medicamento_nombre";
            }
        }

        private void FrmTratamiento_Load(object sender, EventArgs e)
        {
            CargarGridTratamiento();
            ComboDatosTratamiento();
            ComboMedicamento();
            ComboDatosTratamientoInac();

        }
        private void CargarGridTratamiento()
        {
            using (GestorTratamiento Tratamiento = new GestorTratamiento())
                

            {
                dgvTratamiento.DataSource = Tratamiento.ListarTratamientos();
                dgvTratamiento.Columns["Tratamiento_id"].Visible = false;
                dgvTratamiento.Columns["Medicamento_nombre"].HeaderText = "Medicamento";
                dgvTratamiento.Columns["Tratamiento_dosis"].HeaderText = "Dosis";
                dgvTratamiento.Columns["Tratamiento_observaciones"].HeaderText = "Observaciones";
                dgvTratamiento.Columns["Tratamiento_estado"].Visible = false; ;

            }
        }
        private void CargarDatosTratamiento()

        {
            cbxMedicamento.Text = this.dtTratamiento.Rows[0]["Medicamento_id"].ToString();
            txtDosis.Text = this.dtTratamiento.Rows[0]["Tratamiento_dosis"].ToString();
            txtObservaciones.Text = this.dtTratamiento.Rows[0]["Tratamiento_observaciones"].ToString();

        }
        private void dgvTratamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxDatosTratamiento.Text = ("");
                int numFila = dgvTratamiento.CurrentCell.RowIndex;
                int Tratamiento_id = int.Parse(this.dgvTratamiento[0, numFila].Value.ToString());

                using (GestorTratamiento elTratamiento = new GestorTratamiento())
                {

                    this.dsTratamiento = elTratamiento.ConsultarTratamiento(Tratamiento_id);
                    this.dtTratamiento = this.dsTratamiento.Tables[0];
                }
                CargarDatosTratamiento();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento nuevaMascota = new GestorTratamiento())
            {
                nuevaMascota.ModificarTratamiento(int.Parse(cbxDatosTratamiento.SelectedValue.ToString()), int.Parse(cbxMedicamento.SelectedValue.ToString()),
                                                    txtDosis.Text, txtObservaciones.Text, "A");
            }
            CargarGridTratamiento();
            CargarDatosTratamiento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento nuevoTratamiento = new GestorTratamiento())
            {
                nuevoTratamiento.InactivarTratamiento(int.Parse(cbxDatosTratamiento.SelectedValue.ToString()));
                MessageBox.Show("Tratamiento eliminado");
            }
            ComboDatosTratamientoInac();
            CargarGridTratamiento();
            ComboDatosTratamiento();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarTratamiento();
        }
        private void BuscarTratamiento()
        {
            int Tratamiento_id = int.Parse(cbxDatosTratamiento.SelectedValue.ToString());
            using (GestorTratamiento nuevoTratamiento = new GestorTratamiento())
            {
                this.dsTratamiento = nuevoTratamiento.ConsultarTratamiento(Tratamiento_id);
                this.dtTratamiento = this.dsTratamiento.Tables[0];
            }
            CargarGridTratamiento();
            CargarDatosTratamiento();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento nuevoTratamiento = new GestorTratamiento())
            {
                nuevoTratamiento.ActivarTratamiento(int.Parse(cbxTrataEliminadas.SelectedValue.ToString()));
                MessageBox.Show("Tratamiento recuperado");
            }
            ComboDatosTratamientoInac();
            CargarGridTratamiento();
            ComboDatosTratamiento();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio tratamiento", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
