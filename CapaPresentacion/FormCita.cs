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
    public partial class FrmCita : Form
    {
        DataSet dsCita = new DataSet();
        DataTable dtCita = new DataTable();

        public FrmCita()
        {
           
            InitializeComponent();
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
        private void CargarComboCita()
        {
            using (GestorCita Cita = new GestorCita())
            {
                
                cbxDatosCita.DataSource = Cita.ListarCitas();
                cbxDatosCita.ValueMember = "Cita_id";
                cbxDatosCita.DisplayMember = "Cita_id";
            }
           
        }
        private void CargarComboCitaElimi()
        {
            using (GestorCita Cita = new GestorCita())
            {
                cbxCitaEliminada.DataSource = Cita.ListarCitasInactivas();
                cbxCitaEliminada.ValueMember = "Cita_id";
                cbxCitaEliminada.DisplayMember = "Cita_id";
            }
        }
        private void BuscarCita()
        {
            int Cita_id = int.Parse(cbxDatosCita.SelectedValue.ToString());
            using (GestorCita Cita = new GestorCita())
            {
                this.dsCita = Cita.ConsultarCita(Cita_id);
                this.dtCita = this.dsCita.Tables[0];
            }

            CargarDatosCita();
         
        }
        private void CargarDatosCita()
        {
            cbxMascota.Text = this.dtCita.Rows[0]["Mascota_id"].ToString();
            cbxVeterinario.Text = this.dtCita.Rows[0]["Veterinario_id"].ToString();
            txtHora.Text = this.dtCita.Rows[0]["Cita_hora"].ToString();
            txtFecha.Text = this.dtCita.Rows[0]["Cita_fecha"].ToString();
        }


        private void CargarGridCita()
        {
            using (GestorCita Cita = new GestorCita())
            {
                dgvCita.DataSource = Cita.ListarCitas();
                dgvCita.Columns["Cita_id"].Visible = false;
                dgvCita.Columns["Mascota_nombre"].HeaderText = "Mascota";
                dgvCita.Columns["Veterinario_nombre"].HeaderText = "Veterinario";
                dgvCita.Columns["Cita_hora"].HeaderText = "Hora";
                dgvCita.Columns["Cita_fecha"].HeaderText = "Fecha";
                dgvCita.Columns["Cita_estado"].Visible = false;
            }
        }

        private void FrmCita_Load(object sender, EventArgs e)

        {
           
            CargarGridCita();
            CargarComboCita();
            ComboMascota();
            ComboVeterinario();
            CargarComboCitaElimi();
        }
    
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorCita Cita = new GestorCita())
            {
                Cita.InsertarCita(int.Parse(cbxMascota.SelectedValue.ToString()), int.Parse(cbxVeterinario.SelectedValue.ToString()),
                                   txtHora.Text, txtFecha.Text, "A");
            }
            CargarGridCita();
            CargarComboCita();
        }

        private void btnCargarDatosCita_Click(object sender, EventArgs e)
        {
            BuscarCita();
        }
  

        private void Modificar_Click(object sender, EventArgs e)
        {
            using (GestorCita Cita = new GestorCita())
            {
                Cita.ModificarCita(int.Parse(cbxDatosCita.SelectedValue.ToString()), int.Parse(cbxMascota.SelectedValue.ToString()), int.Parse(cbxVeterinario.SelectedValue.ToString()),
                                   txtHora.Text, txtFecha.Text, "A");
            }
            { 

}
            CargarGridCita();
            CargarComboCita();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            using (GestorCita Cita = new GestorCita())
            {
                Cita.InactivarCita(int.Parse(cbxDatosCita.SelectedValue.ToString()));
                MessageBox.Show("Cita eliminada");
            }
            CargarGridCita();
            CargarDatosCita();
            CargarComboCitaElimi();
        }

        private void dgvCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                cbxDatosCita.Text = ("");
                int numFila = dgvCita.CurrentCell.RowIndex;
                int Cita_id = int.Parse(this.dgvCita[0, numFila].Value.ToString());

                using (GestorCita Cita = new GestorCita())
                {
                    this.dsCita = Cita.ConsultarCita(Cita_id);
                    this.dtCita = this.dsCita.Tables[0];
                }
                CargarDatosCita();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorCita Cita = new GestorCita())
            {
                Cita.ActivarCita(int.Parse(cbxCitaEliminada.SelectedValue.ToString()));
                MessageBox.Show("Cita recuperada");
            }
            CargarGridCita();
            CargarComboCitaElimi();
            CargarComboCita();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio cita", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
    


