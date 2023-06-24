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
    public partial class FrmExpediente : Form
    {
        DataSet dsExpediente = new DataSet();
        DataTable dtExpediente = new DataTable();
        public FrmExpediente()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                Expediente.InsertarExpediente(int.Parse(cbxMascota.SelectedValue.ToString()), int.Parse(cbxVeterinario.SelectedValue.ToString()),
                    int.Parse(cbxTratamiento.SelectedValue.ToString()), txtFecha.Text, "A");
            }
            CargarGridExpediente();
            ComboExpediente();
            }
        private void ComboMascota()
        {
            using (GestorMascota mascota = new GestorMascota())
            {
                cbxMascota.DataSource = mascota.ListarMascotas();
                cbxMascota.ValueMember = "Mascota_id";
                cbxMascota.DisplayMember = "Mascota_nombre";
            }
        }
        private void ComboVeterinario()
        {
            using (GestorVeterinario Veterinario = new GestorVeterinario())
            {
                cbxVeterinario.DataSource = Veterinario.ListarVeterinarios();
                cbxVeterinario.ValueMember = "Veterinario_id";
                cbxVeterinario.DisplayMember = "Veterinario_nombre";
            }
        }
        private void ComboTratamiento()
        {
            using (GestorTratamiento Tratamiento = new GestorTratamiento())
            {
                cbxTratamiento.DataSource = Tratamiento.ListarTratamientos();
                cbxTratamiento.ValueMember = "Tratamiento_id";
                cbxTratamiento.DisplayMember = "Tratamiento_observaciones";
            }
        }
        private void ComboExpediente()
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                cbxDatosExpediente.DataSource = Expediente.ListarExpedientes();
                cbxDatosExpediente.ValueMember = "Expediente_id";
                cbxDatosExpediente.DisplayMember = "Expediente_id";
            }
        }
        private void ComboExpedienteInac()
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                cbxExpeEliminado.DataSource = Expediente.ListarExpedientesInactivos();
                cbxExpeEliminado.ValueMember = "Expediente_id";
                cbxExpeEliminado.DisplayMember = "Expediente_id";
            }
        }
        private void CargarGridExpediente()
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                dgvExpediente.DataSource = Expediente.ListarExpedientes();
                dgvExpediente.Columns["Expediente_id"].Visible = false;
                dgvExpediente.Columns["Mascota_nombre"].HeaderText = "Mascota";
                dgvExpediente.Columns["Veterinario_nombre"].HeaderText = "Veterinario";
                dgvExpediente.Columns["Tratamiento_observaciones"].HeaderText = "Tratamiento";
                dgvExpediente.Columns["Expediente_fecha"].HeaderText = "Fecha";
                dgvExpediente.Columns["Expediente_estado"].Visible = false;
            }
        }
       private void BuscarExpediente()
        {
            int Expediente_id = int.Parse(cbxDatosExpediente.SelectedValue.ToString());
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                this.dsExpediente = Expediente.ConsultarExpediente(Expediente_id);
                this.dtExpediente = this.dsExpediente.Tables[0];
            }
            CargarDatosExpediente();
        }
        private void CargarDatosExpediente()
        {
            cbxMascota.Text = this.dtExpediente.Rows[0]["Mascota_id"].ToString();
            cbxVeterinario.Text = this.dtExpediente.Rows[0]["Veterinario_id"].ToString();
            cbxTratamiento.Text = this.dtExpediente.Rows[0]["Tratamiento_id"].ToString();
            txtFecha.Text = this.dtExpediente.Rows[0]["Expediente_fecha"].ToString();
        }

        private void dgvExpediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxDatosExpediente.Text = ("");
                int numFila = dgvExpediente.CurrentCell.RowIndex;
                int Expediente_id = int.Parse(this.dgvExpediente[0, numFila].Value.ToString());

                using (GestorExpediente Expediente = new GestorExpediente())
                {
                    this.dsExpediente = Expediente.ConsultarExpediente(Expediente_id);
                    this.dtExpediente = this.dsExpediente.Tables[0];
                }
                CargarDatosExpediente();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
          
            CargarGridExpediente();
            ComboMascota();
            ComboVeterinario();
            ComboTratamiento();
            ComboExpediente();
            ComboExpedienteInac();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                Expediente.ModificarExpediente(int.Parse(cbxDatosExpediente.SelectedValue.ToString()),int.Parse(cbxMascota.SelectedValue.ToString()), int.Parse(cbxVeterinario.SelectedValue.ToString()),
                    int.Parse(cbxTratamiento.SelectedValue.ToString()), txtFecha.Text, "A");
            }
            CargarGridExpediente();
            ComboExpediente();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarExpediente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                Expediente.InactivarExpediente(int.Parse(cbxDatosExpediente.SelectedValue.ToString()));
                MessageBox.Show("Expediente eliminado");
            }
            CargarGridExpediente();
            ComboExpediente();
            ComboExpedienteInac();
            
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorExpediente Expediente = new GestorExpediente())
            {
                Expediente.ActivarExpediente(int.Parse(cbxExpeEliminado.SelectedValue.ToString()));
                MessageBox.Show("Expediente recuperado");
            }
            CargarGridExpediente();
            ComboExpediente();
            ComboExpedienteInac();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio expediente", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
