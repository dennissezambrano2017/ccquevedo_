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
        public CrearExcel()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pagina_Principal pp = new Pagina_Principal();
            formHijo.AbrirFormInPanel(new Nuevo(),pp.panelCntro); 
            //Form form = new Nuevo();
            //form.Show();
        }

    }
}
