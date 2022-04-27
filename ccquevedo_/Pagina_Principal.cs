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

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormInPanel(object Formhijo) {
            if (this.panelCntro.Controls.Count > 0)
                this.panelCntro.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCntro.Controls.Add(fh);
            this.panelCntro.Tag = fh;
            fh.Show();
        }

        private void btnCrearExcel_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CrearExcel());
        }

        private void panelCntro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
