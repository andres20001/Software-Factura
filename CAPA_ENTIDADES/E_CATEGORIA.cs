using System;

namespace CAPA_ENTIDADES
{
    public class E_CATEGORIA
    {

        //DATOS DE LA TABLA FACTURAS_PROVEEDORES

        private int _ID;
        private string _NOMBRE_PROVEEDOR;
        private int _NUMORO_FACTURA;
        private DateTime _FECHA_INICIO;
        private DateTime _FECHA_FINAL;
        private int _DIAS_PEN;
        private int _PRECIO_TOTAL;
        private int _ESTADO;
        public int ID
        {
            get => _ID;
            set => _ID = value;
        }
        public string NOMBRE_PROVEEDOR
        {
            get => _NOMBRE_PROVEEDOR;
            set => _NOMBRE_PROVEEDOR = value;
        }
        public int NUMORO_FACTURA
        {
            get => _NUMORO_FACTURA;
            set => _NUMORO_FACTURA = value;
        }
        public DateTime FECHA_INICIO
        {
            get => _FECHA_INICIO;
            set => _FECHA_INICIO = value;
        }
        public DateTime FECHA_FINAL
        {
            get => _FECHA_FINAL;
            set => _FECHA_FINAL = value;
        }
        public int DIAS_PEN
        {
            get => _DIAS_PEN;
            set => _DIAS_PEN = value;
        }
        public int PRECIO_TOTAL
        {
            get => _PRECIO_TOTAL;
            set => _PRECIO_TOTAL = value;
        }

        public int ESTADO
        {
            get => _ESTADO;
            set => _ESTADO = value;
        }

        //DATOS DE LA TABLA USUARIOS

        private int _IDCATEGORIA;
        private String _CODIGO;
        private string _NOMBRE;
        private string _USUARIO;
        private string _PASSWORD;
        private int _EDAD;
        private int _TOPE_MAXIMO;

        public int IDCATEGORIA
        {
            get => _IDCATEGORIA;
            set => _IDCATEGORIA = value;
        }
        public String CODIGO
        {
            get => _CODIGO;
            set => _CODIGO = value;
        }
        public string NOMBRE
        {
            get => _NOMBRE;
            set => _NOMBRE = value;
        }

        public int TOPE_MAXIMO
        {
            get => _TOPE_MAXIMO;
            set => _TOPE_MAXIMO = value;
        }
        public string PASSWORD
        {
            get => _PASSWORD;
            set => _PASSWORD = value;
        }
        public string USUARIO
        {
            get => _USUARIO;
            set => _USUARIO = value;
        }
        public int EDAD
        {
            get => _EDAD;
            set => _EDAD = value;
        }
    }
}
