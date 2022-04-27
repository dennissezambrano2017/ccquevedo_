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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

        }
        Producto productos = new Producto();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            int num;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                num = dgvProductos.CurrentRow.Index;
                label1.Text = dgvProductos.Rows[num].Cells["Column1"].Value.ToString();
                p.nombre = label1.Text;
                label2.Text = p.nombre;
            }
            else
            {
                label1.Text = "NO";
            }


        }
    }
}
