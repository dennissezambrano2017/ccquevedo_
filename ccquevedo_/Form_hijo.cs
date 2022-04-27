using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccquevedo_
{
    internal class Form_hijo
    {
        public Form_hijo() { }

        public void AbrirFormInPanel(object Formhijo, Panel panelCntro)
        {
            if (panelCntro.Controls.Count > 0)
                panelCntro.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelCntro.Controls.Add(fh);
            panelCntro.Tag = fh;
            fh.Show();
        }
    }
}
