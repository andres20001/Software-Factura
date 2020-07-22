using CAPA_NEGOCIO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Software_Seguimiento
{
    public partial class PANEL_PRINCIPAL : Form
    {
        public PANEL_PRINCIPAL()
        {
            InitializeComponent();
            Size = new Size(1204, 515);
            lineShape1.X1 = 7;
            lineShape1.X2 = 239;
            lineShape1.Y1 = 431;
            lineShape1.Y2 = 431;

            pictureBox5.Location = new Point(4, 436);
        }

        public string USUARIO_PANEL;
        public int CODIGO_PANEL;
        public int CEDULA_PANEL;

        //QUITAR EL COLOR SELECCIONADO
        private void QUITAR_COLOR(object senser, FormClosedEventArgs e)
        {
            if (Application.OpenForms["USUARIOS"] == null)
            {
                BTN_USUARIOS.BackColor = Color.FromArgb(0, 122, 204);
            }
            if (Application.OpenForms["FACTURAS"] == null)
            {
                BTN_USUARIOS.BackColor = Color.FromArgb(0, 122, 204);
            }
            if (Application.OpenForms["REPORTES_FACURAS"] == null)
            {
                BTN_USUARIOS.BackColor = Color.FromArgb(0, 122, 204);
            }
        }

        //PARA TENER MOVIMIENTO EL PANEL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaoture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SedMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        //PARA NAVEGAR EN EL PRINCIPAL
        private Form ACTIVO = null;
        private void ABRIR_CONTENEDOR(Form FORMULARIO_HIJO)
        {
            if (ACTIVO != null)
                ACTIVO.Close();
            ACTIVO = FORMULARIO_HIJO;

            FORMULARIO_HIJO.TopLevel = false;
            FORMULARIO_HIJO.FormBorderStyle = FormBorderStyle.None;
            FORMULARIO_HIJO.Dock = DockStyle.Fill;

            PANEL_HIJO.Controls.Add(FORMULARIO_HIJO);
            PANEL_HIJO.Tag = FORMULARIO_HIJO;
            FORMULARIO_HIJO.BringToFront();
            FORMULARIO_HIJO.Show();
        }

        //QUITAR EL COLOR Y QUEDAR EN UN COLOR AL ABRIR FORMULARIO
        private void BTN_USUARIOS_Click(object sender, EventArgs e)
        {

            ABRIR_CONTENEDOR(new USUARIOS());

            //BTN_USUARIOS.BackColor = Color.FromArgb(0, 99, 177);
            //IMG_USUARIOS.BackColor = Color.FromArgb(0, 99, 177);
            Size = new Size(1204, 515);

            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 239;
            this.lineShape1.Y1 = 431;
            this.lineShape1.Y2 = 431;

            this.pictureBox5.Location = new Point(4, 436);
        }

        private void BTN_FACURAS_Click(object sender, EventArgs e)
        {
            ABRIR_CONTENEDOR(new FACTURAS());

            //BTN_FACURAS.BackColor = Color.FromArgb(0, 99, 177);
            //IMG_FACTURA.BackColor = Color.FromArgb(0, 99, 177);
            Size = new Size(1204, 515);
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 239;
            this.lineShape1.Y1 = 431;
            this.lineShape1.Y2 = 431;

            this.pictureBox5.Location = new Point(4, 436);

            PANEL_PRINCIPAL PM = new PANEL_PRINCIPAL();
            PM.Refresh();
        }

        private void BTN_FACURAS_REPORTES_Click(object sender, EventArgs e)
        {

            ABRIR_CONTENEDOR(new FACTURAS_INFO());
            //BTN_FACURAS_REPORTES.BackColor = Color.FromArgb(0, 99, 177);
            //IMG_FACTURAS.BackColor = Color.FromArgb(0, 99, 177);

            Size = new Size(1300, 570);

            this.pictureBox5.Location = new Point(1, 499);
            this.lineShape1.X1 = 3;
            this.lineShape1.X2 = 235;
            this.lineShape1.Y1 = 494;
            this.lineShape1.Y2 = 494;

            this.panel2.Size = new Size(250, 545);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            NOTIFICACION_AVISO frm = new NOTIFICACION_AVISO("¿ESTA SEGURO DE SALIR?");
            resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //PARA MAXIMIZAR LA PESTAÑA
        private void TXT_MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            this.Hide();
            lg.ShowDialog();
        }

        //PANEL CON MOVIMIENTO
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PANEL_PRINCIPAL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PANEL_HIJO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaoture();
            SedMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PANEL_HIJO_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ModificarTabla()
        {
            TABLA_FACTURA_REPORTE.Columns[0].Width = 50;
            TABLA_FACTURA_REPORTE.Columns[3].Width = 150;
            TABLA_FACTURA_REPORTE.Columns[5].Width = 80;

            TABLA_FACTURA_REPORTE.Columns[1].Width = 100;
            TABLA_FACTURA_REPORTE.Columns[2].Width = 140;
            TABLA_FACTURA_REPORTE.Columns[4].Width = 170;
            TABLA_FACTURA_REPORTE.Columns[6].Width = 210;
            TABLA_FACTURA_REPORTE.Columns[6].DefaultCellStyle.Format = "#,#";
            TABLA_FACTURA_REPORTE.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            TABLA_FACTURA_REPORTE.ClearSelection();
        }

        public void MOSTRAR_BUSCAR_TABLA(string Buscar)
        {
            N_CATEGORIA ObjetoNegocio = new N_CATEGORIA();
            TABLA_FACTURA_REPORTE.DataSource = ObjetoNegocio.FACTURAS_MAX_DIAS(Buscar);
        }

        private void TXT_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA(TXT_BUSCAR.Text);
        }

        private void PANEL_HIJO_Paint_1(object sender, PaintEventArgs e)
        {


            MOSTRAR_BUSCAR_TABLA("");
            ModificarTabla();
        }

        private void CAMBIAR_COLOR(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.TABLA_FACTURA_REPORTE.Columns[e.ColumnIndex].Name == "DIAS_PEN")
            {
                if (Convert.ToInt32(e.Value) <= 30)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToInt32(e.Value) <= 15)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(e.Value) <= 0)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void PANEL_DATOS_ANTERIOR_Paint(object sender, PaintEventArgs e)
        { //CODIGO POR ACTUALIZAR

            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS WHERE IDCATEGORIA = " + LOGIN.CODIGO, conexion);
            SqlDataReader Trallendo_Datos;
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            Trallendo_Datos = cmd.ExecuteReader();

            if (Trallendo_Datos.Read())
            {
                TXT_USUARIO_P.Text = Trallendo_Datos.GetString(3);
                TXT_ID_P.Text = Trallendo_Datos.GetString(1);
                TXT_EDAD_P.Text = Convert.ToString(Trallendo_Datos.GetInt32(5));

            }
            conexion.Close();
        }

        public void Validacion_Cambio(string Usuario, int Codigo)
        {
            if (TXT_USUARIO_P.Text == Usuario)
            {
                MessageBox.Show("EL USUARIO ES EL MISMO");
            }
            else
            {
                Usuario = TXT_USUARIO_P.Text;
            }
        }
    }
}
