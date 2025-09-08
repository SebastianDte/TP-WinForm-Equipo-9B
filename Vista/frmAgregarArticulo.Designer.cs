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
            this.pnlFormularioCarga = new System.Windows.Forms.Panel();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cboMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.cboCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.lblMarca = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.pnlImagenCarga = new System.Windows.Forms.Panel();
            this.pnlPixtureCarga = new System.Windows.Forms.Panel();
            this.lblImagen = new MaterialSkin.Controls.MaterialLabel();
            this.pxbImagenCarga = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblUrlImagen = new MaterialSkin.Controls.MaterialLabel();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.pnlFormularioCarga.SuspendLayout();
            this.pnlImagenCarga.SuspendLayout();
            this.pnlPixtureCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormularioCarga
            // 
            this.pnlFormularioCarga.Controls.Add(this.txtDescripcion);
            this.pnlFormularioCarga.Controls.Add(this.cboMarca);
            this.pnlFormularioCarga.Controls.Add(this.cboCategoria);
            this.pnlFormularioCarga.Controls.Add(this.txtCodigo);
            this.pnlFormularioCarga.Controls.Add(this.txtPrecio);
            this.pnlFormularioCarga.Controls.Add(this.txtNombre);
            this.pnlFormularioCarga.Controls.Add(this.lblDescripcion);
            this.pnlFormularioCarga.Controls.Add(this.lblPrecio);
            this.pnlFormularioCarga.Controls.Add(this.lblCodigo);
            this.pnlFormularioCarga.Controls.Add(this.lblMarca);
            this.pnlFormularioCarga.Controls.Add(this.lblCategoria);
            this.pnlFormularioCarga.Controls.Add(this.lblNombre);
            this.pnlFormularioCarga.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFormularioCarga.Location = new System.Drawing.Point(3, 0);
            this.pnlFormularioCarga.Name = "pnlFormularioCarga";
            this.pnlFormularioCarga.Size = new System.Drawing.Size(414, 463);
            this.pnlFormularioCarga.TabIndex = 18;
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
            this.txtDescripcion.Location = new System.Drawing.Point(47, 329);
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
            this.txtDescripcion.Size = new System.Drawing.Size(293, 100);
            this.txtDescripcion.TabIndex = 26;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.cboMarca.Location = new System.Drawing.Point(220, 238);
            this.cboMarca.MaxDropDownItems = 4;
            this.cboMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 49);
            this.cboMarca.StartIndex = 0;
            this.cboMarca.TabIndex = 25;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.cboCategoria.Location = new System.Drawing.Point(52, 238);
            this.cboCategoria.MaxDropDownItems = 4;
            this.cboCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 49);
            this.cboCategoria.StartIndex = 0;
            this.cboCategoria.TabIndex = 24;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.HideSelection = true;
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(220, 144);
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
            this.txtCodigo.Size = new System.Drawing.Size(120, 48);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.HideSelection = true;
            this.txtPrecio.Hint = "Solo números";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(52, 144);
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
            this.txtPrecio.Size = new System.Drawing.Size(120, 48);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.TrailingIcon = null;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Nombre del artículo";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(47, 56);
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
            this.txtNombre.Size = new System.Drawing.Size(293, 48);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcion.Location = new System.Drawing.Point(47, 307);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 19);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecio.Location = new System.Drawing.Point(54, 122);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 19);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigo.Location = new System.Drawing.Point(217, 122);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 19);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Depth = 0;
            this.lblMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMarca.Location = new System.Drawing.Point(217, 216);
            this.lblMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoria.Location = new System.Drawing.Point(49, 216);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 19);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(49, 34);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlImagenCarga
            // 
            this.pnlImagenCarga.Controls.Add(this.pnlPixtureCarga);
            this.pnlImagenCarga.Controls.Add(this.txtUrlImagen);
            this.pnlImagenCarga.Controls.Add(this.lblUrlImagen);
            this.pnlImagenCarga.Controls.Add(this.btnAceptar);
            this.pnlImagenCarga.Controls.Add(this.btnCancelar);
            this.pnlImagenCarga.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImagenCarga.Location = new System.Drawing.Point(423, 0);
            this.pnlImagenCarga.Name = "pnlImagenCarga";
            this.pnlImagenCarga.Size = new System.Drawing.Size(389, 463);
            this.pnlImagenCarga.TabIndex = 19;
            // 
            // pnlPixtureCarga
            // 
            this.pnlPixtureCarga.Controls.Add(this.lblImagen);
            this.pnlPixtureCarga.Controls.Add(this.pxbImagenCarga);
            this.pnlPixtureCarga.Location = new System.Drawing.Point(54, 34);
            this.pnlPixtureCarga.Name = "pnlPixtureCarga";
            this.pnlPixtureCarga.Size = new System.Drawing.Size(284, 253);
            this.pnlPixtureCarga.TabIndex = 24;
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagen.AutoSize = true;
            this.lblImagen.Depth = 0;
            this.lblImagen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImagen.Location = new System.Drawing.Point(208, 0);
            this.lblImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(73, 19);
            this.lblImagen.TabIndex = 23;
            this.lblImagen.Text = "UrlImagen";
            // 
            // pxbImagenCarga
            // 
            this.pxbImagenCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbImagenCarga.Location = new System.Drawing.Point(0, 0);
            this.pxbImagenCarga.Name = "pxbImagenCarga";
            this.pxbImagenCarga.Size = new System.Drawing.Size(284, 253);
            this.pxbImagenCarga.TabIndex = 24;
            this.pxbImagenCarga.TabStop = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlImagen.AnimateReadOnly = false;
            this.txtUrlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUrlImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrlImagen.Depth = 0;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlImagen.HideSelection = true;
            this.txtUrlImagen.LeadingIcon = null;
            this.txtUrlImagen.Location = new System.Drawing.Point(54, 329);
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
            this.txtUrlImagen.Size = new System.Drawing.Size(284, 48);
            this.txtUrlImagen.TabIndex = 22;
            this.txtUrlImagen.TabStop = false;
            this.txtUrlImagen.Text = "Ingrese la URL de la imagen";
            this.txtUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrlImagen.TrailingIcon = null;
            this.txtUrlImagen.UseSystemPasswordChar = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Depth = 0;
            this.lblUrlImagen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUrlImagen.Location = new System.Drawing.Point(51, 307);
            this.lblUrlImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(77, 19);
            this.lblUrlImagen.TabIndex = 20;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(54, 393);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(242, 393);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 466);
            this.Controls.Add(this.pnlImagenCarga);
            this.Controls.Add(this.pnlFormularioCarga);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmAgregarArticulo";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "frmAgregarArticulo";
            this.pnlFormularioCarga.ResumeLayout(false);
            this.pnlFormularioCarga.PerformLayout();
            this.pnlImagenCarga.ResumeLayout(false);
            this.pnlImagenCarga.PerformLayout();
            this.pnlPixtureCarga.ResumeLayout(false);
            this.pnlPixtureCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormularioCarga;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialComboBox cboMarca;
        private MaterialSkin.Controls.MaterialComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private MaterialSkin.Controls.MaterialLabel lblMarca;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private System.Windows.Forms.Panel pnlImagenCarga;
        private MaterialSkin.Controls.MaterialLabel lblImagen;
        private MaterialSkin.Controls.MaterialTextBox2 txtUrlImagen;
        private MaterialSkin.Controls.MaterialLabel lblUrlImagen;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.Panel pnlPixtureCarga;
        private System.Windows.Forms.PictureBox pxbImagenCarga;
    }
}