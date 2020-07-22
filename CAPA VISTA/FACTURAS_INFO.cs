using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Seguimiento
{
    public partial class FACTURAS_INFO : Form
    {

        public FACTURAS_INFO()
        {
            InitializeComponent();
        }

        E_CATEGORIA ObjEntidad = new E_CATEGORIA();
        N_CATEGORIA ObjNegocio = new N_CATEGORIA();

        public void MOSTRAR_BUSCAR_TABLA(string Buscar)
        {
            N_CATEGORIA ObjetoNegocio = new N_CATEGORIA();
            FACTURA_RE.DataSource = ObjetoNegocio.LISTAR_FACTURAS_INFO(Buscar);
        }

        public void ModificarTabla()
        {
            FACTURA_RE.Columns[0].Width = 50;
            FACTURA_RE.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            FACTURA_RE.Columns[1].Width = 100;
            FACTURA_RE.Columns[2].Width = 100;
            FACTURA_RE.Columns[3].Width = 100;
            FACTURA_RE.Columns[4].Width = 100;
            FACTURA_RE.Columns[5].Width = 100;
            FACTURA_RE.Columns[6].Width = 100;
            FACTURA_RE.Columns[6].DefaultCellStyle.Format = "#,#";
            FACTURA_RE.Columns[7].Visible = false;
            FACTURA_RE.Columns[8].Visible = false;
            FACTURA_RE.Columns[9].Visible = false;
            FACTURA_RE.Columns[10].Visible = false;
            FACTURA_RE.Columns[11].Visible = false;
            FACTURA_RE.Columns[12].Visible = false;
            FACTURA_RE.Columns[13].Visible = false;
            FACTURA_RE.Columns[14].Visible = false;

            this.FACTURA_RE.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FACTURAS_INFO_Load(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA("");
            ModificarTabla();

            COMBOVOX.Visible = false;
            TXT_ESTADO.Visible = false;
        }

        private void BTN_VISUALIZAR_Click(object sender, EventArgs e)
        {
            if (FACTURA_RE.SelectedRows.Count > 0)
            {
                TXT_ID_F.Text = FACTURA_RE.CurrentRow.Cells[0].Value.ToString();
                TXT_NO_PROVEEDOR.Text = FACTURA_RE.CurrentRow.Cells[1].Value.ToString();
                TXT_N_FACTURA.Text = FACTURA_RE.CurrentRow.Cells[2].Value.ToString();
                DT_FE_INICIO.Value = Convert.ToDateTime(FACTURA_RE.CurrentRow.Cells[3].Value.ToString());
                DT_FE_FINAL.Value = Convert.ToDateTime(FACTURA_RE.CurrentRow.Cells[4].Value.ToString());
                TXT_DIAS_PENDIENTES.Text = FACTURA_RE.CurrentRow.Cells[5].Value.ToString();
                TXT_P_TOTAL.Text = FACTURA_RE.CurrentRow.Cells[6].Value.ToString();

                if (Convert.ToInt32(FACTURA_RE.CurrentRow.Cells[7].Value.ToString()) == 0)
                {
                    COMBOVOX.Visible = true;
                    COMBOVOX.Text = "FACTURA PENDIENTE";
                    TXT_ESTADO.Visible = true;
                    COMBOVOX.BackColor = Color.Orange;
                }
                else if (Convert.ToInt32(FACTURA_RE.CurrentRow.Cells[7].Value.ToString()) == 1)
                {
                    COMBOVOX.Visible = true;
                    COMBOVOX.Text = "FACTURA PAGADA";
                    COMBOVOX.BackColor = Color.Green;

                    TXT_ESTADO.Visible = true;
                }
            }
        }

        //private void BTN_SEGUIMIENTO_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ObjEntidad.NOMBRE_PROVEEDOR = TXT_NO_PROVEEDOR.Text;
        //        ObjEntidad.NUMORO_FACTURA = Convert.ToInt32(TXT_N_FACTURA.Text);
        //        ObjEntidad.FECHA_INICIO = Convert.ToDateTime(DT_FE_INICIO.Value);
        //        ObjEntidad.FECHA_FINAL = Convert.ToDateTime(DT_FE_FINAL.Value);
        //        ObjEntidad.DIAS_PEN = Convert.ToInt32(TXT_DIAS_PENDIENTES.Text);
        //        ObjEntidad.PRECIO_TOTAL = Convert.ToInt32(TXT_P_TOTAL.Text);

        //        ObjNegocio.INSERTAR_FACTURA_SEGUIMIENTO(ObjEntidad);

        //        NOTIFICACION.CONFIRMAR_NOTIFICACION("FACTURA EN PROCESO DE SEGUIMIENTO");
        //        LimpiarDatos();

        //    }
        //    catch (Exception)
        //    {
        //        ERROR.ERROR_M("POR FAVOOR VISUALICE LA FACTURA QUE QUIERE SEGUIR");
        //    }
        //}

        public void LimpiarDatos()
        {
            TXT_ID_F.Text = "";
            TXT_NO_PROVEEDOR.Text = "";
            TXT_N_FACTURA.Text = "";
            TXT_DIAS_PENDIENTES.Text = "";
            TXT_P_TOTAL.Text = "";
        }

        private void CAMBIAR_COLOR(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            //Logica para pintar lo que es una fila por completa pero lo que es la primera opcion que he provado

            int Valor = Convert.ToInt32(FACTURA_RE.Rows[e.RowIndex].Cells[7].Value.ToString());//aca me trae el estdo de la facura 1 es porque esta pagada o 0 es porque esta sin pagar
            Console.WriteLine("LOS DATOS EN VALOR SON :" + Valor);

            if (Valor == 1)
            {
                FACTURA_RE.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;//factura pagada
            }
            else
            {
                FACTURA_RE.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;//factura sin pagar
            }

            //Logica para lo que es dar alerta de los dias para pagar lo que es una factura
            if (this.FACTURA_RE.Columns[e.ColumnIndex].Name == "DIAS_PEN")
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

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            MOSTRAR_BUSCAR_TABLA(TXT_BUSCAR.Text);
        }

        private void COMBOVOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = COMBOVOX.SelectedIndex;//aca canturo lo que es el index verificar que estado le dio el usuario: ESTADO: pagada o pendiente

            if (indice == 1)
            {
                int id = Convert.ToInt32(FACTURA_RE.CurrentRow.Cells[0].Value.ToString());
                int Nuevo_Estado = 1;

                COMBOVOX.BackColor = Color.Green;
                LimpiarDatos();

                ObjNegocio.ESTADO_UPDATE(Nuevo_Estado, id);

                string buscar = Convert.ToString(FACTURA_RE.CurrentRow.Cells[2].Value.ToString());
                MOSTRAR_BUSCAR_TABLA(buscar);

                COMBOVOX.Visible = false;
                TXT_ESTADO.Visible = false;
            }
            //else if (indice == 0)
            //{
            //    int id = Convert.ToInt32(FACTURA_RE.CurrentRow.Cells[0].Value.ToString());
            //    int Es_Pendiente = 0;

            //    COMBOVOX.BackColor = Color.Orange;
            //    COMBOVOX.Visible = true;
            //    TXT_ESTADO.Visible = true;

            //    LimpiarDatos();

            //    ObjNegocio.ESTADO_UPDATE(Es_Pendiente, id);//actualizo su nuevo estado en la base de datos

            //    MOSTRAR_BUSCAR_TABLA("");

            //    //COMBOVOX.Visible = false;//oculto el combovox
            //    //TXT_ESTADO.Visible = false;//oculto el texto
            //}
        }
      
    }
}






