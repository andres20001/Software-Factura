using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Seguimiento
{
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();  
            Size = new Size(1204, 515);
        }

        private Boolean Editarse = false;
        private string Idcategoria;

        E_CATEGORIA ObjEntidad = new E_CATEGORIA();
        N_CATEGORIA ObjNegocio = new N_CATEGORIA();

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ModificarTabla()
        {
            TABLA_USUARIOS.Columns[0].Visible = false;
            TABLA_USUARIOS.Columns[1].Visible = false;
            TABLA_USUARIOS.Columns[2].Visible = false;
            TABLA_USUARIOS.Columns[3].Visible = false;
            TABLA_USUARIOS.Columns[4].Visible = false;
            TABLA_USUARIOS.Columns[5].Visible = false;
            TABLA_USUARIOS.Columns[6].Visible = false;
            TABLA_USUARIOS.Columns[7].Visible = false;
            TABLA_USUARIOS.Columns[8].Visible = false;
            TABLA_USUARIOS.Columns[9].Width = 50;
            TABLA_USUARIOS.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            TABLA_USUARIOS.Columns[10].Width = 50;
            TABLA_USUARIOS.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            TABLA_USUARIOS.Columns[11].Width = 50;
            TABLA_USUARIOS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            TABLA_USUARIOS.Columns[11].DefaultCellStyle.Format = "#,#";
            //TABLA_USUARIOS.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            TABLA_USUARIOS.Columns[12].Visible = false;
            TABLA_USUARIOS.Columns[13].Width = 50;
            TABLA_USUARIOS.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            TABLA_USUARIOS.Columns[14].Visible = false;
        }

        public void MOSTRAR_BUSCAR_TABLA(string Buscar)
        {
            N_CATEGORIA ObjetoNegocio = new N_CATEGORIA();
            TABLA_USUARIOS.DataSource = ObjetoNegocio.ListandoUsuario(Buscar);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA(Txt_Buscar.Text);
        }

        public void LimpiarCajas()
        {
            Editarse = false;
            TXT_EDAD.Text = "";
            TXT_NOMBRE.Text = "";
            TXT_USUARIO.Text = "";
            TXT_PASSWORD.Text = "";
            TXT_TOPE_MAXIMO.Text = "";
            TXT_EDAD.Focus();
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            if (TABLA_USUARIOS.SelectedRows.Count > 0)
            {
                Editarse = true;
                Idcategoria = TABLA_USUARIOS.CurrentRow.Cells["IDCATEGORIA"].Value.ToString();
                TXT_EDAD.Text = TABLA_USUARIOS.CurrentRow.Cells["EDAD"].Value.ToString();
                TXT_NOMBRE.Text = TABLA_USUARIOS.CurrentRow.Cells["NOMBRE"].Value.ToString();
                TXT_USUARIO.Text = TABLA_USUARIOS.CurrentRow.Cells["USUARIO"].Value.ToString();
                TXT_PASSWORD.Text = TABLA_USUARIOS.CurrentRow.Cells["PASSWORD"].Value.ToString();
                TXT_TOPE_MAXIMO.Text = TABLA_USUARIOS.CurrentRow.Cells["TOPE_MAXIMO"].Value.ToString();
            }
            else
            {
                ERROR.ERROR_M("POR FAVOR SELECCIONE LA COLUMNA");
            }
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA("");
            ModificarTabla();

            Boolean Resultado = ObjNegocio.Verificando_Admin(LOGIN.USUARIO, LOGIN.CODIGO);

            if (Resultado.Equals(true))
            {
                BTN_EDITAR.Enabled = true;
                BTN_ELIMINAR.Enabled = true;
            }
            else
            {
                BTN_EDITAR.Enabled = false;
                BTN_ELIMINAR.Enabled = false;
            }

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    ObjEntidad.NOMBRE = TXT_NOMBRE.Text;
                    ObjEntidad.USUARIO = TXT_USUARIO.Text;
                    ObjEntidad.PASSWORD = TXT_PASSWORD.Text;
                    ObjEntidad.EDAD = Convert.ToInt32(TXT_EDAD.Text);
                    ObjEntidad.TOPE_MAXIMO = Convert.ToInt32(TXT_TOPE_MAXIMO.Text);

                    Boolean Resultado = ObjNegocio.Validando(ObjEntidad);

                    if (Resultado.Equals(false))
                    {
                        ObjNegocio.InsertarUsuario(ObjEntidad);

                        //NOTIFICACION.CONFIRMAR_NOTIFICACION("GUARDADO");
                        MOSTRAR_BUSCAR_TABLA("");
                        LimpiarCajas();
                    }
                    else
                    {
                        ERROR.ERROR_M("USUARIO O PASSWORD EXISTENTE POR FAVOR OTRO");
                    }

                }
                catch (Exception EX)
                {
                    //ERROR.ERROR_M("ERROR" + EX);
                    MessageBox.Show("" + EX);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    ObjEntidad.IDCATEGORIA = Convert.ToInt32(Idcategoria);
                    ObjEntidad.NOMBRE = TXT_NOMBRE.Text;
                    ObjEntidad.USUARIO = TXT_USUARIO.Text;
                    ObjEntidad.PASSWORD = TXT_PASSWORD.Text;
                    ObjEntidad.EDAD = Convert.ToInt32(TXT_EDAD.Text);
                    ObjEntidad.TOPE_MAXIMO = Convert.ToInt32(TXT_TOPE_MAXIMO.Text);

                    ObjNegocio.Editar_Usuario(ObjEntidad);

                    //NOTIFICACION.CONFIRMAR_NOTIFICACION("EDITADO");
                    MOSTRAR_BUSCAR_TABLA("");
                    LimpiarCajas();
                    Editarse = false;

                }
                catch (Exception ex)
                {
                    //ERROR.ERROR_M("ERROR" + ex);
                    MessageBox.Show("error" + ex);
                }
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = new DialogResult();
                NOTIFICACION_AVISO frm = new NOTIFICACION_AVISO("¿ESTA SEGURO DE ELIMINAR LA FACTURA?");
                resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    ObjEntidad.IDCATEGORIA = Convert.ToInt32(TABLA_USUARIOS.CurrentRow.Cells["IDCATEGORIA"].Value.ToString());
                    String Identificacion = ObjEntidad.USUARIO = TABLA_USUARIOS.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    ObjNegocio.Eliminar_Usuario(ObjEntidad, Identificacion, LOGIN.CODIGO);

                    //MessageBox.Show("SE ELIMINO FACTURA");
                    //NOTIFICACION.CONFIRMAR_NOTIFICACION("ELIMINADO");
                    MOSTRAR_BUSCAR_TABLA("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }
    }
}
