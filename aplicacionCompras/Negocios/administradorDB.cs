using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

//CONEXION BASE DE DATOS
namespace aplicacionCompras.Negocios
{
     class administradorDB
    {
        public static DataTable ExcuteQuery(string ConnectionString, string query, string tablaName)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection();
                OleDbDataAdapter myAdapter = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, tablaName);
                ds.Tables[0].TableName= tablaName;
                return ds.Tables[0];

            }

            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;
            }

        }

        public static void ExacuteNonQuery(string ConnectionString, string query)
        {
            OleDbConnection myConnection = new OleDbConnection(ConnectionString);

            try
            {
                myConnection.Open();
                OleDbCommand myCommand = new OleDbCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                //throw ex;

            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
        }

        

    }
}

