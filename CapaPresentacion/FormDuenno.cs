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
    public partial class frmDuenno : Form
    {
        DataSet dsDuenno = new DataSet();
        DataTable dtDuenno = new DataTable();


        public frmDuenno()
        {
            InitializeComponent();
        }

        private void btnInsertarDuenno_Click(object sender, EventArgs e)
        {
            using (GestorDuenno elDuenno = new GestorDuenno())

            {

                elDuenno.InsertarDuenno(int.Parse(txtDuenno_cedula.Text.ToString()), txtDuenno_nombre.Text, txtDuenno_apellido.Text,
                                        txtDuenno_telefono.Text, txtDuenno_direccion.Text, "A");
            }
            CargarGridDuenno();
            CargarComboDuenno();
        

        }

        private void frmDuenno_Load(object sender, EventArgs e)
        {
            CargarGridDuenno();
            CargarComboDuenno();
            CargarComboDuennoInac();
        }
        private void CargarGridDuenno()
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                dgvDuennos.DataSource = elDuenno.ListarDuennos();

                dgvDuennos.Columns["Duenno_id"].Visible = false;
                dgvDuennos.Columns["Duenno_cedula"].HeaderText = "Cédula";
                dgvDuennos.Columns["Duenno_nombre"].HeaderText = "Nombre";
                dgvDuennos.Columns["Duenno_apellido"].HeaderText = "Apellido";
                dgvDuennos.Columns["Duenno_telefono"].HeaderText = "Teléfono";
                dgvDuennos.Columns["Duenno_direccion"].HeaderText = "Dirección";
                dgvDuennos.Columns["Duenno_estado"].Visible = false;
            }
        }
        private void CargarComboDuenno()
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
               
                cbxDuenno.DataSource = elDuenno.ListarDuennos();
                cbxDuenno.ValueMember = "Duenno_id";
                cbxDuenno.DisplayMember = "Duenno_cedula";


            }
        }
        private void CargarComboDuennoInac()
        {
            using (GestorDuenno elDuenno = new GestorDuenno())

            {

                cbxDuennoEliminado.DataSource = elDuenno.ListarDuennosInactivos();
                cbxDuennoEliminado.ValueMember = "Duenno_id";
                cbxDuennoEliminado.DisplayMember = "Duenno_cedula";
            }
        }
        private void BuscarDuenno()
        {
            int Duenno_id = int.Parse(cbxDuenno.SelectedValue.ToString());
            using (GestorDuenno Duenno = new GestorDuenno())
            {
                this.dsDuenno = Duenno.ConsultarDuenno(Duenno_id);
                this.dtDuenno = this.dsDuenno.Tables[0];
            }
            CargarDatosDuenno();
            CargarComboDuennoInac();
        }
        private void CargarDatosDuenno()//segun la informacion de la consulta se va a presentar en partes
        {
            txtDuenno_cedula.Text = this.dtDuenno.Rows[0]["Duenno_cedula"].ToString();
            txtDuenno_nombre.Text = this.dtDuenno.Rows[0]["Duenno_nombre"].ToString();
            txtDuenno_apellido.Text = this.dtDuenno.Rows[0]["Duenno_apellido"].ToString();
            txtDuenno_telefono.Text = this.dtDuenno.Rows[0]["Duenno_telefono"].ToString();
            txtDuenno_direccion.Text = this.dtDuenno.Rows[0]["Duenno_direccion"].ToString();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarDuenno();
        }

        private void btnModificarDuenno_Click(object sender, EventArgs e)
        {

            using (GestorDuenno elDuenno = new GestorDuenno())
            {


                elDuenno.ModificarDuenno(int.Parse(cbxDuenno.SelectedValue.ToString()), int.Parse(txtDuenno_cedula.Text.ToString()), txtDuenno_nombre.Text,
                                         txtDuenno_apellido.Text, txtDuenno_telefono.Text, txtDuenno_direccion.Text, "A");
            }
            CargarGridDuenno();
            CargarComboDuenno();
        } 

        private void dgvDuennos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxDuenno.Text = ("");
                int numFila = dgvDuennos.CurrentCell.RowIndex;
                int Duenno_id = int.Parse(this.dgvDuennos[0, numFila].Value.ToString());


                using (GestorDuenno Duenno = new GestorDuenno())
                {
                    this.dsDuenno = Duenno.ConsultarDuenno(Duenno_id);
                    this.dtDuenno = this.dsDuenno.Tables[0];
                   
                }
                CargarDatosDuenno();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
           
        }


        private void btnInactivar_duenno_Click(object sender, EventArgs e)
        {

            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                elDuenno.InactivarDuenno(int.Parse(cbxDuenno.SelectedValue.ToString()));
                MessageBox.Show("Dueño Inactivado");
            }
            CargarGridDuenno();
            CargarComboDuenno();
            CargarComboDuennoInac();

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del modulo veterinario","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

 
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                elDuenno.ActivarDuenno(int.Parse(cbxDuennoEliminado.SelectedValue.ToString()));
                MessageBox.Show("Dueño recuperado");
            }
            CargarGridDuenno();
            CargarComboDuenno();
            CargarComboDuennoInac();

        }
    }
}
