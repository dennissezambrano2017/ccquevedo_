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
    public partial class Modificar : Form
    {
        private static Modificar instancia = null;
        public static Modificar FormCrear()
        {
            if (instancia == null)
            {
                instancia = new Modificar();
                return instancia;
            }
            return instancia;
        }
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

    }
}
