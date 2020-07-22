namespace CAPA_DATOS
{
    partial class NOTIFICACION_ONE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOTIFICACION_ONE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_MENSAJE = new System.Windows.Forms.Label();
            this.EFECTO_N = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 230);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.BTN_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(37, 380);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(189, 52);
            this.BTN_ACEPTAR.TabIndex = 7;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = false;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 95);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accion completada correctamente, puedes seguir utilizando el sistema sin ningun p" +
    "roblema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_MENSAJE
            // 
            this.LB_MENSAJE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MENSAJE.Location = new System.Drawing.Point(9, 230);
            this.LB_MENSAJE.Name = "LB_MENSAJE";
            this.LB_MENSAJE.Size = new System.Drawing.Size(253, 50);
            this.LB_MENSAJE.TabIndex = 5;
            this.LB_MENSAJE.Text = "MENSAJE";
            this.LB_MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EFECTO_N
            // 
            this.EFECTO_N.Delay = 0;
            // 
            // NOTIFICACION_ONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_ACEPTAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_MENSAJE);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NOTIFICACION_ONE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NOTIFICACION";
            this.Load += new System.EventHandler(this.NOTIFICACION_ONE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_ACEPTAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_MENSAJE;
        private Bunifu.Framework.UI.BunifuFormFadeTransition EFECTO_N;
    }
}