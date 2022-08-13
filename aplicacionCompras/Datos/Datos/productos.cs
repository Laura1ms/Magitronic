using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace aplicacionCompras.Datos.Datos
{
    class productos
    {
        //Declarar variables
        public Int32 Idproducto;
        public string Producto;
        public string Marca;
        public string Categoria;
        public Int32 Cantidad;
        public Int32 Precio;

        //Declarar metodo
        public productos()
        {

        }
        //Funciona para registrar
        public productos(DataRow dr)
        {
            if (dr["Idproducto"] != DBNull.Value)
            {
                this.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
            }
            if (dr["Cantidad"] != DBNull.Value)
            {
                this.Cantidad = Int32.Parse(dr["Cantidad"].ToString());
            }
            if (dr["Precio"] != DBNull.Value)
            {
                this.Precio = Int32.Parse(dr["Precio"].ToString());
            }
            if (dr["Producto"] != DBNull.Value)
            {
                this.Producto = dr["Producto"].ToString();
            }
            if (dr["Marca"] != DBNull.Value)
            {
                this.Marca = dr["Marca"].ToString();

            }
            if (dr["Categoria"] != DBNull.Value)
            {
                this.Categoria = dr["Categoria"].ToString();
            }

        }
    }
}
