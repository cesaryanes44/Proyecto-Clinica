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
    public partial class FormCitas : Form
    {
        CitasBL _citas;
        PacientesBL _pacientes;
        DoctoresBL _doctores;

        public FormCitas()
        {
            InitializeComponent();

            _pacientes = new PacientesBL();
            pacienteBindingSource.DataSource = _pacientes.ObtenerPaciente();

            _doctores = new DoctoresBL();
            listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();

            _citas = new CitasBL();
            listaCitaBindingSource.DataSource = _citas.ObtenerCita();

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }


        private void Eliminar(int id)
        {
            var resultado = _citas.EliminarCita(id);

            if (resultado == true)
            {
                listaCitaBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar al paciente");
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _citas.AgregarCita();
            listaCitaBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void listaCitaBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            listaCitaBindingSource.EndEdit();
            var cita = (Cita)listaCitaBindingSource.Current;

            var resultado = _citas.GuardarCitas(cita);

            if (resultado.Exitoso == true)
            {
                listaCitaBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cita Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _citas.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
