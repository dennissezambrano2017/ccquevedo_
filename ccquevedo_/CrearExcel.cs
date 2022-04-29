using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class CrearExcel : Form
    {
        
        private Form_hijo formHijo = new Form_hijo();
        Nuevo frmCrear = Nuevo.FormCrear();
        public CrearExcel()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            Pagina_Principal formPrincipal = new Pagina_Principal();
            frmCrear.MdiParent = formPrincipal.MdiParent;
            frmCrear.ShowDialog();
            frmCrear.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = Modificar.FormCrear();
            Pagina_Principal formPrincipal = new Pagina_Principal();
            frmModificar.MdiParent = formPrincipal.MdiParent;
            frmModificar.ShowDialog();
            frmModificar.BringToFront();
        }

        private void CrearExcel_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = frmCrear.listPro;
        }
    }
}
