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
    public partial class FormMedicamento : Form
    {
        DataSet dsMedicamento = new DataSet();
        DataTable dtMedicamento = new DataTable();
        public FormMedicamento()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {

                elMedicamento.InsertarMedicamento(txtNombre.Text, txtDosis.Text, "A");
            }
            CargarGridMedicamento();
            ComboMedicamento();
        }
        private void CargarGridMedicamento()
        {
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {
                dgvMedicamento.DataSource = elMedicamento.ListarMedicamentos();
                dgvMedicamento.Columns["Medicamento_id"].Visible = false;
                dgvMedicamento.Columns["Medicamento_nombre"].HeaderText = "Nombre";
                dgvMedicamento.Columns["Medicamento_dosis"].HeaderText = "Dosis";
                dgvMedicamento.Columns["Medicamento_estado"].Visible = false;
            }
        }
        private void ComboMedicamento()
        {
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {
                cbxMedicamento.DataSource = elMedicamento.ListarMedicamentos();
                cbxMedicamento.ValueMember = "Medicamento_id";
                cbxMedicamento.DisplayMember = "Medicamento_nombre";
            }
            }
        private void ComboMedicamentoInac()
        {
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {
                cbxMediEliminados.DataSource = elMedicamento.ListarMedicamentosInactivos();
                cbxMediEliminados.ValueMember = "Medicamento_id";
                cbxMediEliminados.DisplayMember = "Medicamento_nombre";
            }
        }
        private void BuscarMedicamento()
        {
            int Medicamento_id = int.Parse(cbxMedicamento.SelectedValue.ToString());
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {
                this.dsMedicamento = elMedicamento.ConsultarMedicamento(Medicamento_id);
                this.dtMedicamento = this.dsMedicamento.Tables[0];  
            }
            CargarDatosMedicamento();
        }
        private void CargarDatosMedicamento()
        {
            txtNombre.Text = this.dtMedicamento.Rows[0]["Medicamento_nombre"].ToString();
            txtDosis.Text = this.dtMedicamento.Rows[0]["Medicamento_dosis"].ToString();

        }
        private void FormMedicamento_Load(object sender, EventArgs e)
        {
            CargarGridMedicamento();
            ComboMedicamento();
            ComboMedicamentoInac();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorMedicamento elMedicamento = new GestorMedicamento())

            {

                elMedicamento.ModificarMedicamento(int.Parse(cbxMedicamento.SelectedValue.ToString()),txtNombre.Text, txtDosis.Text, "A");
            }
            CargarGridMedicamento();
            CargarDatosMedicamento();

        }

        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                cbxMedicamento.Text = ("");
                int numFila = dgvMedicamento.CurrentCell.RowIndex;
                int Medicamento_id = int.Parse(this.dgvMedicamento[0, numFila].Value.ToString());

                using (GestorMedicamento Medicamento = new GestorMedicamento())
                {
                    this.dsMedicamento = Medicamento.ConsultarMedicamento(Medicamento_id);
                    this.dtMedicamento = this.dsMedicamento.Tables[0];
                }
                CargarDatosMedicamento();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarMedicamento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMedicamento Medicamento = new GestorMedicamento())
            {

                Medicamento.InactivarMedicamento(int.Parse(cbxMedicamento.SelectedValue.ToString()));
                MessageBox.Show("Medicamento eliminado");
            }
            CargarGridMedicamento();
            ComboMedicamento();
            ComboMedicamentoInac();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorMedicamento Medicamento = new GestorMedicamento())
            {

                Medicamento.ActivarMedicamento(int.Parse(cbxMediEliminados.SelectedValue.ToString()));
                MessageBox.Show("Medicamento recuperado");
            }
            CargarGridMedicamento();
            ComboMedicamento();
            ComboMedicamentoInac();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio medicamento", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }


