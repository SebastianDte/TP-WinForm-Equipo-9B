namespace Vista
{
    partial class frmCategorias
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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.libListaCategorias = new System.Windows.Forms.ListBox();
            this.txtbAgregar = new System.Windows.Forms.TextBox();
            this.txtbFiltroRapido = new System.Windows.Forms.TextBox();
            this.lbFiltroRapido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(75, 279);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "&Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.Beige;
            this.btnEliminar.Location = new System.Drawing.Point(201, 231);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // libListaCategorias
            // 
            this.libListaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libListaCategorias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.libListaCategorias.FormattingEnabled = true;
            this.libListaCategorias.Location = new System.Drawing.Point(172, 78);
            this.libListaCategorias.Name = "libListaCategorias";
            this.libListaCategorias.ScrollAlwaysVisible = true;
            this.libListaCategorias.Size = new System.Drawing.Size(165, 134);
            this.libListaCategorias.TabIndex = 3;
            // 
            // txtbAgregar
            // 
            this.txtbAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbAgregar.Location = new System.Drawing.Point(172, 282);
            this.txtbAgregar.Name = "txtbAgregar";
            this.txtbAgregar.Size = new System.Drawing.Size(225, 20);
            this.txtbAgregar.TabIndex = 2;
            // 
            // txtbFiltroRapido
            // 
            this.txtbFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbFiltroRapido.Location = new System.Drawing.Point(172, 43);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(225, 20);
            this.txtbFiltroRapido.TabIndex = 4;
            // 
            // lbFiltroRapido
            // 
            this.lbFiltroRapido.AutoSize = true;
            this.lbFiltroRapido.Location = new System.Drawing.Point(90, 46);
            this.lbFiltroRapido.Name = "lbFiltroRapido";
            this.lbFiltroRapido.Size = new System.Drawing.Size(66, 13);
            this.lbFiltroRapido.TabIndex = 6;
            this.lbFiltroRapido.Text = "Filtro Rápido";
            // 
            // frmCategorias
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(433, 453);
            this.Controls.Add(this.lbFiltroRapido);
            this.Controls.Add(this.txtbFiltroRapido);
            this.Controls.Add(this.txtbAgregar);
            this.Controls.Add(this.libListaCategorias);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarCategoria);
            this.MinimumSize = new System.Drawing.Size(449, 492);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox libListaCategorias;
        private System.Windows.Forms.TextBox txtbAgregar;
        private System.Windows.Forms.TextBox txtbFiltroRapido;
        private System.Windows.Forms.Label lbFiltroRapido;
    }
}