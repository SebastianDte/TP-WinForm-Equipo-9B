namespace Vista
{
    partial class frmAgregarMarca
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
            this.lbNuevaMarca = new System.Windows.Forms.Label();
            this.lbNombreNuevaMarca = new System.Windows.Forms.Label();
            this.lbDescripcionNuevaMarca = new System.Windows.Forms.Label();
            this.txtNombreNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevaMarca = new System.Windows.Forms.Button();
            this.rtbDescripcionNuevaMarca = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNuevaMarca
            // 
            this.lbNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNuevaMarca.AutoSize = true;
            this.lbNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaMarca.Location = new System.Drawing.Point(177, 56);
            this.lbNuevaMarca.Name = "lbNuevaMarca";
            this.lbNuevaMarca.Size = new System.Drawing.Size(88, 16);
            this.lbNuevaMarca.TabIndex = 1;
            this.lbNuevaMarca.Text = "Nueva Marca";
            // 
            // lbNombreNuevaMarca
            // 
            this.lbNombreNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNombreNuevaMarca.AutoSize = true;
            this.lbNombreNuevaMarca.Location = new System.Drawing.Point(12, 89);
            this.lbNombreNuevaMarca.Name = "lbNombreNuevaMarca";
            this.lbNombreNuevaMarca.Size = new System.Drawing.Size(44, 13);
            this.lbNombreNuevaMarca.TabIndex = 2;
            this.lbNombreNuevaMarca.Text = "Nombre";
            // 
            // lbDescripcionNuevaMarca
            // 
            this.lbDescripcionNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescripcionNuevaMarca.AutoSize = true;
            this.lbDescripcionNuevaMarca.Location = new System.Drawing.Point(2, 124);
            this.lbDescripcionNuevaMarca.Name = "lbDescripcionNuevaMarca";
            this.lbDescripcionNuevaMarca.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcionNuevaMarca.TabIndex = 3;
            this.lbDescripcionNuevaMarca.Text = "Descripcion";
            // 
            // txtNombreNuevaMarca
            // 
            this.txtNombreNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreNuevaMarca.Location = new System.Drawing.Point(66, 86);
            this.txtNombreNuevaMarca.Name = "txtNombreNuevaMarca";
            this.txtNombreNuevaMarca.Size = new System.Drawing.Size(316, 20);
            this.txtNombreNuevaMarca.TabIndex = 4;
            // 
            // btnAgregarNuevaMarca
            // 
            this.btnAgregarNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarNuevaMarca.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarNuevaMarca.Location = new System.Drawing.Point(66, 300);
            this.btnAgregarNuevaMarca.Name = "btnAgregarNuevaMarca";
            this.btnAgregarNuevaMarca.Size = new System.Drawing.Size(71, 23);
            this.btnAgregarNuevaMarca.TabIndex = 6;
            this.btnAgregarNuevaMarca.Text = "Agregar";
            this.btnAgregarNuevaMarca.UseVisualStyleBackColor = false;
            // 
            // rtbDescripcionNuevaMarca
            // 
            this.rtbDescripcionNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescripcionNuevaMarca.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbDescripcionNuevaMarca.Location = new System.Drawing.Point(66, 124);
            this.rtbDescripcionNuevaMarca.Name = "rtbDescripcionNuevaMarca";
            this.rtbDescripcionNuevaMarca.Size = new System.Drawing.Size(316, 170);
            this.rtbDescripcionNuevaMarca.TabIndex = 7;
            this.rtbDescripcionNuevaMarca.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Beige;
            this.btnCancelar.Location = new System.Drawing.Point(307, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(433, 453);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rtbDescripcionNuevaMarca);
            this.Controls.Add(this.btnAgregarNuevaMarca);
            this.Controls.Add(this.txtNombreNuevaMarca);
            this.Controls.Add(this.lbDescripcionNuevaMarca);
            this.Controls.Add(this.lbNombreNuevaMarca);
            this.Controls.Add(this.lbNuevaMarca);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 492);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNuevaMarca;
        private System.Windows.Forms.Label lbNombreNuevaMarca;
        private System.Windows.Forms.Label lbDescripcionNuevaMarca;
        private System.Windows.Forms.TextBox txtNombreNuevaMarca;
        private System.Windows.Forms.Button btnAgregarNuevaMarca;
        private System.Windows.Forms.RichTextBox rtbDescripcionNuevaMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}