using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using CAPA_NEGOCIO;
using System.Configuration;

namespace Software_Seguimiento
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaoture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SedMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static int CODIGO;
        public static string USUARIO;

        private void TXT_USUARIO_Enter(object sender, EventArgs e)
        {
            if (TXT_USUARIO.Text == "USUARIO")
            {
                TXT_USUARIO.Text = "";
                TXT_USUARIO.ForeColor = Color.LightGray;
            }
        }

        private void TXT_USUARIO_Leave(object sender, EventArgs e)
        {
            if (TXT_USUARIO.Text == "")
            {
                TXT_USUARIO.Text = "USUARIO";
                TXT_USUARIO.ForeColor = Color.DimGray;
            }
        }

        private void TXT_PASSWORD_Enter(object sender, EventArgs e)
        {
            if (TXT_PASSWORD.Text == "CONTRASEÑA")
            {
                TXT_PASSWORD.Text = "";
                TXT_PASSWORD.ForeColor = Color.LightGray;
                TXT_PASSWORD.UseSystemPasswordChar = true;
            }
        }

        private void TXT_PASSWORD_Leave(object sender, EventArgs e)
        {
            if (TXT_PASSWORD.Text == "")
            {
                TXT_PASSWORD.Text = "CONTRASEÑA";
                TXT_PASSWORD.ForeColor = Color.LightGray;
                TXT_PASSWORD.UseSystemPasswordChar = false;
            }
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TXT_MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            NOTIFICACION_AVISO frm = new NOTIFICACION_AVISO("¿ESTAS SEGURO DE SALIR?");
            resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }                
        }

        private void BTN_ACCEDER_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND PASSWORD = @PASSWORD ", conexion);
            SqlDataReader Trallendo_Datos;
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            cmd.Parameters.AddWithValue("@USUARIO", TXT_USUARIO.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", TXT_PASSWORD.Text);         

            Trallendo_Datos = cmd.ExecuteReader();

            if(Trallendo_Datos.Read())
            {
                 CODIGO = Trallendo_Datos.GetInt32(0);
                 USUARIO = Trallendo_Datos.GetString(3);

                PANEL_PRINCIPAL PM = new PANEL_PRINCIPAL();
                 NOTIFICACION.CONFIRMAR_NOTIFICACION("USUARIO CORRECTO..");
                 this.Hide();
                 PM.Show();

            }
            else
            {
                  ERROR.ERROR_M("CONTRASEÑA O USUARIO INCORRECTO");
            }
            conexion.Close();

            conexion.Open();
            SqlCommand Consulta = new SqlCommand("ACT_DATOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Consulta.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
