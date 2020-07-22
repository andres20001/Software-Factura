using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDADES;
using CAPA_DATOS;
using System.Windows;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class N_CATEGORIA
    {
        D_CATEGORIA ObjetoDatos = new D_CATEGORIA();

        public List<E_CATEGORIA> ListandoFactura(string Buscar)
        {
            return ObjetoDatos.LISTAR_FACTURAS(Buscar);
        }

        public void InsertarFcatura(E_CATEGORIA Categoria, int ID, string Usuario)
        {
            ObjetoDatos.INSERTAR_FACTURA(Categoria, ID, Usuario);
        }

        public void Editar_Factura(E_CATEGORIA Categoria, int ID)
        {
            ObjetoDatos.EDITAR_FACTURA(Categoria, ID);
        }

        public void Eliminar_Factura(E_CATEGORIA Categoria, int ID)
        {
            ObjetoDatos.ELIMINAR_FACTURA(Categoria, ID);
        }

        //RETORNANDO TODOS LOS METODOS DE USUARIOS

        public List<E_CATEGORIA> ListandoUsuario(string Buscar)
        {
            return ObjetoDatos.LISTAR_USUARIOS(Buscar);
        }

        public void InsertarUsuario(E_CATEGORIA Categoria)
        {
            ObjetoDatos.INSERTAR_USUARIO(Categoria);
        }

        public void Editar_Usuario(E_CATEGORIA Categoria)
        {
            ObjetoDatos.EDITAR_USUARIO(Categoria);
        }

        public Boolean Eliminar_Usuario(E_CATEGORIA Categoria, String USUARIO, int ID)
        {
            return ObjetoDatos.ELIMINAR_USUARIO(Categoria, USUARIO, ID);
        }

        public List<E_CATEGORIA> FACTURAS_MAX_DIAS(String Buscar)
        {
            return ObjetoDatos.LISTAR_FACTURAS_DIAS_MAX(Buscar);
        }

        public bool Validando(E_CATEGORIA Categoria)
        {
            return ObjetoDatos.VALIDACION_USUARIO(Categoria);
        }

        public Boolean VALIDACION_DE_TOPE(int Usuario, E_CATEGORIA Categoria)
        {
            return ObjetoDatos.VALIDACION_DE_TOPE(Usuario, Categoria);
        }

        public void INSERTAR_FACTURA_SEGUIMIENTO(E_CATEGORIA Categoria)
        {
            ObjetoDatos.INSERTAR_FACTURA_REPORTE(Categoria);
        }

        public void ESTADO_UPDATE(int ESTADO, int ID)
        {
            ObjetoDatos.ACTUALIZACION_ESTADO(ESTADO, ID);
        }

        public Boolean Verificando_Factura(int ID, string Factura)
        {
            return ObjetoDatos.VALIDANDO_FACTURA_USUARIO(ID, Factura);
        }

        public Boolean VALIDANDO_FACTURA_USUARIO_ELIMINAR(int ID, string Factura)
        {
            return ObjetoDatos.VALIDANDO_FACTURA_USUARIO_ELIMINAR(ID, Factura);
        }

        public Boolean Verificando_Admin(String Usu_Admin, int ID)
        {
            return ObjetoDatos.Validando_Admin(Usu_Admin, ID);
        }

        public void LLENAR_COMBOBOX(ComboBox comboBox)
        {
            ObjetoDatos.Llenar_ComboBox(comboBox);
        }

        public Tuple<string,string> DATOS_P(string Nombre)
        {
            return ObjetoDatos.CAPT_USUARIO(Nombre);
        }
        public List<E_CATEGORIA> LISTAR_FACTURAS_INFO(string Buscar)
        {
            return ObjetoDatos.LISTAR_FACTURAS_INFO(Buscar);
        }
    }
}
