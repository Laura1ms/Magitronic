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
    class AdminUsuario
    {
        //Para verificar usuarios
        public static Double VerificarUsuario(System.String User, System.String Contasena)
        {
            
            int Bandera;
            OleDbDataReader Encontrado;
            OleDbDataReader Encontrado1;

            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb) ;
            String query = "SELECT * FROM UserTabla WHERE UserName = '" + User + "' And contrasena = '" + Contasena + "' And Rol = " + 1 + "";
            String query1 = "SELECT * FROM UserTabla WHERE UserName = '" + User + "' And contrasena = '" + Contasena + "' And Rol = " + 2 + "";
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
                else if (Encontrado1.Read() == true)
                {
                    Bandera = 2;
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
        //Para obtener datos de usuarios
        public static aplicacionCompras.Datos.Datos.usuario obtenerDatosUser(System.Double IDUsuario)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            string query = "Select * from UserTabla where IdUser=" + IDUsuario;
            DataTable Dt = aplicacionCompras.Negocios.administradorDB.ExcuteQuery(connectionString, query, "UserTabla");
        if (Dt.Rows.Count == 0)
            {
                return null;
            }
            return new aplicacionCompras.Datos.Datos.usuario(Dt.Rows[0]);
        
        }
        //Para registrar usuarios
        public static void RegistroUsuario(aplicacionCompras.Datos.Datos.usuario DatosUsuarios)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            String query = "INSERT INTO  UserTabla (IdUser, UserName, contrasena, Nombre , Apellido1, Apellido2,Rol) VALUES (" + DatosUsuarios.IdUser +",'"+ DatosUsuarios.UserName +"', '" + DatosUsuarios.contrasena + "', '" + DatosUsuarios.Nombre + "', '" + DatosUsuarios.Apellido1 + "', '" + DatosUsuarios.Apellido12 + "', " + DatosUsuarios.Rol + ")  ";
            aplicacionCompras.Negocios.administradorDB.ExacuteNonQuery(connectionString, query);

        }
        //Para buscar usuarios
        public static aplicacionCompras.Datos.Datos.usuario BuscarUser(System.String Nombre, System.String apellido1, System.String apellido2)
        {
            String connectionString = String.Format(aplicacionCompras.Properties.Settings.Default.conexiondb);
            string query = "Select * from UserTabla where Nombre = '" + Nombre + "' , Apellido1 = '" + apellido1 + "', Apellido12='" + apellido2 + "'";
            DataTable Dt = aplicacionCompras.Negocios.administradorDB.ExcuteQuery(connectionString, query, "UserTabla");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }
            return new aplicacionCompras.Datos.Datos.usuario(Dt.Rows[0]);

        }


    }
}
