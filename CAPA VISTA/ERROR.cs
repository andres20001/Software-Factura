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
    public partial class ERROR : Form
    {
        public ERROR(string Mensaje)
        {
            InitializeComponent();
            LB_ERROR.Text = Mensaje;
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ERROR_Load(object sender, EventArgs e)
        {
            EFECTO_N.ShowAsyc(this);
        }
        public static void ERROR_M (String Mensaje)
        {
            ERROR nf = new ERROR(Mensaje);
            nf.ShowDialog();
        }

    }
}
