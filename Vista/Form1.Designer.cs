namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cardDgv = new MaterialSkin.Controls.MaterialCard();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.btnAtras = new MaterialSkin.Controls.MaterialButton();
            this.lblImagenes = new MaterialSkin.Controls.MaterialLabel();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.pctBoxListImg = new System.Windows.Forms.PictureBox();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ckBoxFiltroAvanzado = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.cbxCriterio = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxCampo = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlSeparadorDgvFooter = new System.Windows.Forms.Panel();
            this.cardVerMas = new MaterialSkin.Controls.MaterialCard();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCodigoVerMas = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodigoArticulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDescripcionVerMas = new System.Windows.Forms.Panel();
            this.lblDescripcionVerMas = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.cardFooter = new MaterialSkin.Controls.MaterialCard();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVerMas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cardDgv.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxListImg)).BeginInit();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.cardVerMas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDescripcionVerMas.SuspendLayout();
            this.cardFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Admin.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(6, 6);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1323, 782);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cardDgv);
            this.tabPage1.Controls.Add(this.pnlHeader);
            this.tabPage1.Controls.Add(this.pnlSeparadorDgvFooter);
            this.tabPage1.Controls.Add(this.cardVerMas);
            this.tabPage1.Controls.Add(this.cardFooter);
            this.tabPage1.ImageKey = "Admin.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1315, 733);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cardDgv
            // 
            this.cardDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardDgv.Controls.Add(this.pnlImagen);
            this.cardDgv.Controls.Add(this.pnlDGV);
            this.cardDgv.Depth = 0;
            this.cardDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardDgv.Location = new System.Drawing.Point(3, 68);
            this.cardDgv.Margin = new System.Windows.Forms.Padding(14);
            this.cardDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardDgv.Name = "cardDgv";
            this.cardDgv.Padding = new System.Windows.Forms.Padding(14);
            this.cardDgv.Size = new System.Drawing.Size(1309, 507);
            this.cardDgv.TabIndex = 12;
            // 
            // pnlImagen
            // 
            this.pnlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImagen.Controls.Add(this.btnAtras);
            this.pnlImagen.Controls.Add(this.lblImagenes);
            this.pnlImagen.Controls.Add(this.btnSiguiente);
            this.pnlImagen.Controls.Add(this.pctBoxListImg);
            this.pnlImagen.Location = new System.Drawing.Point(749, 17);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(546, 473);
            this.pnlImagen.TabIndex = 8;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAtras.Depth = 0;
            this.btnAtras.HighEmphasis = true;
            this.btnAtras.Icon = null;
            this.btnAtras.Location = new System.Drawing.Point(4, 431);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAtras.Size = new System.Drawing.Size(67, 36);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAtras.UseAccentColor = false;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Depth = 0;
            this.lblImagenes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImagenes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblImagenes.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lblImagenes.Location = new System.Drawing.Point(447, 0);
            this.lblImagenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(99, 17);
            this.lblImagenes.TabIndex = 2;
            this.lblImagenes.Text = "materialLabel2";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.HighEmphasis = true;
            this.btnSiguiente.Icon = null;
            this.btnSiguiente.Location = new System.Drawing.Point(447, 431);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSiguiente.Size = new System.Drawing.Size(95, 36);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSiguiente.UseAccentColor = false;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pctBoxListImg
            // 
            this.pctBoxListImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBoxListImg.Location = new System.Drawing.Point(0, 0);
            this.pctBoxListImg.Name = "pctBoxListImg";
            this.pctBoxListImg.Size = new System.Drawing.Size(546, 473);
            this.pctBoxListImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxListImg.TabIndex = 1;
            this.pctBoxListImg.TabStop = false;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGV.Controls.Add(this.dgvArticulos);
            this.pnlDGV.Location = new System.Drawing.Point(3, 6);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(667, 484);
            this.pnlDGV.TabIndex = 7;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnVerMas});
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(667, 484);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.materialDivider1);
            this.pnlHeader.Controls.Add(this.ckBoxFiltroAvanzado);
            this.pnlHeader.Controls.Add(this.btnBuscar);
            this.pnlHeader.Controls.Add(this.cbxCriterio);
            this.pnlHeader.Controls.Add(this.txtBuscar);
            this.pnlHeader.Controls.Add(this.cbxCampo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1309, 65);
            this.pnlHeader.TabIndex = 2;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(766, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(26, 65);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Visible = false;
            // 
            // ckBoxFiltroAvanzado
            // 
            this.ckBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxFiltroAvanzado.AutoSize = true;
            this.ckBoxFiltroAvanzado.Depth = 0;
            this.ckBoxFiltroAvanzado.Location = new System.Drawing.Point(795, 23);
            this.ckBoxFiltroAvanzado.Margin = new System.Windows.Forms.Padding(0);
            this.ckBoxFiltroAvanzado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckBoxFiltroAvanzado.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckBoxFiltroAvanzado.Name = "ckBoxFiltroAvanzado";
            this.ckBoxFiltroAvanzado.ReadOnly = false;
            this.ckBoxFiltroAvanzado.Ripple = true;
            this.ckBoxFiltroAvanzado.Size = new System.Drawing.Size(76, 37);
            this.ckBoxFiltroAvanzado.TabIndex = 5;
            this.ckBoxFiltroAvanzado.Text = "Filtrar";
            this.ckBoxFiltroAvanzado.UseVisualStyleBackColor = true;
            this.ckBoxFiltroAvanzado.CheckedChanged += new System.EventHandler(this.ckBoxFiltroAvanzado_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(1218, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriterio.AutoResize = false;
            this.cbxCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCriterio.Depth = 0;
            this.cbxCriterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCriterio.DropDownHeight = 174;
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.DropDownWidth = 121;
            this.cbxCriterio.Enabled = false;
            this.cbxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.IntegralHeight = false;
            this.cbxCriterio.ItemHeight = 43;
            this.cbxCriterio.Location = new System.Drawing.Point(1057, 11);
            this.cbxCriterio.MaxDropDownItems = 4;
            this.cbxCriterio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(154, 49);
            this.cbxCriterio.StartIndex = 0;
            this.cbxCriterio.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.Hint = "Buscar por nombre de artículo";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(11, 11);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(659, 50);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            // 
            // cbxCampo
            // 
            this.cbxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCampo.AutoResize = false;
            this.cbxCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCampo.Depth = 0;
            this.cbxCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCampo.DropDownHeight = 174;
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.DropDownWidth = 121;
            this.cbxCampo.Enabled = false;
            this.cbxCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.IntegralHeight = false;
            this.cbxCampo.ItemHeight = 43;
            this.cbxCampo.Location = new System.Drawing.Point(897, 11);
            this.cbxCampo.MaxDropDownItems = 4;
            this.cbxCampo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(154, 49);
            this.cbxCampo.StartIndex = 0;
            this.cbxCampo.TabIndex = 3;
            // 
            // pnlSeparadorDgvFooter
            // 
            this.pnlSeparadorDgvFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparadorDgvFooter.Location = new System.Drawing.Point(3, 575);
            this.pnlSeparadorDgvFooter.Name = "pnlSeparadorDgvFooter";
            this.pnlSeparadorDgvFooter.Size = new System.Drawing.Size(1309, 10);
            this.pnlSeparadorDgvFooter.TabIndex = 10;
            // 
            // cardVerMas
            // 
            this.cardVerMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardVerMas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVerMas.Controls.Add(this.panel3);
            this.cardVerMas.Controls.Add(this.pnlDescripcionVerMas);
            this.cardVerMas.Controls.Add(this.btnVolver);
            this.cardVerMas.Depth = 0;
            this.cardVerMas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardVerMas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardVerMas.Location = new System.Drawing.Point(3, 585);
            this.cardVerMas.Margin = new System.Windows.Forms.Padding(14);
            this.cardVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardVerMas.Name = "cardVerMas";
            this.cardVerMas.Padding = new System.Windows.Forms.Padding(14);
            this.cardVerMas.Size = new System.Drawing.Size(1309, 85);
            this.cardVerMas.TabIndex = 8;
            this.cardVerMas.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCodigoVerMas);
            this.panel3.Controls.Add(this.lblCodigoArticulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1017, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 7;
            // 
            // lblCodigoVerMas
            // 
            this.lblCodigoVerMas.AutoSize = true;
            this.lblCodigoVerMas.Depth = 0;
            this.lblCodigoVerMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigoVerMas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoVerMas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblCodigoVerMas.Location = new System.Drawing.Point(0, 0);
            this.lblCodigoVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoVerMas.Name = "lblCodigoVerMas";
            this.lblCodigoVerMas.Size = new System.Drawing.Size(84, 29);
            this.lblCodigoVerMas.TabIndex = 1;
            this.lblCodigoVerMas.Text = "Código:";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Depth = 0;
            this.lblCodigoArticulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoArticulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(0, 31);
            this.lblCodigoArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(63, 24);
            this.lblCodigoArticulo.TabIndex = 2;
            this.lblCodigoArticulo.Text = "Código";
            // 
            // pnlDescripcionVerMas
            // 
            this.pnlDescripcionVerMas.Controls.Add(this.lblDescripcionVerMas);
            this.pnlDescripcionVerMas.Controls.Add(this.txtBoxDescripcion);
            this.pnlDescripcionVerMas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDescripcionVerMas.Location = new System.Drawing.Point(14, 14);
            this.pnlDescripcionVerMas.Name = "pnlDescripcionVerMas";
            this.pnlDescripcionVerMas.Size = new System.Drawing.Size(655, 55);
            this.pnlDescripcionVerMas.TabIndex = 6;
            // 
            // lblDescripcionVerMas
            // 
            this.lblDescripcionVerMas.AutoSize = true;
            this.lblDescripcionVerMas.Depth = 0;
            this.lblDescripcionVerMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcionVerMas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionVerMas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblDescripcionVerMas.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcionVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionVerMas.Name = "lblDescripcionVerMas";
            this.lblDescripcionVerMas.Size = new System.Drawing.Size(128, 29);
            this.lblDescripcionVerMas.TabIndex = 3;
            this.lblDescripcionVerMas.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(0, 30);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(655, 25);
            this.txtBoxDescripcion.TabIndex = 4;
            this.txtBoxDescripcion.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(1217, 14);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 55);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // cardFooter
            // 
            this.cardFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFooter.Controls.Add(this.lblHora);
            this.cardFooter.Controls.Add(this.lblUsuario);
            this.cardFooter.Depth = 0;
            this.cardFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFooter.Location = new System.Drawing.Point(3, 670);
            this.cardFooter.Margin = new System.Windows.Forms.Padding(14);
            this.cardFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFooter.Name = "cardFooter";
            this.cardFooter.Padding = new System.Windows.Forms.Padding(14);
            this.cardFooter.Size = new System.Drawing.Size(1309, 60);
            this.cardFooter.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Depth = 0;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHora.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblHora.Location = new System.Drawing.Point(1135, 14);
            this.lblHora.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(160, 29);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "materialLabel2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblUsuario.Location = new System.Drawing.Point(14, 14);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(218, 29);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Bievenido Sebastián";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1315, 733);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnEditar.FillWeight = 118.7817F;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.HeaderText = "";
            this.btnEditar.MinimumWidth = 80;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnVerMas
            // 
            this.btnVerMas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.btnVerMas.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnVerMas.FillWeight = 81.21828F;
            this.btnVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMas.HeaderText = "";
            this.btnVerMas.MinimumWidth = 80;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.ReadOnly = true;
            this.btnVerMas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnVerMas.Text = "Ver más";
            this.btnVerMas.UseColumnTextForButtonValue = true;
            this.btnVerMas.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 846);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cardDgv.ResumeLayout(false);
            this.pnlImagen.ResumeLayout(false);
            this.pnlImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxListImg)).EndInit();
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardVerMas.ResumeLayout(false);
            this.cardVerMas.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlDescripcionVerMas.ResumeLayout(false);
            this.pnlDescripcionVerMas.PerformLayout();
            this.cardFooter.ResumeLayout(false);
            this.cardFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialComboBox cbxCriterio;
        private MaterialSkin.Controls.MaterialComboBox cbxCampo;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialCheckbox ckBoxFiltroAvanzado;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private System.Windows.Forms.Timer timerHora;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btnAtras;
        private MaterialSkin.Controls.MaterialLabel lblImagenes;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
        private System.Windows.Forms.PictureBox pctBoxListImg;
        private MaterialSkin.Controls.MaterialCard cardFooter;
        private MaterialSkin.Controls.MaterialCard cardVerMas;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel lblCodigoVerMas;
        private MaterialSkin.Controls.MaterialLabel lblCodigoArticulo;
        private System.Windows.Forms.Panel pnlDescripcionVerMas;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionVerMas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private System.Windows.Forms.Panel pnlSeparadorDgvFooter;
        private MaterialSkin.Controls.MaterialCard cardDgv;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerMas;
    }
}

