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
    public partial class CrearExcel : Form
    {
        private int posicion;
        private bool datos;
        public Nuevo frmCrear;
        public CrearExcel()
        {
            InitializeComponent();

        }
        private DataGridView dtProductos;

        public DataGridView DtProductos { get => dtProductos; set => dtProductos = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public bool Datos { get => datos; set => datos = value; }

        public void DT_Productos()
        {
            dtProductos = dgvProducto;
        }
        public void Posicion_()
        {
            posicion = dgvProducto.CurrentRow.Index;
        }

        public void Datos_()
        {
            datos = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCrear =  Nuevo.FormCrear();
            AddOwnedForm(frmCrear);
            frmCrear.ShowDialog();

        }


        private void CrearExcel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.SubCategoria' Puede moverla o quitarla según sea necesario.
            this.subCategoriaTableAdapter.Fill(this.bdCamaraComercioDataSet.SubCategoria);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Cat_Sub' Puede moverla o quitarla según sea necesario.
            this.cat_SubTableAdapter.Fill(this.bdCamaraComercioDataSet.Cat_Sub);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                DT_Productos();

                //falta agrgar el resto de datos 
                dgvProducto.Columns.Add("ID", "Codigo");
                dgvProducto.Columns.Add("Tipo", "Tipo Producto");
                dgvProducto.Columns.Add("Nombre", "Nombre");
                dgvProducto.Columns.Add("Descripción corta", "Descripción Corta");
                dgvProducto.Columns.Add("Descripción", "Descripción Larga");
                dgvProducto.Columns.Add("Día en que empieza el precio rebajado", "Fecha Inicio");
                dgvProducto.Columns.Add("Día en que termina el precio rebajado", "Fecha Fin");
                dgvProducto.Columns.Add("Inventario", "Stock");
                dgvProducto.Columns.Add("Cantidad de bajo inventario", "Min Stock");
                dgvProducto.Columns.Add("Precio rebajado", "Precio Oferta");
                dgvProducto.Columns.Add("Precio normal", "Precio Normal");
                dgvProducto.Columns.Add("Categorías", "Categoria");
                dgvProducto.Columns.Add("Etiquetas", "Etiquetas");
                dgvProducto.Columns.Add("Imágenes", "Imagen");
                if (dgvProducto.SelectedRows.Count > 0)
                    Datos_();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = Modificar.FormCrear();
            try
            {
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    Posicion_();
                    AddOwnedForm(frmModificar);
                    frmModificar.txtCodigo.Text = dtProductos.CurrentRow.Cells[0].Value.ToString();
                    frmModificar.txtTipoProducto.Text = dtProductos.CurrentRow.Cells[9].Value.ToString();
                    frmModificar.txtNombre.Text = dtProductos.CurrentRow.Cells[1].Value.ToString();
                    frmModificar.txtDesCorta.Text = dtProductos.CurrentRow.Cells[2].Value.ToString();
                    frmModificar.txtDescriComple.Text = dtProductos.CurrentRow.Cells[3].Value.ToString();
                    //frmModificar.mcfe
                    frmModificar.txtPrecioNormal.Text = dtProductos.CurrentRow.Cells[4].Value.ToString();
                    frmModificar.txtPrecioOferta.Text = dtProductos.CurrentRow.Cells[5].Value.ToString();
                    frmModificar.txtStock.Text = dtProductos.CurrentRow.Cells[6].Value.ToString();
                    frmModificar.txtImage.Text = dtProductos.CurrentRow.Cells[7].Value.ToString();
                    frmModificar.cmbCategoria.Text = dtProductos.CurrentRow.Cells[11].Value.ToString();
                    //MessageBox.Show(dtProductos.CurrentRow.Cells[11].Value.ToString());
                    
                    frmModificar.ShowDialog();
                    dgvProducto.Rows[0].Selected = false;
                }
                else
                    MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnElimnar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Esta seguro de eliminar la fila", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvProducto.Rows.Remove(dgvProducto.CurrentRow);
                    }

                }
                else
                    MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActu_Desca_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows != null && dgvProducto.Rows.Count != 0)
                {
                    Insertar();
                    Exportar exportar = new Exportar();
                    exportar.ExportarDatos(dgvProducto);
                }
                else
                    MessageBox.Show("No existen datos para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.Rows.Count > 0)
                {
                    Insertar();
                }
                else
                    MessageBox.Show("No existen datos en la tabla para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Insertar()
        {
            try
            {
                for (int i = 0; i < dgvProducto.Rows.Count; i++)
                {
                    var v = this.productosTableAdapter.Existe(dtProductos.Rows[i].Cells[0].Value.ToString());
                    //Cadena de categoria y sub categoria
                    string cadena = dtProductos.Rows[i].Cells[11].Value.ToString();
                    //posición para obtener la posición de la categoria
                    int num = cadena.IndexOf(">");
                    if (num < 1)
                    {
                        num = cadena.Length;
                    }
                    //obtener el id de la categoria
                    var id = this.categoriasTableAdapter.ConsultarId(cadena.Substring(0, num));
                    
                    //obtener las subcategorias
                    MessageBox.Show(cadena+ " id: " + id);
                    string[] parte = cadena.Split(',');

                    List<string> resu = new List<string>();
                    List<string> resuCa = new List<string>();
                    for (int j = 0; j < parte.Length-1; j++)
                    {
                        resu.Add(parte[j]);
                    }
                    for (int j = 0; j < resu.Count; j++)
                    {
                        string n = resu[j].Split('>')[1];
                        if (n != "1")
                        {
                            string partedos = resu[j].Split('>')[1];
                            resuCa.Add(partedos.ToString());
                        }
                    }
                    

                    if (v.ToString() != "1")
                    {
                        this.productosTableAdapter.Insertar(
                        dtProductos.Rows[i].Cells[0].Value.ToString(),
                        dtProductos.Rows[i].Cells[2].Value.ToString(),
                        dtProductos.Rows[i].Cells[3].Value.ToString(),
                        dtProductos.Rows[i].Cells[7].Value.ToString(),
                        dtProductos.Rows[i].Cells[13].Value.ToString(),
                        dtProductos.Rows[i].Cells[8].Value.ToString(),
                        dtProductos.Rows[i].Cells[4].Value.ToString(),
                        dtProductos.Rows[i].Cells[6].Value.ToString(),
                        dtProductos.Rows[i].Cells[5].Value.ToString(),
                        dtProductos.Rows[i].Cells[10].Value.ToString(), 
                        dtProductos.Rows[i].Cells[9].Value.ToString(),
                        dtProductos.Rows[i].Cells[1].Value.ToString(),
                        dtProductos.Rows[i].Cells[12].Value.ToString());

                    }
                    else
                    {
                        this.productosTableAdapter.Editar(
                        dtProductos.Rows[i].Cells[2].Value.ToString(),
                        dtProductos.Rows[i].Cells[3].Value.ToString(),
                        dtProductos.Rows[i].Cells[7].Value.ToString(),
                        dtProductos.Rows[i].Cells[13].Value.ToString(),
                        dtProductos.Rows[i].Cells[8].Value.ToString(),
                        dtProductos.Rows[i].Cells[4].Value.ToString(),
                        dtProductos.Rows[i].Cells[6].Value.ToString(),
                        dtProductos.Rows[i].Cells[5].Value.ToString(),
                        dtProductos.Rows[i].Cells[10].Value.ToString(),
                        dtProductos.Rows[i].Cells[9].Value.ToString(),
                        dtProductos.Rows[i].Cells[1].Value.ToString(),
                        dtProductos.Rows[i].Cells[12].Value.ToString(),
                        dtProductos.Rows[i].Cells[0].Value.ToString());
                        this.cat_SubTableAdapter.Eliminar(dtProductos.Rows[i].Cells[0].Value.ToString());
                        
                    }
                    if (num < 1)
                    {
                        this.cat_SubTableAdapter.Insertar(id.ToString(), "", dtProductos.Rows[i].Cells[0].Value.ToString());
                    }
                    for (int j = 0; j < resuCa.Count; j++)
                    {
                        string idsubcat = this.subCategoriaTableAdapter.BuscarSubId(resuCa[j].ToString(),id.ToString());
                        this.cat_SubTableAdapter.Insertar(id.ToString(), idsubcat, dtProductos.Rows[i].Cells[0].Value.ToString());
                        MessageBox.Show(resuCa[j].ToString(), "dos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }
    }
}
