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

        public CrearExcel()
        {
            InitializeComponent();
            MessageBox.Show(Convert.ToString(dgvProducto.RowCount) + "," + Convert.ToString(dgvProducto.ColumnCount));

        }
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo frmCrear = Nuevo.FormCrear();
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
       
    }
}
