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
        private static Productos instancia = null;
        public static Productos FormCrear()
        {
            if (instancia == null)
            {
                instancia = new Productos();
                return instancia;
            }
            return instancia;
        }
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
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

        }

        private int? getId(int num)
        {
            try
            {
                return Convert.ToInt32(dgvProductos.Rows[num].Cells["Id"].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int num;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                num = dgvProductos.CurrentRow.Index;
                int? id = getId(num);
                Form form = new Editar(id);
                form.ShowDialog();
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                dgvProductos.Rows[0].Selected = false;
            }
            else
                MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int num;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Esta seguro de eliminar la fila", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    num = dgvProductos.CurrentRow.Index;
                    int? id = getId(num);
                    //Form form = new Editar(id);
                    //form.Show();
                    this.productosTableAdapter.Eliminar(Convert.ToInt32(id));
                    this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                    dgvProductos.Rows[0].Selected = false;
                }
            }
            else
                MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}