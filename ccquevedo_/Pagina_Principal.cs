using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class Pagina_Principal : Form
    {
        public Pagina_Principal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new Nuevo();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
