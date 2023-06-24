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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void dueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuenno duenno = new frmDuenno();
            duenno.Show();

           
        }

        private void veterinarioToolStripMenuVeterinario_Click(object sender, EventArgs e)
        {
            FrmVeterinario veterinario = new FrmVeterinario();
            veterinario.Show();
        }

        private void especieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecie especie = new FrmEspecie();
            especie.Show();

        }

        private void mToolStripMenuIMascota_Click(object sender, EventArgs e)
        {
            FrmMascota mascota = new FrmMascota();
            mascota.Show();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamento medicamento = new FormMedicamento();
            medicamento.Show();

        }

        private void tratamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTratamiento tratamiento = new FrmTratamiento();
            tratamiento.Show();

        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCita cita = new FrmCita();
            cita.Show();


        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpediente expediente = new FrmExpediente();
            expediente.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del Sistema Veterinario", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
} 
