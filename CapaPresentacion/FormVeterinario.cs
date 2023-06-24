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
    public partial class FrmVeterinario : Form

    {
        DataSet dsVeterinario = new DataSet();
        DataTable dtVeterinario = new DataTable();
        public FrmVeterinario()
        {
            InitializeComponent();
        }

        //INSERTAR
        private void btnInsertar_Veterinario_Click(object sender, EventArgs e)
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())

            {

                elVeterinario.InsertarVeterinario(int.Parse(txtVeterinario_cedula.Text.ToString()), txtVeterinario_nombre.Text, txtVeterinario_telefono.Text,
                                                    txtVeterinario_direccion.Text, "A");
            }
            CargarGridVeterinario();
            CargarComboVeterinario();
        }

        //GRID
        private void CargarGridVeterinario()
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {
                dgvVeterinarios.DataSource = elVeterinario.ListarVeterinarios();

                dgvVeterinarios.Columns["Veterinario_id"].Visible = false;
                dgvVeterinarios.Columns["Veterinario_cedula"].HeaderText = "Cédula";
                dgvVeterinarios.Columns["Veterinario_nombre"].HeaderText = "Nombre";
                dgvVeterinarios.Columns["Veterinario_telefono"].HeaderText = "Teléfono";
                dgvVeterinarios.Columns["Veterinario_direccion"].HeaderText = "Dirección";
                dgvVeterinarios.Columns["Veterinario_estado"].Visible = false;
            }
        }
        //COMBO BOX
        private void CargarComboVeterinario()
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {
                cbxVeterinario.DataSource = elVeterinario.ListarVeterinarios();
                cbxVeterinario.ValueMember = "Veterinario_id";
                cbxVeterinario.DisplayMember = "Veterinario_cedula";
            }
        }
        private void CargarComboVeterinarioInactivo()
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {
                cbxVeteEliminado.DataSource = elVeterinario.ListarVeterinariosInactivos();
                cbxVeteEliminado.ValueMember = "Veterinario_id";
                cbxVeteEliminado.DisplayMember = "Veterinario_cedula";
            }
        }

        //BUSCAR
        private void BuscarVeterinario()
        {
            int Veterinario_id = int.Parse(cbxVeterinario.SelectedValue.ToString());
            using (GestorVeterinario Veterinario = new GestorVeterinario())
            {
                this.dsVeterinario = Veterinario.ConsultarVeterinario(Veterinario_id);
                this.dtVeterinario = this.dsVeterinario.Tables[0];
            }
            CargarDatosVeterinario();
        }
        private void CargarDatosVeterinario()//segun la informacion de la consulta se va a presentar en partes
        {
            txtVeterinario_cedula.Text = this.dtVeterinario.Rows[0]["Veterinario_cedula"].ToString();
            txtVeterinario_nombre.Text = this.dtVeterinario.Rows[0]["Veterinario_nombre"].ToString();
            txtVeterinario_telefono.Text = this.dtVeterinario.Rows[0]["Veterinario_telefono"].ToString();
            txtVeterinario_direccion.Text = this.dtVeterinario.Rows[0]["Veterinario_direccion"].ToString();
        }
        private void btnCargarDatosInactivos_veterinario_Click(object sender, EventArgs e)
        {
            BuscarVeterinario();
        }
        //MODIFICAR
        //MODIFICAR
        private void btnModificar_Veterinario_Click(object sender, EventArgs e)
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {


                elVeterinario.ModificarVeterinario(int.Parse(cbxVeterinario.SelectedValue.ToString()), int.Parse(txtVeterinario_cedula.Text.ToString()), txtVeterinario_nombre.Text,
                                        txtVeterinario_telefono.Text, txtVeterinario_direccion.Text, "A");
            }
            CargarGridVeterinario();
            CargarComboVeterinario();

        }



        //FORM
        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            CargarGridVeterinario();
            CargarComboVeterinario();
            CargarComboVeterinarioInactivo();

        }


        //ACTIVAR
     

        //ELIMINAR
        private void btnInactivar_Click(object sender, EventArgs e)
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {
                elVeterinario.InactivarVeterinario(int.Parse(cbxVeterinario.SelectedValue.ToString()));
                MessageBox.Show("Veterinario eliminado");
            }
            CargarGridVeterinario();
            CargarComboVeterinario();
            CargarComboVeterinarioInactivo();

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorVeterinario elVeterinario = new GestorVeterinario())
            {
                elVeterinario.ActivarVeterinario(int.Parse(cbxVeteEliminado.SelectedValue.ToString()));
                MessageBox.Show("Veterinario recuperado");
            }
            CargarGridVeterinario();
            CargarComboVeterinarioInactivo();

        }

        private void dgvVeterinarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxVeterinario.Text = ("");
                int numFila = dgvVeterinarios.CurrentCell.RowIndex;
                int Tratamiento_id = int.Parse(this.dgvVeterinarios[0, numFila].Value.ToString());

                using (GestorVeterinario elVeterinario = new GestorVeterinario())
                {

                    this.dsVeterinario = elVeterinario.ConsultarVeterinario(Tratamiento_id);
                    this.dtVeterinario = this.dsVeterinario.Tables[0];
                }
                CargarDatosVeterinario();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del servicio veterinario", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
