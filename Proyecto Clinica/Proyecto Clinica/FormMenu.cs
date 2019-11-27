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
    }
}
