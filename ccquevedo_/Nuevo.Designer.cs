
namespace ccquevedo_
{
    partial class Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcionCorta = new System.Windows.Forms.Label();
            this.lblPrecionormal = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcionCorta = new System.Windows.Forms.TextBox();
            this.txtPrecioNormal = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcionCompleta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcionCompleta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCamaraComercioDataSet = new ccquevedo_.bdCamaraComercioDataSet();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuadar = new System.Windows.Forms.Button();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mcFechaFins = new System.Windows.Forms.DateTimePicker();
            this.mcFechaInicios = new System.Windows.Forms.DateTimePicker();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbSubCategorias = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSubCatergoria = new System.Windows.Forms.DataGridView();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcFechaInicio = new System.Windows.Forms.TextBox();
            this.mcFechaFin = new System.Windows.Forms.TextBox();
            this.productosTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter();
            this.categoriasTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager();
            this.subCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoriaTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.SubCategoriaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatergoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1076, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Agregar Productos";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(31, 81);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 22);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Codigo:*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 122);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 22);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:*";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCorta.Location = new System.Drawing.Point(31, 162);
            this.lblDescripcionCorta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(188, 22);
            this.lblDescripcionCorta.TabIndex = 4;
            this.lblDescripcionCorta.Text = "Descripción Corta:*";
            // 
            // lblPrecionormal
            // 
            this.lblPrecionormal.AutoSize = true;
            this.lblPrecionormal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecionormal.Location = new System.Drawing.Point(564, 84);
            this.lblPrecionormal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecionormal.Name = "lblPrecionormal";
            this.lblPrecionormal.Size = new System.Drawing.Size(148, 22);
            this.lblPrecionormal.TabIndex = 5;
            this.lblPrecionormal.Text = "Precio normal:*";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(564, 125);
            this.lblImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(137, 22);
            this.lblImage.TabIndex = 6;
            this.lblImage.Text = "Precio Oferta:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(236, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombre.Location = new System.Drawing.Point(236, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.Location = new System.Drawing.Point(236, 159);
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Size = new System.Drawing.Size(272, 31);
            this.txtDescripcionCorta.TabIndex = 3;
            // 
            // txtPrecioNormal
            // 
            this.txtPrecioNormal.Location = new System.Drawing.Point(782, 77);
            this.txtPrecioNormal.Name = "txtPrecioNormal";
            this.txtPrecioNormal.Size = new System.Drawing.Size(272, 31);
            this.txtPrecioNormal.TabIndex = 8;
            this.txtPrecioNormal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioNormal_KeyPress);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Location = new System.Drawing.Point(782, 119);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(272, 31);
            this.txtPrecioOferta.TabIndex = 9;
            this.txtPrecioOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioOferta_KeyPress);
            this.txtPrecioOferta.Leave += new System.EventHandler(this.txtPrecioOferta_Leave);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(236, 520);
            this.txtImagen.Multiline = true;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(272, 61);
            this.txtImagen.TabIndex = 11;
            // 
            // txtDescripcionCompleta
            // 
            this.txtDescripcionCompleta.Location = new System.Drawing.Point(236, 200);
            this.txtDescripcionCompleta.Multiline = true;
            this.txtDescripcionCompleta.Name = "txtDescripcionCompleta";
            this.txtDescripcionCompleta.Size = new System.Drawing.Size(272, 127);
            this.txtDescripcionCompleta.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(236, 381);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(272, 31);
            this.txtStock.TabIndex = 6;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Imagen:";
            // 
            // lblDescripcionCompleta
            // 
            this.lblDescripcionCompleta.AutoSize = true;
            this.lblDescripcionCompleta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCompleta.Location = new System.Drawing.Point(31, 201);
            this.lblDescripcionCompleta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCompleta.Name = "lblDescripcionCompleta";
            this.lblDescripcionCompleta.Size = new System.Drawing.Size(121, 22);
            this.lblDescripcionCompleta.TabIndex = 14;
            this.lblDescripcionCompleta.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Minimo Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Categoria:*";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCategoria.DropDownHeight = 100;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.Location = new System.Drawing.Point(782, 165);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(272, 30);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoria_SelectionChangeCommitted);
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // bdCamaraComercioDataSet
            // 
            this.bdCamaraComercioDataSet.DataSetName = "bdCamaraComercioDataSet";
            this.bdCamaraComercioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Enabled = false;
            this.txtTipoProducto.Location = new System.Drawing.Point(782, 483);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(272, 31);
            this.txtTipoProducto.TabIndex = 26;
            this.txtTipoProducto.Text = "Simple";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 489);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tipo de producto:";
            // 
            // btnGuadar
            // 
            this.btnGuadar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuadar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuadar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuadar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuadar.Image")));
            this.btnGuadar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuadar.Location = new System.Drawing.Point(895, 547);
            this.btnGuadar.Name = "btnGuadar";
            this.btnGuadar.Size = new System.Drawing.Size(159, 47);
            this.btnGuadar.TabIndex = 27;
            this.btnGuadar.Text = "Guardar";
            this.btnGuadar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuadar.UseVisualStyleBackColor = false;
            this.btnGuadar.Click += new System.EventHandler(this.btnGuadar_Click);
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtInventario.Location = new System.Drawing.Point(236, 341);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(272, 31);
            this.txtInventario.TabIndex = 5;
            this.txtInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInventario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Inventario:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(101, 44);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha fin \r\nde oferta:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(123, 44);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha inicio \r\nde oferta:\r\n";
            // 
            // mcFechaFins
            // 
            this.mcFechaFins.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFins.Enabled = false;
            this.mcFechaFins.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFins.Location = new System.Drawing.Point(782, 432);
            this.mcFechaFins.Name = "mcFechaFins";
            this.mcFechaFins.Size = new System.Drawing.Size(272, 31);
            this.mcFechaFins.TabIndex = 13;
            this.mcFechaFins.ValueChanged += new System.EventHandler(this.mcFechaFins_ValueChanged);
            // 
            // mcFechaInicios
            // 
            this.mcFechaInicios.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.mcFechaInicios.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicios.Enabled = false;
            this.mcFechaInicios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicios.Location = new System.Drawing.Point(782, 384);
            this.mcFechaInicios.Name = "mcFechaInicios";
            this.mcFechaInicios.Size = new System.Drawing.Size(272, 31);
            this.mcFechaInicios.TabIndex = 12;
            this.mcFechaInicios.ValueChanged += new System.EventHandler(this.mcFechaInicio_ValueChanged);
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtEtiqueta.Location = new System.Drawing.Point(236, 432);
            this.txtEtiqueta.Multiline = true;
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(272, 67);
            this.txtEtiqueta.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label9.Location = new System.Drawing.Point(31, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 44);
            this.label9.TabIndex = 64;
            this.label9.Text = "Etiquetas:\r\n(Ejemplo:blusa,ropa)";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(467, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 32);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSubCategorias
            // 
            this.cmbSubCategorias.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSubCategorias.DropDownHeight = 100;
            this.cmbSubCategorias.FormattingEnabled = true;
            this.cmbSubCategorias.IntegralHeight = false;
            this.cmbSubCategorias.Location = new System.Drawing.Point(782, 213);
            this.cmbSubCategorias.Name = "cmbSubCategorias";
            this.cmbSubCategorias.Size = new System.Drawing.Size(272, 30);
            this.cmbSubCategorias.TabIndex = 66;
            this.cmbSubCategorias.Text = "Seleccionar";
            this.cmbSubCategorias.SelectionChangeCommitted += new System.EventHandler(this.cmbSubCategorias_SelectionChangeCommitted);
            this.cmbSubCategorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(564, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 22);
            this.label10.TabIndex = 67;
            this.label10.Text = "Sub Categorias:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSubCatergoria);
            this.panel2.Location = new System.Drawing.Point(782, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 100);
            this.panel2.TabIndex = 70;
            // 
            // dgvSubCatergoria
            // 
            this.dgvSubCatergoria.AllowUserToAddRows = false;
            this.dgvSubCatergoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSubCatergoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCatergoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCatergoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCatergoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubCategoria});
            this.dgvSubCatergoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSubCatergoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCatergoria.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvSubCatergoria.Location = new System.Drawing.Point(0, 0);
            this.dgvSubCatergoria.MultiSelect = false;
            this.dgvSubCatergoria.Name = "dgvSubCatergoria";
            this.dgvSubCatergoria.ReadOnly = true;
            this.dgvSubCatergoria.RowHeadersVisible = false;
            this.dgvSubCatergoria.Size = new System.Drawing.Size(272, 100);
            this.dgvSubCatergoria.TabIndex = 0;
            // 
            // SubCategoria
            // 
            this.SubCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.ReadOnly = true;
            // 
            // mcFechaInicio
            // 
            this.mcFechaInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcFechaInicio.Enabled = false;
            this.mcFechaInicio.Location = new System.Drawing.Point(782, 384);
            this.mcFechaInicio.Name = "mcFechaInicio";
            this.mcFechaInicio.Size = new System.Drawing.Size(255, 31);
            this.mcFechaInicio.TabIndex = 71;
            this.mcFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mcFechaInicio_KeyPress);
            // 
            // mcFechaFin
            // 
            this.mcFechaFin.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcFechaFin.Enabled = false;
            this.mcFechaFin.Location = new System.Drawing.Point(782, 432);
            this.mcFechaFin.Name = "mcFechaFin";
            this.mcFechaFin.Size = new System.Drawing.Size(255, 31);
            this.mcFechaFin.TabIndex = 72;
            this.mcFechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mcFechaFin_KeyPress);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cat_SubTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.SubCategoriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subCategoriaBindingSource
            // 
            this.subCategoriaBindingSource.DataMember = "SubCategoria";
            this.subCategoriaBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // subCategoriaTableAdapter
            // 
            this.subCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1107, 618);
            this.Controls.Add(this.mcFechaFin);
            this.Controls.Add(this.mcFechaInicio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbSubCategorias);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mcFechaFins);
            this.Controls.Add(this.mcFechaInicios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuadar);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtDescripcionCompleta);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescripcionCompleta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtPrecioNormal);
            this.Controls.Add(this.txtDescripcionCorta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblPrecionormal);
            this.Controls.Add(this.lblDescripcionCorta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(31, 384);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nuevo_FormClosing);
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatergoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcionCorta;
        private System.Windows.Forms.Label lblPrecionormal;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcionCorta;
        private System.Windows.Forms.TextBox txtPrecioNormal;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtDescripcionCompleta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcionCompleta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuadar;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private bdCamaraComercioDataSet bdCamaraComercioDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker mcFechaFins;
        public System.Windows.Forms.DateTimePicker mcFechaInicios;
        public System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSubCatergoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.TextBox mcFechaInicio;
        private System.Windows.Forms.TextBox mcFechaFin;
        private bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource subCategoriaBindingSource;
        private bdCamaraComercioDataSetTableAdapters.SubCategoriaTableAdapter subCategoriaTableAdapter;
        public System.Windows.Forms.ComboBox cmbSubCategorias;
    }
}