using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Seguimiento
{
    public partial class NOTIFICACION_AVISO : Form
    {
        public NOTIFICACION_AVISO(String Mensaje)
        {
            InitializeComponent();
            LB_MENSAJE.Text = Mensaje;
        }

        private void NOTIFICACION_ERROR_Load(object sender, EventArgs e)
        {
            EFECTO_N.ShowAsyc(this);
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
