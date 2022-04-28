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
    public partial class Editar : Form
    {
        public int? id;
        public Editar(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = id.ToString();
        }
        public void CargarDatos()
        {
            //using (bdCamaraComercioDataSet bd = new bdCamaraComercioDataSet())
            //{
            //     oP = new Productos();
            //    oP.Nombre = txtNombre.Text;
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
