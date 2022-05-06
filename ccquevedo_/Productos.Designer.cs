namespace ccquevedo_
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCamaraComercioDataSet = new ccquevedo_.bdCamaraComercioDataSet();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.productosTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_corta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajoInventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiquetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(44, 42);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 46);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // bdCamaraComercioDataSet
            // 
            this.bdCamaraComercioDataSet.DataSetName = "bdCamaraComercioDataSet";
            this.bdCamaraComercioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(198, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion_corta,
            this.Inventario,
            this.Precio_Normal,
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcioncortaDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.imagenesDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.bajoInventarioDataGridViewTextBoxColumn,
            this.precioNormalDataGridViewTextBoxColumn,
            this.precioOfertaDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.etiquetaDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.productosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductos.Location = new System.Drawing.Point(44, 117);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.Size = new System.Drawing.Size(846, 270);
            this.dgvProductos.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 43;
            // 
            // Descripcion_corta
            // 
            this.Descripcion_corta.DataPropertyName = "Descripcion_corta";
            this.Descripcion_corta.HeaderText = "Descripcion";
            this.Descripcion_corta.Name = "Descripcion_corta";
            this.Descripcion_corta.ReadOnly = true;
            this.Descripcion_corta.Width = 42;
            // 
            // Inventario
            // 
            this.Inventario.DataPropertyName = "Inventario";
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            this.Inventario.Width = 42;
            // 
            // Precio_Normal
            // 
            this.Precio_Normal.DataPropertyName = "Precio_Normal";
            this.Precio_Normal.HeaderText = "Precio";
            this.Precio_Normal.Name = "Precio_Normal";
            this.Precio_Normal.ReadOnly = true;
            this.Precio_Normal.Width = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 43;
            // 
            // descripcioncortaDataGridViewTextBoxColumn
            // 
            this.descripcioncortaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_corta";
            this.descripcioncortaDataGridViewTextBoxColumn.HeaderText = "Descripcion_corta";
            this.descripcioncortaDataGridViewTextBoxColumn.Name = "descripcioncortaDataGridViewTextBoxColumn";
            this.descripcioncortaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcioncortaDataGridViewTextBoxColumn.Width = 42;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventarioDataGridViewTextBoxColumn.Width = 42;
            // 
            // imagenesDataGridViewTextBoxColumn
            // 
            this.imagenesDataGridViewTextBoxColumn.DataPropertyName = "Imagenes";
            this.imagenesDataGridViewTextBoxColumn.HeaderText = "Imagenes";
            this.imagenesDataGridViewTextBoxColumn.Name = "imagenesDataGridViewTextBoxColumn";
            this.imagenesDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagenesDataGridViewTextBoxColumn.Width = 43;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 42;
            // 
            // bajoInventarioDataGridViewTextBoxColumn
            // 
            this.bajoInventarioDataGridViewTextBoxColumn.DataPropertyName = "BajoInventario";
            this.bajoInventarioDataGridViewTextBoxColumn.HeaderText = "BajoInventario";
            this.bajoInventarioDataGridViewTextBoxColumn.Name = "bajoInventarioDataGridViewTextBoxColumn";
            this.bajoInventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.bajoInventarioDataGridViewTextBoxColumn.Width = 42;
            // 
            // precioNormalDataGridViewTextBoxColumn
            // 
            this.precioNormalDataGridViewTextBoxColumn.DataPropertyName = "Precio_Normal";
            this.precioNormalDataGridViewTextBoxColumn.HeaderText = "Precio_Normal";
            this.precioNormalDataGridViewTextBoxColumn.Name = "precioNormalDataGridViewTextBoxColumn";
            this.precioNormalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioNormalDataGridViewTextBoxColumn.Width = 43;
            // 
            // precioOfertaDataGridViewTextBoxColumn
            // 
            this.precioOfertaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Oferta";
            this.precioOfertaDataGridViewTextBoxColumn.HeaderText = "Precio_Oferta";
            this.precioOfertaDataGridViewTextBoxColumn.Name = "precioOfertaDataGridViewTextBoxColumn";
            this.precioOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioOfertaDataGridViewTextBoxColumn.Width = 42;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Id_Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 43;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProductoDataGridViewTextBoxColumn.Width = 42;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 42;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Fin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha_Fin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinDataGridViewTextBoxColumn.Width = 43;
            // 
            // etiquetaDataGridViewTextBoxColumn
            // 
            this.etiquetaDataGridViewTextBoxColumn.DataPropertyName = "Etiqueta";
            this.etiquetaDataGridViewTextBoxColumn.HeaderText = "Etiqueta";
            this.etiquetaDataGridViewTextBoxColumn.Name = "etiquetaDataGridViewTextBoxColumn";
            this.etiquetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.etiquetaDataGridViewTextBoxColumn.Width = 42;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescargar.FlatAppearance.BorderSize = 2;
            this.btnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(756, 396);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(134, 46);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 676);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnModificar);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private bdCamaraComercioDataSet bdCamaraComercioDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_corta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bajoInventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiquetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDescargar;
    }
}