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
            DataTable tablaUno=this.productosTableAdapter.BuscarDatos(Convert.ToInt32(id));

            txtNombre.Text= tablaUno.Rows[0][1].ToString();
            txtDescripcion.Text = tablaUno.Rows[0][2].ToString();
            txtInventario.Text = tablaUno.Rows[0][3].ToString();
            txtminStock.Text = tablaUno.Rows[0][4].ToString();
            txtPeso.Text = tablaUno.Rows[0][5].ToString();
            txtprecioRebajado.Text = tablaUno.Rows[0][6].ToString();
            txtPrecio.Text = tablaUno.Rows[0][7].ToString();
            txtCategoria.Text = tablaUno.Rows[0][8].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.Editar(txtNombre.Text, txtDescripcion.Text, txtInventario.Text,
                Convert.ToInt32(txtminStock.Text), Convert.ToInt32(txtPeso.Text), 
                Convert.ToInt32(txtprecioRebajado.Text), Convert.ToInt32(txtPrecio.Text),
                txtCategoria.Text,"nada",Convert.ToInt32(id));
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
            this.Close();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
