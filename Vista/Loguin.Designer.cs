namespace Vista
{
    partial class Loguin
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAceptarLoguin = new MaterialSkin.Controls.MaterialButton();
            this.pnlButonIngresar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlButonIngresar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel1.Location = new System.Drawing.Point(137, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(288, 72);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Bienvenido";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Ingrese su nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(106, 243);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(662, 50);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // btnAceptarLoguin
            // 
            this.btnAceptarLoguin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarLoguin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarLoguin.Depth = 0;
            this.btnAceptarLoguin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptarLoguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLoguin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarLoguin.HighEmphasis = true;
            this.btnAceptarLoguin.Icon = null;
            this.btnAceptarLoguin.Location = new System.Drawing.Point(0, 0);
            this.btnAceptarLoguin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarLoguin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarLoguin.Name = "btnAceptarLoguin";
            this.btnAceptarLoguin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarLoguin.Size = new System.Drawing.Size(662, 56);
            this.btnAceptarLoguin.TabIndex = 3;
            this.btnAceptarLoguin.Text = "Continuar";
            this.btnAceptarLoguin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarLoguin.UseAccentColor = false;
            this.btnAceptarLoguin.UseVisualStyleBackColor = true;
            this.btnAceptarLoguin.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pnlButonIngresar
            // 
            this.pnlButonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlButonIngresar.Controls.Add(this.panel2);
            this.pnlButonIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButonIngresar.Location = new System.Drawing.Point(3, 334);
            this.pnlButonIngresar.Name = "pnlButonIngresar";
            this.pnlButonIngresar.Size = new System.Drawing.Size(879, 59);
            this.pnlButonIngresar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAceptarLoguin);
            this.panel2.Location = new System.Drawing.Point(103, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 56);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 49);
            this.panel1.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(171, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(186, 14);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Ingrese su nombre para comenzar";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Location = new System.Drawing.Point(106, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 146);
            this.panel3.TabIndex = 7;
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(885, 445);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnlButonIngresar);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Loguin";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.pnlButonIngresar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnAceptarLoguin;
        private System.Windows.Forms.Panel pnlButonIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel3;
    }
}