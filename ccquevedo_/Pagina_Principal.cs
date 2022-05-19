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
        private Form_hijo formHijo = new Form_hijo();

        public Pagina_Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnCrearExcel_Click(object sender, EventArgs e)
        {
            try
            {
                formHijo.AbrirFormInPanel(new CrearExcel(), this.panelCntro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
                                                           
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                formHijo.AbrirFormInPanel(new Productos(), this.panelCntro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
