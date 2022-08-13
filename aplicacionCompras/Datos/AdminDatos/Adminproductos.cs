using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace aplicacionCompras.Datos.AdminDatos
{
     class Adminproductos
    {
        //Para verificar productos
        public static Double VerificarProducto(System.String Producto, System.String Categoria)
        {

            int Bandera;
            OleDbDataReader Encontrado;
            OleDbDataReader Encontrado1;

            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            String query = "SELECT * FROM tproductos WHERE UserName = '" + Producto + "' And Categoria = '" + Categoria + "' = " + 1 + "";
            String query1 = "SELECT * FROM tproductos WHERE UserName = '" + Producto + "' And Categoria = '" + Categoria + "' = " + 2 + "";
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();
                OleDbCommand myCommand = new OleDbCommand(query, myConnection);
                OleDbCommand myCommand1 = new OleDbCommand(query1, myConnection);

                Encontrado = myCommand.ExecuteReader();
                Encontrado1 = myCommand1.ExecuteReader();
                if (Encontrado.Read() == true)
                {
                    Bandera = 1;
                }
                else
                {
                    Bandera = -1;
                }

                Encontrado.Close();
                Encontrado1.Close();
                myCommand.ExecuteNonQuery();
                myCommand1.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;

            }

            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }

            return Bandera;

        }
        //Para obtener datos de productos
        public static aplicacionCompras.Datos.Datos.productos obtenerDatosProductos(System.Double Idproducto)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            string query = "Select * from tproductos where Idproducto=" + Idproducto;
            DataTable Dt = aplicacionCompras.Negocios.administradorDB.ExcuteQuery(connectionString, query, "tproductos");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }
            return new aplicacionCompras.Datos.Datos.productos(Dt.Rows[0]);

        }
        //Eliminar productos
        public static void eliminarProducto(aplicacionCompras.Datos.Datos.productos Datosproductos)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            string query = "Delete from tproductos where IdProducto=" + Datosproductos.Idproducto;
            aplicacionCompras.Negocios.administradorDB.ExacuteNonQuery(connectionString, query);

        }
        //Registro de productos
        public static void RegistroProducto(aplicacionCompras.Datos.Datos.productos Datosproductos)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            String query = "INSERT INTO  tproductos (Idproducto, Producto, Precio, Marca, Cantidad, Categoria) VALUES (" + Datosproductos.Idproducto + ",'" + Datosproductos.Producto + "', '" + Datosproductos.Precio + "', '" + Datosproductos.Marca + "', '" + Datosproductos.Cantidad + "', '" + Datosproductos.Categoria + "')  ";
            aplicacionCompras.Negocios.administradorDB.ExacuteNonQuery(connectionString, query);

        }

        //Para buscar productos
        public static aplicacionCompras.Datos.Datos.productos BuscarProducto(System.String Producto, System.String Marca, System.String Categoria)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            string query = "Select * from tproductos where Producto = '" + Producto + "' , Producto = '" + Marca + "', Marca='" + Categoria + "'";
            DataTable Dt = aplicacionCompras.Negocios.administradorDB.ExcuteQuery(connectionString, query, "tproductos");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }
            return new aplicacionCompras.Datos.Datos.productos(Dt.Rows[0]);

        }


    }
}
    


