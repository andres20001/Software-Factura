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
    public partial class NOTIFICACION : Form
    {
        public NOTIFICACION(String Mensaje)
        {
            InitializeComponent();
            LB_MENSAJE.Text = Mensaje;
        }

        private void NOTIFICACION_Load(object sender, EventArgs e)
        {
            EFECTO_N.ShowAsyc(this);
        }

        public static void CONFIRMAR_NOTIFICACION(String Mensaje)
        {
            NOTIFICACION nf = new NOTIFICACION(Mensaje);
            nf.ShowDialog();
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
