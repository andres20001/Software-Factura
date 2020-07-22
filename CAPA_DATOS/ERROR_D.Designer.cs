namespace CAPA_DATOS
{
    partial class ERROR_D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERROR_D));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.LB_ERROR = new System.Windows.Forms.Label();
            this.LB_MENSAJE = new System.Windows.Forms.Label();
            this.EFECTO_N = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 154);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.BackColor = System.Drawing.Color.Red;
            this.BTN_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(39, 313);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(189, 52);
            this.BTN_ACEPTAR.TabIndex = 10;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = false;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // LB_ERROR
            // 
            this.LB_ERROR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ERROR.ForeColor = System.Drawing.Color.Gray;
            this.LB_ERROR.Location = new System.Drawing.Point(3, 211);
            this.LB_ERROR.Name = "LB_ERROR";
            this.LB_ERROR.Size = new System.Drawing.Size(253, 95);
            this.LB_ERROR.TabIndex = 9;
            this.LB_ERROR.Text = "Accion completada correctamente, puedes seguir utilizando el sistema sin ningun p" +
    "roblema";
            this.LB_ERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_MENSAJE
            // 
            this.LB_MENSAJE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MENSAJE.Location = new System.Drawing.Point(3, 167);
            this.LB_MENSAJE.Name = "LB_MENSAJE";
            this.LB_MENSAJE.Size = new System.Drawing.Size(253, 37);
            this.LB_MENSAJE.TabIndex = 8;
            this.LB_MENSAJE.Text = "ERROR";
            this.LB_MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EFECTO_N
            // 
            this.EFECTO_N.Delay = 0;
            // 
            // ERROR_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 379);
            this.Controls.Add(this.BTN_ACEPTAR);
            this.Controls.Add(this.LB_ERROR);
            this.Controls.Add(this.LB_MENSAJE);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ERROR_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ERROR_D";
            this.Load += new System.EventHandler(this.ERROR_D_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_ACEPTAR;
        private System.Windows.Forms.Label LB_ERROR;
        private System.Windows.Forms.Label LB_MENSAJE;
        private Bunifu.Framework.UI.BunifuFormFadeTransition EFECTO_N;
    }
}