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
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        DataSet dsUsuario = new DataSet();
        DataTable dtUsuario = new DataTable();
        DataTableReader drUsuario;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorUsuario Usuario = new GestorUsuario())
            {
                Usuario.InsertarUsuario(txtUsuario.Text, txtContrasennaUsuario.Text, cbxTipoUsuario.Text, "A");
            }
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario_tipo" && txtUsuario.Text.Length > 2)
            {
                if (txtContrasennaUsuario.Text != "Usuario_contrasenna")
                {
                    GestorUsuario usuario = new GestorUsuario();
                    var validar = usuario.login(txtUsuario.Text, txtContrasennaUsuario.Text);
                    if (validar == true)
                    {
                        MessageBox.Show("Bienvenido");
                        frmMenu menu = new frmMenu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contrasena o usuario incorrecto");
                    }
                }
            }
        }
    }
}