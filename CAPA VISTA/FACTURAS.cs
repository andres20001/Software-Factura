using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Seguimiento
{
    public partial class FACTURAS : Form
    {
        private string Idcategoria;
        private Boolean Editarse = false;

        public static string Codigo;
        public static string Usuario;
        public static string Cedula;

        E_CATEGORIA ObjEntidad = new E_CATEGORIA();
        N_CATEGORIA ObjNegocio = new N_CATEGORIA();

        public FACTURAS()
        {
            InitializeComponent();
            Size = new Size(1204, 515);
            ObjNegocio.LLENAR_COMBOBOX(S_Usuario);
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FACTURAS_Load(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA("");
            ModificarTabla();
        }

        public void ModificarTabla()
        {
            REPORTE_FACTURA.Columns[0].Visible = false;
            REPORTE_FACTURA.Columns[1].Width = 30;
            REPORTE_FACTURA.Columns[2].Width = 15;
            REPORTE_FACTURA.Columns[3].Visible = false;
            REPORTE_FACTURA.Columns[4].Width = 30;
            REPORTE_FACTURA.Columns[5].Visible = false;
            REPORTE_FACTURA.Columns[6].Width = 30;
            REPORTE_FACTURA.Columns[6].DefaultCellStyle.Format = "#,#";
            REPORTE_FACTURA.Columns[7].Visible = false;
            REPORTE_FACTURA.Columns[8].Visible = false;
            REPORTE_FACTURA.Columns[9].Visible = false;
            REPORTE_FACTURA.Columns[10].Visible = false;
            REPORTE_FACTURA.Columns[11].Visible = false;
            REPORTE_FACTURA.Columns[12].Visible = false;
            REPORTE_FACTURA.Columns[13].Width = 50;
            REPORTE_FACTURA.Columns[14].Visible = false;
            //dataGridView1.Columns[15].Width = 100;

            REPORTE_FACTURA.ClearSelection();
        }

        public void MOSTRAR_BUSCAR_TABLA(string Buscar)
        {
            N_CATEGORIA ObjetoNegocio = new N_CATEGORIA();
            REPORTE_FACTURA.DataSource = ObjetoNegocio.ListandoFactura(Buscar);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA(Txt_Buscar.Text);
        }

        public void LimpiarCajas()
        {
            Editarse = false;
            TXT_NUMERO_FACTURA.Text = "";
            TXT_NOMBRE_PROVEEDOR.Text = "";
            TXT_TOTAL.Text = "";
            TXT_NOMBRE_PROVEEDOR.Focus();
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            //N_USUARIO.Text = ObjNegocio.DATOS_P(S_Usuario.Text);
            LimpiarCajas();
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            if (REPORTE_FACTURA.SelectedRows.Count > 0)
            {
                Editarse = true;
                Idcategoria = REPORTE_FACTURA.CurrentRow.Cells[0].Value.ToString();
                TXT_NOMBRE_PROVEEDOR.Text = REPORTE_FACTURA.CurrentRow.Cells[1].Value.ToString();
                TXT_NUMERO_FACTURA.Text = REPORTE_FACTURA.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(REPORTE_FACTURA.CurrentRow.Cells[3].Value.ToString());
                dateTimePicker2.Value = Convert.ToDateTime(REPORTE_FACTURA.CurrentRow.Cells[4].Value.ToString());
                TXT_TOTAL.Text = REPORTE_FACTURA.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                ERROR.ERROR_M("POR FAVOR SELECCIONE LA COLUMNA");
            }
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    ObjEntidad.NOMBRE_PROVEEDOR = TXT_NOMBRE_PROVEEDOR.Text;
                    ObjEntidad.NUMORO_FACTURA = Convert.ToInt32(TXT_NUMERO_FACTURA.Text);
                    ObjEntidad.FECHA_INICIO = Convert.ToDateTime(dateTimePicker1.Value);
                    ObjEntidad.FECHA_FINAL = Convert.ToDateTime(dateTimePicker2.Value);
                    ObjEntidad.PRECIO_TOTAL = Convert.ToInt32(TXT_TOTAL.Text);

                    Boolean Resultado = ObjNegocio.VALIDACION_DE_TOPE(LOGIN.CODIGO, ObjEntidad);

                    if (Resultado.Equals(true))
                    {
                        ObjNegocio.InsertarFcatura(ObjEntidad, LOGIN.CODIGO, LOGIN.USUARIO);

                        NOTIFICACION.CONFIRMAR_NOTIFICACION("GUARDADO");
                        MOSTRAR_BUSCAR_TABLA("");
                        LimpiarCajas();
                    }
                    else
                    {
                        ERROR.ERROR_M("SU PRECIO TOTAL DEBE SER MAS MENOR");
                        MOSTRAR_BUSCAR_TABLA("");
                        LimpiarCajas();
                    }

                }
                catch (Exception EX)
                {
                    MessageBox.Show("NO SE PUEDE GUARDAR" + EX);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    ObjEntidad.ID = Convert.ToInt32(Idcategoria);
                    ObjEntidad.NOMBRE_PROVEEDOR = TXT_NOMBRE_PROVEEDOR.Text;
                    ObjEntidad.NUMORO_FACTURA = Convert.ToInt32(TXT_NUMERO_FACTURA.Text);
                    ObjEntidad.FECHA_INICIO = Convert.ToDateTime(dateTimePicker1.Value);
                    ObjEntidad.FECHA_FINAL = Convert.ToDateTime(dateTimePicker2.Value);
                    ObjEntidad.PRECIO_TOTAL = Convert.ToInt32(TXT_TOTAL.Text);

                    String Usuario = REPORTE_FACTURA.CurrentRow.Cells["Usuario"].Value.ToString();

                    Boolean Resultado = ObjNegocio.VALIDACION_DE_TOPE(LOGIN.CODIGO, ObjEntidad);
                    Boolean Resultado_Factura = ObjNegocio.Verificando_Factura(LOGIN.CODIGO, Usuario);

                    if (Resultado.Equals(true))
                    {
                        if (Resultado_Factura.Equals(true))
                        {
                            ObjNegocio.Editar_Factura(ObjEntidad, LOGIN.CODIGO);

                            NOTIFICACION.CONFIRMAR_NOTIFICACION("EDITADO");
                            MOSTRAR_BUSCAR_TABLA("");
                            Editarse = false;
                            LimpiarCajas();
                        }
                        else
                        {
                            DialogResult resultado = new DialogResult();
                            NOTIFICACION_AVISO frm = new NOTIFICACION_AVISO("ESTA FACTURA NO ESTA A SU NOMBRE, POR FAVOR INICIA SECCION CON ESE USUARIO");
                            resultado = frm.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                MOSTRAR_BUSCAR_TABLA("");
                                Editarse = false;
                                LimpiarCajas();
                            }
                        }
                    }
                    else
                    {
                        ERROR.ERROR_M("SU PRECIO TOTAL DEBE SER MAS MENOR");
                        MOSTRAR_BUSCAR_TABLA("");
                        LimpiarCajas();
                    }

                }
                catch (Exception EX)
                {
                    MessageBox.Show("NO SE PUEDE EDIATR" + EX);
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
                    String Usuario = REPORTE_FACTURA.CurrentRow.Cells["Usuario"].Value.ToString();
                    Boolean Verificar = ObjNegocio.VALIDANDO_FACTURA_USUARIO_ELIMINAR(LOGIN.CODIGO, Usuario);

                    if (Verificar.Equals(true))
                    {
                        ObjEntidad.ID = Convert.ToInt32(REPORTE_FACTURA.CurrentRow.Cells[0].Value.ToString());
                        ObjNegocio.Eliminar_Factura(ObjEntidad, LOGIN.CODIGO);

                        NOTIFICACION.CONFIRMAR_NOTIFICACION("ELIMINADO");
                        MOSTRAR_BUSCAR_TABLA("");
                    }
                    else
                    {
                        DialogResult Resultado = new DialogResult();
                        NOTIFICACION_AVISO NT = new NOTIFICACION_AVISO("ESTA FACTURA NO ESTA A SU NOMBRE, POR FAVOR INICIA SECCION CON ESE USUARIO");
                        resultado = NT.ShowDialog();

                        if(Resultado == DialogResult.OK)
                        {
                            MOSTRAR_BUSCAR_TABLA("");
                            Editarse = false;
                            LimpiarCajas();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }

        private void S_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = S_Usuario.SelectedIndex;

            if (indice <= 8 && indice > 0)
            {
                var DATOS = ObjNegocio.DATOS_P(S_Usuario.Text); //traemos los dos datos y los guardamos en la variable DATOS

                Usuario = DATOS.Item2; //guardamos el dato USUARIO en la variable statica
                //N_USUARIO.Text = DATOS.Item2;

                Codigo = DATOS.Item1; //guardamos el dato CODIGO en la variable statica
                //CODIGO_P.Text = Convert.ToString(DATOS.Item1.ToString());

                if (Usuario == LOGIN.USUARIO)
                {
                    NOTIFICACION.CONFIRMAR_NOTIFICACION("EL USUARIO YA ESTA EN SECCION");
                }
                else
                {
                    LOGIN.USUARIO = Usuario;
                    LOGIN.CODIGO = Convert.ToInt32(Codigo);

                    NOTIFICACION.CONFIRMAR_NOTIFICACION("SECCION ACTUALIZADA POR NUEVO USUARIO");

                }
            }
        }
    }
}
