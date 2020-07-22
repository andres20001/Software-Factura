namespace Software_Seguimiento
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ACCEDER = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_MINIMIZAR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(441, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿has olvidado contraseña?";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_USUARIO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USUARIO.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_USUARIO.Location = new System.Drawing.Point(285, 79);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(442, 20);
            this.TXT_USUARIO.TabIndex = 1;
            this.TXT_USUARIO.Text = "USUARIO";
            this.TXT_USUARIO.Enter += new System.EventHandler(this.TXT_USUARIO_Enter);
            this.TXT_USUARIO.Leave += new System.EventHandler(this.TXT_USUARIO_Leave);
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_PASSWORD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PASSWORD.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_PASSWORD.Location = new System.Drawing.Point(288, 151);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.Size = new System.Drawing.Size(455, 20);
            this.TXT_PASSWORD.TabIndex = 2;
            this.TXT_PASSWORD.Text = "CONTRASEÑA";
            this.TXT_PASSWORD.Enter += new System.EventHandler(this.TXT_PASSWORD_Enter);
            this.TXT_PASSWORD.Leave += new System.EventHandler(this.TXT_PASSWORD_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(475, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // BTN_ACCEDER
            // 
            this.BTN_ACCEDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_ACCEDER.FlatAppearance.BorderSize = 0;
            this.BTN_ACCEDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_ACCEDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ACCEDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACCEDER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACCEDER.ForeColor = System.Drawing.Color.LightGray;
            this.BTN_ACCEDER.Location = new System.Drawing.Point(288, 237);
            this.BTN_ACCEDER.Name = "BTN_ACCEDER";
            this.BTN_ACCEDER.Size = new System.Drawing.Size(442, 40);
            this.BTN_ACCEDER.TabIndex = 4;
            this.BTN_ACCEDER.Text = "ACCEDER";
            this.BTN_ACCEDER.UseVisualStyleBackColor = false;
            this.BTN_ACCEDER.Click += new System.EventHandler(this.BTN_ACCEDER_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 291;
            this.lineShape2.X2 = 742;
            this.lineShape2.Y1 = 172;
            this.lineShape2.Y2 = 172;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 285;
            this.lineShape1.X2 = 736;
            this.lineShape1.Y1 = 101;
            this.lineShape1.Y2 = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(750, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // TXT_MINIMIZAR
            // 
            this.TXT_MINIMIZAR.AutoSize = true;
            this.TXT_MINIMIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXT_MINIMIZAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MINIMIZAR.ForeColor = System.Drawing.Color.White;
            this.TXT_MINIMIZAR.Location = new System.Drawing.Point(727, 7);
            this.TXT_MINIMIZAR.Name = "TXT_MINIMIZAR";
            this.TXT_MINIMIZAR.Size = new System.Drawing.Size(26, 21);
            this.TXT_MINIMIZAR.TabIndex = 11;
            this.TXT_MINIMIZAR.Text = "__";
            this.TXT_MINIMIZAR.Click += new System.EventHandler(this.TXT_MINIMIZAR_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.TXT_MINIMIZAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_ACCEDER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_PASSWORD);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LOGIN_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ACCEDER;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TXT_MINIMIZAR;
    }
}