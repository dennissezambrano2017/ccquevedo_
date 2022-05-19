namespace ccquevedo_
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtprecioRebajado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtminStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDesCorta = new System.Windows.Forms.Label();
            this.txtDescripcionL = new System.Windows.Forms.TextBox();
            this.lblDesComple = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcFechaInicios = new System.Windows.Forms.DateTimePicker();
            this.mcFechaFins = new System.Windows.Forms.DateTimePicker();
            this.dgvSubCatergoria = new System.Windows.Forms.DataGridView();
            this.cmbSubCategorias = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mcFechaFin = new System.Windows.Forms.TextBox();
            this.mcFechaInicio = new System.Windows.Forms.TextBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCamaraComercioDataSet = new ccquevedo_.bdCamaraComercioDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter();
            this.subCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoriaTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.SubCategoriaTableAdapter();
            this.cat_SubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cat_SubTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.Cat_SubTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.Label();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatergoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_SubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblNombre.Location = new System.Drawing.Point(31, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:*";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(236, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // txtprecioRebajado
            // 
            this.txtprecioRebajado.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtprecioRebajado.Location = new System.Drawing.Point(782, 119);
            this.txtprecioRebajado.Name = "txtprecioRebajado";
            this.txtprecioRebajado.Size = new System.Drawing.Size(272, 31);
            this.txtprecioRebajado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(564, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio rebajado:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtPrecio.Location = new System.Drawing.Point(782, 71);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(272, 31);
            this.txtPrecio.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(564, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio normal:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(564, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:*";
            // 
            // txtminStock
            // 
            this.txtminStock.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtminStock.Location = new System.Drawing.Point(236, 381);
            this.txtminStock.Name = "txtminStock";
            this.txtminStock.Size = new System.Drawing.Size(272, 31);
            this.txtminStock.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(31, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimo Stock:*";
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtInventario.Location = new System.Drawing.Point(236, 341);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(272, 31);
            this.txtInventario.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.Location = new System.Drawing.Point(31, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inventario:*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(236, 159);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 31);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDesCorta
            // 
            this.lblDesCorta.AutoSize = true;
            this.lblDesCorta.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDesCorta.Location = new System.Drawing.Point(31, 162);
            this.lblDesCorta.Name = "lblDesCorta";
            this.lblDesCorta.Size = new System.Drawing.Size(188, 22);
            this.lblDesCorta.TabIndex = 14;
            this.lblDesCorta.Text = "Descripción Corta:*";
            // 
            // txtDescripcionL
            // 
            this.txtDescripcionL.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDescripcionL.Location = new System.Drawing.Point(236, 200);
            this.txtDescripcionL.Multiline = true;
            this.txtDescripcionL.Name = "txtDescripcionL";
            this.txtDescripcionL.Size = new System.Drawing.Size(272, 127);
            this.txtDescripcionL.TabIndex = 4;
            // 
            // lblDesComple
            // 
            this.lblDesComple.AutoSize = true;
            this.lblDesComple.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDesComple.Location = new System.Drawing.Point(31, 201);
            this.lblDesComple.Name = "lblDesComple";
            this.lblDesComple.Size = new System.Drawing.Size(126, 22);
            this.lblDesComple.TabIndex = 17;
            this.lblDesComple.Text = "Descripción :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 50);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(503, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Modificar Productos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrar.Location = new System.Drawing.Point(1076, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Enabled = false;
            this.txtTipoProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProducto.Location = new System.Drawing.Point(782, 480);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(272, 31);
            this.txtTipoProducto.TabIndex = 14;
            this.txtTipoProducto.Text = "Simple";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 486);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tipo de producto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 521);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 46;
            this.label12.Text = "Imagen:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(798, 554);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 47);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(236, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblCodigo.Location = new System.Drawing.Point(31, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 22);
            this.lblCodigo.TabIndex = 51;
            this.lblCodigo.Text = "Codigo:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(123, 44);
            this.label5.TabIndex = 53;
            this.label5.Text = "Fecha inicio \r\nde oferta:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(101, 44);
            this.label8.TabIndex = 55;
            this.label8.Text = "Fecha fin \r\nde oferta:\r\n";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownHeight = 100;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.Location = new System.Drawing.Point(782, 168);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(272, 30);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoria_SelectionChangeCommitted);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(31, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 58;
            this.label1.Text = "Etiquetas:\r\n(Ejemplo:blusa,ropa)";
            // 
            // mcFechaInicios
            // 
            this.mcFechaInicios.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicios.Location = new System.Drawing.Point(782, 381);
            this.mcFechaInicios.Name = "mcFechaInicios";
            this.mcFechaInicios.Size = new System.Drawing.Size(272, 31);
            this.mcFechaInicios.TabIndex = 12;
            this.mcFechaInicios.ValueChanged += new System.EventHandler(this.mcFechaInicios_ValueChanged_1);
            // 
            // mcFechaFins
            // 
            this.mcFechaFins.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFins.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFins.Location = new System.Drawing.Point(782, 429);
            this.mcFechaFins.Name = "mcFechaFins";
            this.mcFechaFins.Size = new System.Drawing.Size(272, 31);
            this.mcFechaFins.TabIndex = 13;
            this.mcFechaFins.ValueChanged += new System.EventHandler(this.mcFechaFins_ValueChanged);
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
            this.SubCategoria,
            this.Eliminar});
            this.dgvSubCatergoria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCatergoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubCatergoria.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvSubCatergoria.Location = new System.Drawing.Point(782, 264);
            this.dgvSubCatergoria.MultiSelect = false;
            this.dgvSubCatergoria.Name = "dgvSubCatergoria";
            this.dgvSubCatergoria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCatergoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubCatergoria.RowHeadersVisible = false;
            this.dgvSubCatergoria.Size = new System.Drawing.Size(272, 100);
            this.dgvSubCatergoria.TabIndex = 59;
            this.dgvSubCatergoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCatergoria_CellContentClick);
            // 
            // cmbSubCategorias
            // 
            this.cmbSubCategorias.DropDownHeight = 100;
            this.cmbSubCategorias.Enabled = false;
            this.cmbSubCategorias.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cmbSubCategorias.FormattingEnabled = true;
            this.cmbSubCategorias.IntegralHeight = false;
            this.cmbSubCategorias.Location = new System.Drawing.Point(782, 213);
            this.cmbSubCategorias.Name = "cmbSubCategorias";
            this.cmbSubCategorias.Size = new System.Drawing.Size(272, 30);
            this.cmbSubCategorias.TabIndex = 70;
            this.cmbSubCategorias.SelectionChangeCommitted += new System.EventHandler(this.cmbSubCategorias_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 22);
            this.label9.TabIndex = 71;
            this.label9.Text = "Sub Categorias:";
            // 
            // mcFechaFin
            // 
            this.mcFechaFin.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcFechaFin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mcFechaFin.Location = new System.Drawing.Point(782, 429);
            this.mcFechaFin.Name = "mcFechaFin";
            this.mcFechaFin.Size = new System.Drawing.Size(255, 31);
            this.mcFechaFin.TabIndex = 76;
            this.mcFechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mcFechaFin_KeyPress);
            // 
            // mcFechaInicio
            // 
            this.mcFechaInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mcFechaInicio.Location = new System.Drawing.Point(782, 381);
            this.mcFechaInicio.Name = "mcFechaInicio";
            this.mcFechaInicio.Size = new System.Drawing.Size(255, 31);
            this.mcFechaInicio.TabIndex = 75;
            this.mcFechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mcFechaInicio_KeyPress);
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
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cat_SubTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.SubCategoriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
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
            // cat_SubBindingSource
            // 
            this.cat_SubBindingSource.DataMember = "Cat_Sub";
            this.cat_SubBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // cat_SubTableAdapter
            // 
            this.cat_SubTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(236, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 35);
            this.button1.TabIndex = 78;
            this.button1.Text = "Subir  una imagen      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(233, 570);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(275, 67);
            this.txtImage.TabIndex = 79;
            // 
            // SubCategoria
            // 
            this.SubCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubCategoria.HeaderText = "SubCategoria";
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Width = 30;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1107, 646);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mcFechaFin);
            this.Controls.Add(this.mcFechaInicio);
            this.Controls.Add(this.cmbSubCategorias);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvSubCatergoria);
            this.Controls.Add(this.mcFechaFins);
            this.Controls.Add(this.mcFechaInicios);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescripcionL);
            this.Controls.Add(this.lblDesComple);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDesCorta);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtminStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecioRebajado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatergoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_SubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtprecioRebajado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtminStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDesCorta;
        private bdCamaraComercioDataSet bdCamaraComercioDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtDescripcionL;
        private System.Windows.Forms.Label lblDesComple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker mcFechaInicios;
        private System.Windows.Forms.DateTimePicker mcFechaFins;
        private System.Windows.Forms.DataGridView dgvSubCatergoria;
        private System.Windows.Forms.ComboBox cmbSubCategorias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mcFechaFin;
        private System.Windows.Forms.TextBox mcFechaInicio;
        private System.Windows.Forms.BindingSource subCategoriaBindingSource;
        private bdCamaraComercioDataSetTableAdapters.SubCategoriaTableAdapter subCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource cat_SubBindingSource;
        private bdCamaraComercioDataSetTableAdapters.Cat_SubTableAdapter cat_SubTableAdapter;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label txtImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}