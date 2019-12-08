using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Herramientas.Tipousuario == "admin")
            {
                pacientesToolStripMenuItem.Enabled = true;
                doctoresToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = true;
                reporteDeCitasToolStripMenuItem.Enabled = true;
                reporteDePasienteToolStripMenuItem.Enabled = true;
            }

            if (Herramientas.Tipousuario == "enfermera")
            {
                pacientesToolStripMenuItem.Enabled = true;
                doctoresToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = true;
                reporteDeCitasToolStripMenuItem.Enabled = false;
                reporteDePasienteToolStripMenuItem.Enabled = false;
                seguridadToolStripMenuItem.Enabled = false;
            }


            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: " + Program.UsuarioLogueado.Nombre;
            }
            else
            {
                Application.Exit();
            }

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPacientes = new FormPacientes();
            
            formPacientes.ShowDialog();
        }
        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDoctores = new FormDoctores();
            
            formDoctores.ShowDialog();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            
            formFactura.ShowDialog();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCitas = new FormCitas();
            
            formCitas.ShowDialog();
        }

        private void reporteDePasienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportePacientes = new FormReportePacientes();
            formReportePacientes.ShowDialog();
        }

        private void reporteDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteCitas = new FormReporteCitas();
            formReporteCitas.ShowDialog();
        }
    }
}
