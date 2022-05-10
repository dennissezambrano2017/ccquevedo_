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
            this.btnDescargar = new System.Windows.Forms.Button();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_corta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BajoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.dgvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo_Producto,
            this.Nombre,
            this.Descripcion_corta,
            this.Descripcion,
            this.Fecha_Fin,
            this.Fecha_Inicio,
            this.Inventario,
            this.BajoInventario,
            this.Precio_Oferta,
            this.Precio_Normal,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.Etiqueta,
            this.Imagenes});
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 83;
            // 
            // Tipo_Producto
            // 
            this.Tipo_Producto.DataPropertyName = "Tipo_Producto";
            this.Tipo_Producto.HeaderText = "Tipo Producto";
            this.Tipo_Producto.Name = "Tipo_Producto";
            this.Tipo_Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 98;
            // 
            // Descripcion_corta
            // 
            this.Descripcion_corta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Descripcion_corta.DataPropertyName = "Descripcion_corta";
            this.Descripcion_corta.HeaderText = "Descripción Corta";
            this.Descripcion_corta.Name = "Descripcion_corta";
            this.Descripcion_corta.ReadOnly = true;
            this.Descripcion_corta.Width = 160;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Fecha_Fin.DataPropertyName = "Fecha_Fin";
            this.Fecha_Fin.HeaderText = "Fecha Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.ReadOnly = true;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            this.Fecha_Inicio.Width = 118;
            // 
            // Inventario
            // 
            this.Inventario.DataPropertyName = "Inventario";
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            // 
            // BajoInventario
            // 
            this.BajoInventario.DataPropertyName = "BajoInventario";
            this.BajoInventario.HeaderText = "Bajo Inventario";
            this.BajoInventario.Name = "BajoInventario";
            this.BajoInventario.ReadOnly = true;
            this.BajoInventario.Width = 130;
            // 
            // Precio_Oferta
            // 
            this.Precio_Oferta.DataPropertyName = "Precio_Oferta";
            this.Precio_Oferta.HeaderText = "Precio Oferta";
            this.Precio_Oferta.Name = "Precio_Oferta";
            this.Precio_Oferta.ReadOnly = true;
            this.Precio_Oferta.Width = 130;
            // 
            // Precio_Normal
            // 
            this.Precio_Normal.DataPropertyName = "Precio_Normal";
            this.Precio_Normal.HeaderText = "Precio Normal";
            this.Precio_Normal.Name = "Precio_Normal";
            this.Precio_Normal.ReadOnly = true;
            this.Precio_Normal.Width = 130;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 120;
            // 
            // Etiqueta
            // 
            this.Etiqueta.DataPropertyName = "Etiqueta";
            this.Etiqueta.HeaderText = "Etiqueta";
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.ReadOnly = true;
            // 
            // Imagenes
            // 
            this.Imagenes.DataPropertyName = "Imagenes";
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.ReadOnly = true;
            this.Imagenes.Width = 120;
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
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_corta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BajoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
    }
}