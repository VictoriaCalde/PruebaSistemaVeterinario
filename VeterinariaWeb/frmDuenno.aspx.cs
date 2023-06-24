using SistemaVeterinario.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace VeterinariaWeb
{
    public partial class frmDuenno : System.Web.UI.Page
    {
        DataSet dsDuenno ;
        DataTable dtDuenno;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboDuenno();
            CargarGridDuenno();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorDuenno elDuenno = new GestorDuenno())

            {

                elDuenno.InsertarDuenno(int.Parse(txtDuenno_cedula.Text.ToString()), txtDuenno_nombre.Text, txtDuenno_apellido.Text,
                                        txtDuenno_telefono.Text, txtDuenno_direccion.Text, "A");
            }


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {


                elDuenno.ModificarDuenno(int.Parse(ddlDuenno.SelectedValue.ToString()), int.Parse(txtDuenno_cedula.Text.ToString()), txtDuenno_nombre.Text,
                                         txtDuenno_apellido.Text, txtDuenno_telefono.Text, txtDuenno_direccion.Text, "A");
            }
            CargarComboDuenno();
            CargarGridDuenno();
        }
        private void CargarComboDuenno()
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                if (!IsPostBack)
                {
                    ddlDuenno.DataSource = elDuenno.ListarDuennos();
                    ddlDuenno.DataValueField = "Duenno_id";
                    ddlDuenno.DataTextField = "Duenno_cedula";

                    ddlDuenno.DataBind();
                    ddlDuenno.SelectedIndex = 0;
                }
            }
        }
        private void CargarGridDuenno()
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                if (!IsPostBack)
                {
                    gvDuenno.DataSource = elDuenno.ListarDuennos();
                    gvDuenno.DataBind();
                }
            }
            }

        protected void btnCargarDatosDuenno_Click(object sender, EventArgs e)
        {
            int duenno_id = int.Parse(ddlDuenno.SelectedValue.ToString());
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
              
                    this.dsDuenno = elDuenno.ConsultarDuenno(duenno_id);
                    this.dtDuenno = this.dsDuenno.Tables[0];
                
            }
            CargarDatosDuenno();

        }
        private void CargarDatosDuenno()//segun la informacion de la consulta se va a presentar en partes
        {
            txtDuenno_cedula.Text = this.dtDuenno.Rows[0]["Duenno_cedula"].ToString();
            txtDuenno_nombre.Text = this.dtDuenno.Rows[0]["Duenno_nombre"].ToString();
            txtDuenno_apellido.Text = this.dtDuenno.Rows[0]["Duenno_apellido"].ToString();
            txtDuenno_telefono.Text = this.dtDuenno.Rows[0]["Duenno_telefono"].ToString();
            txtDuenno_direccion.Text = this.dtDuenno.Rows[0]["Duenno_direccion"].ToString();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorDuenno elDuenno = new GestorDuenno())
            {
                elDuenno.InactivarDuenno(int.Parse(ddlDuenno.SelectedValue.ToString()));
                
            }
            CargarGridDuenno();
            CargarComboDuenno();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmPrincipal.aspx");
        }
    }
}