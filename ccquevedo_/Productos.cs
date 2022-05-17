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
            try
            {
                this.Validate();
                this.productosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Cat_Sub' Puede moverla o quitarla según sea necesario.
            this.cat_SubTableAdapter.Fill(this.bdCamaraComercioDataSet.Cat_Sub);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
                this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private string getId(int num)
        {
            try
            {
                return Convert.ToString(dgvProductos.Rows[num].Cells["Id"].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    num = dgvProductos.CurrentRow.Index;
                    string id = getId(num);
                    Form form = new Editar(id);
                    form.ShowDialog();
                    this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                    dgvProductos.Rows[0].Selected = false;
                }
                else
                    MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Esta seguro de eliminar la fila", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        num = dgvProductos.CurrentRow.Index;
                        string id = getId(num);
                        //Form form = new Editar(id);
                        //form.Show();
                        this.cat_SubTableAdapter.Eliminar(id.ToString());
                        this.productosTableAdapter.Eliminar(id.ToString());
                        this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                        dgvProductos.Rows[0].Selected = false;
                    }
                }
                else
                    MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows != null && dgvProductos.Rows.Count != 0)
                {
                    DataGridView dgvAxu = new DataGridView();
                    dgvAxu.Columns.Add("ID", "Codigo");
                    dgvAxu.Columns.Add("Tipo", "Tipo Producto");
                    dgvAxu.Columns.Add("Nombre", "Nombre");
                    dgvAxu.Columns.Add("Descripción corta", "Descripción Corta");
                    dgvAxu.Columns.Add("Descripción", "Descripción Larga");
                    dgvAxu.Columns.Add("Día en que empieza el precio rebajado", "Fecha Inicio");
                    dgvAxu.Columns.Add("Día en que termina el precio rebajado", "Fecha Fin");
                    dgvAxu.Columns.Add("Inventario", "Stock");
                    dgvAxu.Columns.Add("Cantidad de bajo inventario", "Min Stock");
                    dgvAxu.Columns.Add("Precio rebajado", "Precio Oferta");
                    dgvAxu.Columns.Add("Precio normal", "Precio Normal");
                    dgvAxu.Columns.Add("Categorías", "Categoria");
                    dgvAxu.Columns.Add("Etiquetas", "Etiquetas");
                    dgvAxu.Columns.Add("Imágenes", "Imagen");

                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        //int idcate = (int)dgvProductos.Rows[row.Index].Cells[11].Value;
                        
                        DataTable tabla = this.cat_SubTableAdapter.DesCatSub(row.Cells[0].Value.ToString());
                        string subcatdes = "";
                        for(int l = 0; l < tabla.Rows.Count; l++)
                        {
                            //MessageBox.Show(tabla.Rows[l]["des"].ToString());
                            subcatdes += tabla.Rows[l]["des"].ToString()+", ";

                        }
                        MessageBox.Show(subcatdes);
                        dgvAxu.Rows.Add();
                        dgvAxu.Rows[row.Index].Cells["ID"].Value = row.Cells[0].Value;
                        dgvAxu.Rows[row.Index].Cells["Tipo"].Value = row.Cells[1].Value;
                        dgvAxu.Rows[row.Index].Cells["Nombre"].Value = row.Cells[2].Value;
                        dgvAxu.Rows[row.Index].Cells["Descripción corta"].Value = row.Cells[3].Value;
                        dgvAxu.Rows[row.Index].Cells["Descripción"].Value = row.Cells[4].Value;
                        dgvAxu.Rows[row.Index].Cells["Día en que empieza el precio rebajado"].Value = row.Cells[5].Value;
                        dgvAxu.Rows[row.Index].Cells["Día en que termina el precio rebajado"].Value = row.Cells[6].Value;
                        dgvAxu.Rows[row.Index].Cells["Inventario"].Value = row.Cells[7].Value;
                        dgvAxu.Rows[row.Index].Cells["Cantidad de bajo inventario"].Value = row.Cells[8].Value;
                        dgvAxu.Rows[row.Index].Cells["Precio rebajado"].Value = row.Cells[9].Value;
                        dgvAxu.Rows[row.Index].Cells["Precio normal"].Value = row.Cells[10].Value;
                        dgvAxu.Rows[row.Index].Cells["Categorías"].Value = subcatdes;
                        dgvAxu.Rows[row.Index].Cells["Etiquetas"].Value = row.Cells[11].Value;
                        dgvAxu.Rows[row.Index].Cells["Imágenes"].Value = row.Cells[12].Value;
                    }
                    Exportar exportar = new Exportar();
                    exportar.ExportarDatos(dgvAxu);
                }
                else
                    MessageBox.Show("No existen datos para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}