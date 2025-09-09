namespace Vista
{
    partial class frmAgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArticulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUrlImagen = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.lblMarca = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.cboCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblUrlImagen = new MaterialSkin.Controls.MaterialLabel();
            this.pxbSiguiente = new System.Windows.Forms.PictureBox();
            this.pxbAtras = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pxbImagenCarga = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAtras)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenCarga)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 513);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 72);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 441);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(526, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 435);
            this.panel4.TabIndex = 1;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlImagen.AnimateReadOnly = false;
            this.txtUrlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUrlImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrlImagen.Depth = 0;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlImagen.HideSelection = true;
            this.txtUrlImagen.LeadingIcon = null;
            this.txtUrlImagen.Location = new System.Drawing.Point(114, 0);
            this.txtUrlImagen.MaxLength = 32767;
            this.txtUrlImagen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.PasswordChar = '\0';
            this.txtUrlImagen.PrefixSuffixText = null;
            this.txtUrlImagen.ReadOnly = false;
            this.txtUrlImagen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUrlImagen.SelectedText = "";
            this.txtUrlImagen.SelectionLength = 0;
            this.txtUrlImagen.SelectionStart = 0;
            this.txtUrlImagen.ShortcutsEnabled = true;
            this.txtUrlImagen.Size = new System.Drawing.Size(306, 48);
            this.txtUrlImagen.TabIndex = 128;
            this.txtUrlImagen.TabStop = false;
            this.txtUrlImagen.Text = "Ingrese la URL de la imagen";
            this.txtUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrlImagen.TrailingIcon = null;
            this.txtUrlImagen.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(438, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(319, 58);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.lblPrecio);
            this.panel3.Controls.Add(this.txtPrecio);
            this.panel3.Controls.Add(this.lblCategoria);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.cboCategoria);
            this.panel3.Controls.Add(this.lblDescripcion);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.cboMarca);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.lblMarca);
            this.panel3.Controls.Add(this.lblCodigo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 435);
            this.panel3.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigo.Location = new System.Drawing.Point(235, 97);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 19);
            this.lblCodigo.TabIndex = 117;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Depth = 0;
            this.lblMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMarca.Location = new System.Drawing.Point(240, 195);
            this.lblMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 116;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.HideSelection = true;
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(235, 119);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PrefixSuffixText = null;
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(133, 48);
            this.txtCodigo.TabIndex = 122;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // cboMarca
            // 
            this.cboMarca.AutoResize = false;
            this.cboMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMarca.Depth = 0;
            this.cboMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMarca.DropDownHeight = 174;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.DropDownWidth = 121;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.IntegralHeight = false;
            this.cboMarca.ItemHeight = 43;
            this.cboMarca.Location = new System.Drawing.Point(235, 217);
            this.cboMarca.MaxDropDownItems = 4;
            this.cboMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(133, 49);
            this.cboMarca.StartIndex = 0;
            this.cboMarca.TabIndex = 124;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 301);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 86);
            this.txtDescripcion.TabIndex = 125;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcion.Location = new System.Drawing.Point(5, 279);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 19);
            this.lblDescripcion.TabIndex = 119;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoResize = false;
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCategoria.Depth = 0;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategoria.DropDownHeight = 174;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.DropDownWidth = 121;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.IntegralHeight = false;
            this.cboCategoria.ItemHeight = 43;
            this.cboCategoria.Location = new System.Drawing.Point(3, 217);
            this.cboCategoria.MaxDropDownItems = 4;
            this.cboCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(139, 49);
            this.cboCategoria.StartIndex = 0;
            this.cboCategoria.TabIndex = 123;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(8, 6);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 114;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoria.Location = new System.Drawing.Point(8, 195);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 19);
            this.lblCategoria.TabIndex = 115;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.HideSelection = true;
            this.txtPrecio.Hint = "Solo números";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(8, 119);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PrefixSuffixText = null;
            this.txtPrecio.ReadOnly = false;
            this.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(134, 48);
            this.txtPrecio.TabIndex = 121;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.TrailingIcon = null;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecio.Location = new System.Drawing.Point(8, 97);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 19);
            this.lblPrecio.TabIndex = 118;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Nombre del artículo";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(3, 28);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(365, 48);
            this.txtNombre.TabIndex = 120;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Depth = 0;
            this.lblUrlImagen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUrlImagen.Location = new System.Drawing.Point(438, 0);
            this.lblUrlImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(77, 19);
            this.lblUrlImagen.TabIndex = 135;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // pxbSiguiente
            // 
            this.pxbSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pxbSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.pxbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("pxbSiguiente.Image")));
            this.pxbSiguiente.InitialImage = ((System.Drawing.Image)(resources.GetObject("pxbSiguiente.InitialImage")));
            this.pxbSiguiente.Location = new System.Drawing.Point(483, 319);
            this.pxbSiguiente.Name = "pxbSiguiente";
            this.pxbSiguiente.Size = new System.Drawing.Size(32, 32);
            this.pxbSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbSiguiente.TabIndex = 138;
            this.pxbSiguiente.TabStop = false;
            // 
            // pxbAtras
            // 
            this.pxbAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pxbAtras.BackColor = System.Drawing.Color.Transparent;
            this.pxbAtras.Image = ((System.Drawing.Image)(resources.GetObject("pxbAtras.Image")));
            this.pxbAtras.Location = new System.Drawing.Point(3, 319);
            this.pxbAtras.Name = "pxbAtras";
            this.pxbAtras.Size = new System.Drawing.Size(32, 32);
            this.pxbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbAtras.TabIndex = 136;
            this.pxbAtras.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pxbSiguiente);
            this.panel6.Controls.Add(this.lblUrlImagen);
            this.panel6.Controls.Add(this.pxbAtras);
            this.panel6.Controls.Add(this.pxbImagenCarga);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(518, 354);
            this.panel6.TabIndex = 138;
            // 
            // pxbImagenCarga
            // 
            this.pxbImagenCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbImagenCarga.Image = ((System.Drawing.Image)(resources.GetObject("pxbImagenCarga.Image")));
            this.pxbImagenCarga.Location = new System.Drawing.Point(0, 0);
            this.pxbImagenCarga.Name = "pxbImagenCarga";
            this.pxbImagenCarga.Size = new System.Drawing.Size(518, 354);
            this.pxbImagenCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbImagenCarga.TabIndex = 140;
            this.pxbImagenCarga.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnAceptar);
            this.panel5.Controls.Add(this.txtUrlImagen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 154);
            this.panel5.TabIndex = 139;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(4, 70);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(428, 70);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 137;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 516);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmAgregarArticulo";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "frmAgregarArticulo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAtras)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenCarga)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtUrlImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecio;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialComboBox cboMarca;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialLabel lblMarca;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private System.Windows.Forms.PictureBox pxbSiguiente;
        private System.Windows.Forms.PictureBox pxbAtras;
        private MaterialSkin.Controls.MaterialLabel lblUrlImagen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private System.Windows.Forms.PictureBox pxbImagenCarga;
    }
}