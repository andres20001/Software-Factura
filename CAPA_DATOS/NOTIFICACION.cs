using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DATOS
{
    public partial class NOTIFICACION_ONE : Form
    {
        public NOTIFICACION_ONE(string Mensaje)
        {
            InitializeComponent();
            LB_MENSAJE.Text = Mensaje;
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NOTIFICACION_ONE_Load(object sender, EventArgs e)
        {
            EFECTO_N.ShowAsyc(this);
        }

        public static void CONFIRMAR_NOTIFICACION(String Mensaje)
        {
            NOTIFICACION_ONE nf = new NOTIFICACION_ONE(Mensaje);
            nf.ShowDialog();
        }
    }
}
