namespace Software_Seguimiento
{
    partial class NOTIFICACION_AVISO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOTIFICACION_AVISO));
            this.EFECTO_N = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_MENSAJE = new System.Windows.Forms.Label();
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EFECTO_N
            // 
            this.EFECTO_N.Delay = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 184);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVISO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.BTN_ACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(13, 348);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(115, 52);
            this.BTN_ACEPTAR.TabIndex = 7;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = false;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = "Piensa bien la opcion que va elegir, elija con cuidado...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_MENSAJE
            // 
            this.LB_MENSAJE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MENSAJE.Location = new System.Drawing.Point(9, 192);
            this.LB_MENSAJE.Name = "LB_MENSAJE";
            this.LB_MENSAJE.Size = new System.Drawing.Size(253, 77);
            this.LB_MENSAJE.TabIndex = 5;
            this.LB_MENSAJE.Text = "MENSAJE";
            this.LB_MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Location = new System.Drawing.Point(144, 348);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(115, 52);
            this.BTN_CANCELAR.TabIndex = 8;
            this.BTN_CANCELAR.Text = "CANCELAR";
            this.BTN_CANCELAR.UseVisualStyleBackColor = false;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // NOTIFICACION_AVISO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 412);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_ACEPTAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_MENSAJE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NOTIFICACION_AVISO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NOTIFICACION_ERROR";
            this.Load += new System.EventHandler(this.NOTIFICACION_ERROR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition EFECTO_N;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_ACEPTAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_MENSAJE;
        private System.Windows.Forms.Button BTN_CANCELAR;
        private System.Windows.Forms.Label label1;
    }
}