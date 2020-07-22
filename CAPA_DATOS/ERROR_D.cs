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
    public partial class ERROR_D : Form
    {
        public ERROR_D(string Mensaje)
        {
            InitializeComponent();
            LB_ERROR.Text = Mensaje;
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ERROR_D_Load(object sender, EventArgs e)
        {
            EFECTO_N.ShowAsyc(this);
        }

        public static void ERROR_M(String Mensaje)
        {
            ERROR_D nf = new ERROR_D(Mensaje);
            nf.ShowDialog();
        }
    }
}
