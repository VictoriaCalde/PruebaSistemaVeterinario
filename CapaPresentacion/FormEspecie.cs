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
	public partial class FrmEspecie : Form
	{
		DataSet dsEspecie = new DataSet();
		DataTable dtEspecie = new DataTable();
		public FrmEspecie()
		{
			InitializeComponent();
		}

		private void btnInsertarDescripcion_especie_Click(object sender, EventArgs e)
		{
			using (GestorEspecie laEspecie = new GestorEspecie())
			{

				laEspecie.InsertarEspecie(txtEspecie_descripcion.Text, "A");
			}
			CargarGridEspecie();
			CargarComboEspecie();
		}
		private void FrmEspecie_Load(object sender, EventArgs e)
		{
			CargarGridEspecie();
			CargarComboEspecie();
			CargarComboEspecieEli();
		}

		private void CargarGridEspecie()
		{
			using (GestorEspecie laEspecie = new GestorEspecie())
			{
				dgvEspecies.DataSource = laEspecie.ListarEspecies();
				dgvEspecies.Columns["Especie_id"].Visible = false;
				dgvEspecies.Columns["Especie_descripcion"].HeaderText = "Descripción";
				dgvEspecies.Columns["Especie_estado"].Visible = false;
			}
		}
		private void CargarComboEspecie()
		{
			using(GestorEspecie laEspecie = new GestorEspecie())
			{
				cbxDatosEspecie.DataSource = laEspecie.ListarEspecies();
				cbxDatosEspecie.ValueMember = "Especie_id";
				cbxDatosEspecie.DisplayMember = "Especie_descripcion";

			}
		}
		private void CargarComboEspecieEli()
		{
			using (GestorEspecie laEspecie = new GestorEspecie())
			{
				cbxEspeEliminado.DataSource = laEspecie.ListarEspeciesInactivas();
				cbxEspeEliminado.ValueMember = "Especie_id";
				cbxEspeEliminado.DisplayMember = "Especie_descripcion";

			}
		}
		private void BuscarEspecie()
		{
			int Especie_id = int.Parse(cbxDatosEspecie.SelectedValue.ToString());
			using (GestorEspecie Especie = new GestorEspecie())
			{
				this.dsEspecie = Especie.ConsultarEspecie(Especie_id);
				this.dtEspecie = this.dsEspecie.Tables[0];
			}
			CargarDatosEspecie();

		}
		private void CargarDatosEspecie()//segun la informacion de la consulta se va a presentar en partes
		{

			txtEspecie_descripcion.Text = this.dtEspecie.Rows[0]["Especie_descripcion"].ToString();
		}
		private void btnCargar_datos_Click(object sender, EventArgs e)
		{
			BuscarEspecie();
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			using (GestorEspecie laEspecie = new GestorEspecie())
			{
				laEspecie.ModificarEspecie(int.Parse(cbxDatosEspecie.SelectedValue.ToString()),txtEspecie_descripcion.Text, "A");
			}
			CargarGridEspecie();
			CargarDatosEspecie();
			}

		private void dgvEspecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			try
			{
				cbxDatosEspecie.Text = ("");
				int numFila = dgvEspecies.CurrentCell.RowIndex;
				int Especie_id = int.Parse(this.dgvEspecies[0, numFila].Value.ToString());

				using (GestorEspecie Especie = new GestorEspecie())
				{
					this.dsEspecie = Especie.ConsultarEspecie(Especie_id);
					this.dtEspecie = this.dsEspecie.Tables[0];
				}
				CargarDatosEspecie();
				
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
								MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			using (GestorEspecie laEspecie = new GestorEspecie())
			{
				laEspecie.InactivarEspecie(int.Parse(cbxDatosEspecie.SelectedValue.ToString()));
				   MessageBox.Show("Especie eliminada");
			}
			CargarGridEspecie();
			CargarComboEspecie();
			CargarComboEspecieEli();
		}

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
			using (GestorEspecie laEspecie = new GestorEspecie())
			{
				laEspecie.ActivarEspecie(int.Parse(cbxEspeEliminado.SelectedValue.ToString()));
				MessageBox.Show("Especie recuperada");
			}
			CargarGridEspecie();
			CargarComboEspecie();
			CargarComboEspecieEli();
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
			DialogResult opcion;
			opcion = MessageBox.Show("Desea salir del servicio especie", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (opcion == DialogResult.Yes)
			{
				Close();
			}
		}
    }
}