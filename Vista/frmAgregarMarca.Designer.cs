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
            this.lbDescripcionNuevaMarca = new System.Windows.Forms.Label();
            this.btnAgregarNuevaMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNuevaMarca = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDescripcionNuevaMarca
            // 
            this.lbDescripcionNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescripcionNuevaMarca.AutoSize = true;
            this.lbDescripcionNuevaMarca.Location = new System.Drawing.Point(3, 153);
            this.lbDescripcionNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionNuevaMarca.Name = "lbDescripcionNuevaMarca";
            this.lbDescripcionNuevaMarca.Size = new System.Drawing.Size(79, 16);
            this.lbDescripcionNuevaMarca.TabIndex = 3;
            this.lbDescripcionNuevaMarca.Text = "Descripcion";
            // 
            // btnAgregarNuevaMarca
            // 
            this.btnAgregarNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarNuevaMarca.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarNuevaMarca.Location = new System.Drawing.Point(90, 195);
            this.btnAgregarNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarNuevaMarca.Name = "btnAgregarNuevaMarca";
            this.btnAgregarNuevaMarca.Size = new System.Drawing.Size(95, 28);
            this.btnAgregarNuevaMarca.TabIndex = 6;
            this.btnAgregarNuevaMarca.Text = "Agregar";
            this.btnAgregarNuevaMarca.UseVisualStyleBackColor = false;
            this.btnAgregarNuevaMarca.Click += new System.EventHandler(this.btnAgregarNuevaMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Beige;
            this.btnCancelar.Location = new System.Drawing.Point(410, 195);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbNuevaMarca
            // 
            this.lbNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNuevaMarca.AutoSize = true;
            this.lbNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaMarca.Location = new System.Drawing.Point(235, 80);
            this.lbNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNuevaMarca.Name = "lbNuevaMarca";
            this.lbNuevaMarca.Size = new System.Drawing.Size(108, 20);
            this.lbNuevaMarca.TabIndex = 1;
            this.lbNuevaMarca.Text = "Nueva Marca";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(90, 153);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(420, 22);
            this.txtbDescripcion.TabIndex = 9;
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(575, 288);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarNuevaMarca);
            this.Controls.Add(this.lbDescripcionNuevaMarca);
            this.Controls.Add(this.lbNuevaMarca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(593, 595);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDescripcionNuevaMarca;
        private System.Windows.Forms.Button btnAgregarNuevaMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNuevaMarca;
        private System.Windows.Forms.TextBox txtbDescripcion;
    }
}