using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAPA_DATOS
{
    public class D_CATEGORIA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        //SERVIDOR DE DON JUAN PABLO IDEA-HC

        //BUSCAR DATOS DE FACTURAS
        public List<E_CATEGORIA> LISTAR_FACTURAS(string Buscar)
        {
            SqlDataReader Trallendo;
            SqlCommand cmd = new SqlCommand("BUSCAR_FACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Buscar);

            Trallendo = cmd.ExecuteReader();

            List<E_CATEGORIA> Lista_Factura = new List<E_CATEGORIA>();

            while (Trallendo.Read())
            {
                Lista_Factura.Add(new E_CATEGORIA
                {
                    ID = Trallendo.GetInt32(0),
                    NOMBRE_PROVEEDOR = Trallendo.GetString(1),
                    NUMORO_FACTURA = Trallendo.GetInt32(2),
                    FECHA_INICIO = Trallendo.GetDateTime(3),
                    FECHA_FINAL = Trallendo.GetDateTime(4),
                    DIAS_PEN = Trallendo.GetInt32(5),
                    PRECIO_TOTAL = Trallendo.GetInt32(6),
                    ESTADO = Trallendo.GetInt32(7),
                    USUARIO = Trallendo.GetString(8),
                });
            }

            conexion.Close();
            Trallendo.Close();

            return Lista_Factura;
        }

        //BUSCAR DATOS DE USUARIOS
        public List<E_CATEGORIA> LISTAR_USUARIOS(string Buscar)
        {
            SqlDataReader Dato_Usuario;
            SqlCommand cmd = new SqlCommand("BUSCAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Buscar);

            Dato_Usuario = cmd.ExecuteReader();

            List<E_CATEGORIA> Lista_Usuario = new List<E_CATEGORIA>();

            while (Dato_Usuario.Read())
            {
                Lista_Usuario.Add(new E_CATEGORIA
                {
                    IDCATEGORIA = Dato_Usuario.GetInt32(0),
                    CODIGO = Dato_Usuario.GetString(1),
                    NOMBRE = Dato_Usuario.GetString(2),
                    USUARIO = Dato_Usuario.GetString(3),
                    PASSWORD = Dato_Usuario.GetString(4),
                    EDAD = Dato_Usuario.GetInt32(5),
                    TOPE_MAXIMO = Dato_Usuario.GetInt32(6),
                });
            }

            conexion.Close();
            Dato_Usuario.Close();

            return Lista_Usuario;
        }

        public List<E_CATEGORIA> LISTAR_FACTURAS_DIAS_MAX(string Buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("BUSCAR_FACTURA_MAX_DIAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_CATEGORIA> Listar = new List<E_CATEGORIA>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_CATEGORIA
                {
                    ID = LeerFilas.GetInt32(0),
                    NOMBRE_PROVEEDOR = LeerFilas.GetString(1),
                    NUMORO_FACTURA = LeerFilas.GetInt32(2),
                    FECHA_INICIO = LeerFilas.GetDateTime(3),
                    FECHA_FINAL = LeerFilas.GetDateTime(4),
                    DIAS_PEN = LeerFilas.GetInt32(5),
                    PRECIO_TOTAL = LeerFilas.GetInt32(6),
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public List<E_CATEGORIA> LISTAR_FACTURAS_INFO(string Buscar)
        {
            SqlDataReader Trallendo;
            SqlCommand cmd = new SqlCommand("BUSCAR_FACTURA_DOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Buscar);

            Trallendo = cmd.ExecuteReader();

            List<E_CATEGORIA> Lista_Factura = new List<E_CATEGORIA>();

            while (Trallendo.Read())
            {
                Lista_Factura.Add(new E_CATEGORIA
                {
                    ID = Trallendo.GetInt32(0),
                    NOMBRE_PROVEEDOR = Trallendo.GetString(1),
                    NUMORO_FACTURA = Trallendo.GetInt32(2),
                    FECHA_INICIO = Trallendo.GetDateTime(3),
                    FECHA_FINAL = Trallendo.GetDateTime(4),
                    DIAS_PEN = Trallendo.GetInt32(5),
                    PRECIO_TOTAL = Trallendo.GetInt32(6),
                    ESTADO = Trallendo.GetInt32(7),
                    USUARIO = Trallendo.GetString(8),
                });
            }

            conexion.Close();
            Trallendo.Close();

            return Lista_Factura;
        }

        //INSERTAR FACTURA
        public void INSERTAR_FACTURA(E_CATEGORIA Categoria, int ID, string Usuario)
        {
            SqlCommand cmd = new SqlCommand("INSERTAR_FACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre_Proveedor", Categoria.NOMBRE_PROVEEDOR);
            cmd.Parameters.AddWithValue("@Numero_Factura", Categoria.NUMORO_FACTURA);
            cmd.Parameters.AddWithValue("@Fecha_Inicio", Categoria.FECHA_INICIO);
            cmd.Parameters.AddWithValue("@Fecha_Final", Categoria.FECHA_FINAL);
            cmd.Parameters.AddWithValue("@Dias_Pen", Categoria.DIAS_PEN);
            cmd.Parameters.AddWithValue("@Precio_Total", Categoria.PRECIO_TOTAL);
            cmd.Parameters.AddWithValue("@Id_Usuario", ID);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //INSERTAR FACTURA AL SEGUIMIENTO DE 7 DIAS
        public void INSERTAR_FACTURA_REPORTE(E_CATEGORIA Categoria)
        {
            SqlCommand cmd = new SqlCommand("INSERTAR_FACTURA_REPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre_Proveedor", Categoria.NOMBRE_PROVEEDOR);
            cmd.Parameters.AddWithValue("@Numero_Factura", Categoria.NUMORO_FACTURA);
            cmd.Parameters.AddWithValue("@Fecha_Inicio", Categoria.FECHA_INICIO);
            cmd.Parameters.AddWithValue("@Fecha_Final", Categoria.FECHA_FINAL);
            cmd.Parameters.AddWithValue("@Dias_Pen", Categoria.DIAS_PEN);
            cmd.Parameters.AddWithValue("@Precio_Total", Categoria.PRECIO_TOTAL);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //INSERTAR USUARIO
        public void INSERTAR_USUARIO(E_CATEGORIA Categoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@NOMBRE", Categoria.NOMBRE);
                cmd.Parameters.AddWithValue("@USUARIO", Categoria.USUARIO);
                cmd.Parameters.AddWithValue("@PASSWORD", Categoria.PASSWORD);
                cmd.Parameters.AddWithValue("@EDAD", Categoria.EDAD);
                cmd.Parameters.AddWithValue("@TOPE_MAXIMO", Categoria.TOPE_MAXIMO);

                SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE NOMBRE = 'Don Juan Pablo' ", conexion);
                Consulta.CommandType = CommandType.Text;
                SqlDataReader Trallendo_Datos;

                Trallendo_Datos = Consulta.ExecuteReader();

                if (Trallendo_Datos.Read())
                {
                    int Total = Trallendo_Datos.GetInt32(6);

                    if (Categoria.TOPE_MAXIMO <= Total)
                    {
                        Trallendo_Datos.Close();
                        cmd.ExecuteNonQuery();
                        NOTIFICACION_ONE.CONFIRMAR_NOTIFICACION("GUARDADO..");
                    }
                    else
                    {
                        ERROR_D.ERROR_M("EL TOPE DEBE SER MENOR AL DE DON JUAN PABLO");
                    }
                }
                else
                {
                    ERROR_D.ERROR_M("ERRORES DE SISTEMA");
                }

                conexion.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("error" + Ex);
            }
        }

        //EDITAR FACTURA
        public void EDITAR_FACTURA(E_CATEGORIA Editar, int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EDITAR_FACTURA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@id", Editar.ID);
                cmd.Parameters.AddWithValue("@Nombre_Proveedor", Editar.NOMBRE_PROVEEDOR);
                cmd.Parameters.AddWithValue("@Numero_Factura", Editar.NUMORO_FACTURA);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", Editar.FECHA_INICIO);
                cmd.Parameters.AddWithValue("@Fecha_Final", Editar.FECHA_FINAL);
                cmd.Parameters.AddWithValue("@Precio_Total", Editar.PRECIO_TOTAL);
                cmd.Parameters.AddWithValue("@Id_Usuario", ID);

                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        //EDITAR USUARIO
        public void EDITAR_USUARIO(E_CATEGORIA Editar)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", Editar.IDCATEGORIA);
            cmd.Parameters.AddWithValue("@NOMBRE", Editar.NOMBRE);
            cmd.Parameters.AddWithValue("@USUARIO", Editar.USUARIO);
            cmd.Parameters.AddWithValue("@PASSWORD", Editar.PASSWORD);
            cmd.Parameters.AddWithValue("@EDAD", Editar.EDAD);
            cmd.Parameters.AddWithValue("@TOPE_MAXIMO", Editar.TOPE_MAXIMO);

            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE NOMBRE = 'Don Juan Pablo' ", conexion);
            Consulta.CommandType = CommandType.Text;
            SqlDataReader Trallendo_Datos;

            Trallendo_Datos = Consulta.ExecuteReader();

            if (Trallendo_Datos.Read())
            {
                int Total = Trallendo_Datos.GetInt32(6);
                string Usuario = Trallendo_Datos.GetString(2);

                if (Editar.TOPE_MAXIMO <= Total || Usuario == "Don Juan Pablo")
                {
                    Trallendo_Datos.Close();
                    cmd.ExecuteNonQuery();
                    NOTIFICACION_ONE.CONFIRMAR_NOTIFICACION("EDITADO..");
                }
                else
                {
                    ERROR_D.ERROR_M("EL TOPE DEBE SER MENOR AL DE DON JUAN PABLO");
                    Trallendo_Datos.Close();
                }
            }
            conexion.Close();
        }

        //ELIMINAR FACTURA
        public void ELIMINAR_FACTURA(E_CATEGORIA Categoria, int ID)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_FACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@id", Categoria.ID);
            cmd.Parameters.AddWithValue("@Id_Usuario", ID);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //ELIMINAR USUARIO
        public Boolean ELIMINAR_USUARIO(E_CATEGORIA Categoria, String USUARIO, int ID)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", Categoria.IDCATEGORIA);
            cmd.Parameters.AddWithValue("@Id_Usuario", ID);

            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE NOMBRE = 'Don Juan Pablo' ", conexion);
            Consulta.CommandType = CommandType.Text;
            SqlDataReader Trallendo_Datos;

            Trallendo_Datos = Consulta.ExecuteReader();

            Trallendo_Datos.Read();

            string Usuario_Don = Trallendo_Datos.GetString(2);

            if (USUARIO == Usuario_Don)
            {
                Trallendo_Datos.Close();
                ERROR_D.ERROR_M("ESE USUARIO NO SE PUEDE ELIMINAR");
                conexion.Close();
                return false;
            }
            else
            {
                Trallendo_Datos.Close();
                cmd.ExecuteNonQuery();
                conexion.Close();
                NOTIFICACION_ONE.CONFIRMAR_NOTIFICACION("ELIMINADO..");
                return true;
            }
        }

        public Boolean VALIDACION_USUARIO(E_CATEGORIA Categoria)
        {

            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE USUARIO = '" + Categoria.USUARIO + "' ", conexion);
            Consulta.CommandType = CommandType.Text;
            SqlDataReader Verificacion_D_Usuario;
            conexion.Open();

            Verificacion_D_Usuario = Consulta.ExecuteReader();

            Verificacion_D_Usuario.Read();

            if (Verificacion_D_Usuario.Read())
            {
                conexion.Close();
                Verificacion_D_Usuario.Close();
                return true;
            }
            else
            {
                conexion.Close();
                Verificacion_D_Usuario.Close();
                return false;
            }
        }

        public Boolean VALIDACION_DE_TOPE(int Usuario, E_CATEGORIA Categoria)
        {
            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE IDCATEGORIA = '" + Usuario + "' ", conexion);
            SqlDataReader Verificacion_Tope;
            conexion.Open();

            Verificacion_Tope = Consulta.ExecuteReader();

            Verificacion_Tope.Read();

            int TOPE_MAX_USUARIO = Verificacion_Tope.GetInt32(6);

            if (Categoria.PRECIO_TOTAL <= TOPE_MAX_USUARIO)
            {
                conexion.Close();
                Verificacion_Tope.Close();
                return true;
            }
            else
            {
                conexion.Close();
                Verificacion_Tope.Close();
                return false;
            }
        }

        public void ACTUALIZACION_ESTADO(int ESTADO, int ID)
        {
            SqlCommand Consulta = new SqlCommand("UPDATE Facturas_Proveedores SET ESTADO = '" + ESTADO + "' WHERE Id = '" + ID + "'", conexion);
            conexion.Open();

            Consulta.ExecuteNonQuery();
            conexion.Close();
        }

        public Boolean VALIDANDO_FACTURA_USUARIO(int ID, string Factura)
        {
            SqlCommand Consulta = new SqlCommand("Select * from Usuarios WHERE IDCATEGORIA = '" + ID + "'", conexion);
            SqlDataReader Verificacion_Tope;
            conexion.Open();

            Verificacion_Tope = Consulta.ExecuteReader();

            Verificacion_Tope.Read();

            string Usuario_Factura = Verificacion_Tope.GetString(3);

            if (Factura.Equals(Usuario_Factura))
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return true;
            }
            else
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return false;
            }
        }

        public Boolean VALIDANDO_FACTURA_USUARIO_ELIMINAR(int ID, string Usuario)
        {
            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE IDCATEGORIA = '" + ID + "'", conexion);
            SqlDataReader Verificacion_Tope;
            conexion.Open();

            Verificacion_Tope = Consulta.ExecuteReader();

            Verificacion_Tope.Read();

            string Usuario_Factura = Verificacion_Tope.GetString(3);//ACA ESTA EL USUARIO QUE ESTA LOGIADO EN ESTOS MOMENTOS

            if (Usuario.Equals(Usuario_Factura))
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return true;
            }
            else
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return false;
            }
        }

        public Boolean Validando_Admin(string Usu_Admin, int ID)
        {
            SqlCommand Consulta = new SqlCommand("Select * from Usuarios WHERE IDCATEGORIA = '" + ID + "' ", conexion);
            SqlDataReader Verificacion_Tope;
            conexion.Open();

            Verificacion_Tope = Consulta.ExecuteReader();

            Verificacion_Tope.Read();

            string Usuario = Verificacion_Tope.GetString(3);

            if (Usuario.Equals("Admin_Elizabet"))
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return true;
            }
            else
            {
                Verificacion_Tope.Close();
                conexion.Close();
                return false;
            }
        }

        public Tuple<string,string> CAPT_USUARIO(string Nombre)
        {
            string USUARIO = "NULL";
            string CODIGO = "NULL";
            conexion.Open();
            SqlCommand Consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE NOMBRE = '" + Nombre + "' ", conexion);
            SqlDataReader Datos_U;
            Datos_U = Consulta.ExecuteReader();

            if (Datos_U.Read())
            {
                CODIGO = Datos_U["IDCATEGORIA"].ToString();
                USUARIO = Datos_U["USUARIO"].ToString();
            }
    
            conexion.Close();
            return Tuple.Create(CODIGO, USUARIO);
        }

        public void Llenar_ComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            SqlCommand Consulta = new SqlCommand("Select * from Usuarios", conexion);
            SqlDataReader Datos;

            conexion.Open();
            Datos = Consulta.ExecuteReader();

            while (Datos.Read())
            {
                comboBox.Items.Add(Datos[2].ToString());
            }
            conexion.Close();
            comboBox.Items.Insert(0, "--Sel. Usuario--");
            comboBox.SelectedIndex = 0;
        }
    }
}
