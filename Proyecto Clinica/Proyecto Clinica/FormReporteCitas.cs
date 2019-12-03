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
    public partial class FormReporteCitas : Form
    {
        public FormReporteCitas()
        {
            InitializeComponent();

            var _citasBL = new CitasBL();
            var _doctorBL = new DoctoresBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _citasBL.ObtenerCitas();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _doctorBL.ObtenerDoctores();

            var listaBinding = new List<BindingSource>();
            listaBinding.Add(bindingSource);
            listaBinding.Add(bindingSource2);

            var reporte = new ReporteCitas();
            reporte.SetDataSource(listaBinding);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
