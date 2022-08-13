using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace aplicacionCompras.Datos.Datos
{
    class usuario
    {
        //Declaracion de variables
        public Int32 IdUser;
        public string UserName;
        public string contrasena;
        public string Nombre;
        public string Apellido1;
        public string Apellido12;
        public Int32 Rol;

        //Declaracion de usuario
        public usuario()
        {

        }
        //Para poder registrar usuarios
        public usuario(DataRow dr)
        {
            if (dr["IdUser"] != DBNull.Value)
            {
                this.IdUser = Int32.Parse(dr["IdUser"].ToString());
            }

            if (dr["UserName"] != DBNull.Value)
            {
                this.UserName = dr["UserName"].ToString();
            }

            if (dr["Nombre"] != DBNull.Value)
            {
                this.Nombre = dr["Nombre"].ToString();
            }
            if (dr["contrasena"] != DBNull.Value)
            {
                this.contrasena = dr["contrasena"].ToString();
            }
            if (dr["Apellido1"] != DBNull.Value)
            {
                this.Apellido1 = dr["Apellido1"].ToString();
            }
            if (dr["Apellido12"] != DBNull.Value)
            {
                this.Apellido12 = dr["Apellido12"].ToString();
            }
            
            if (dr["Rol"] != DBNull.Value)
            {
                this.Rol = Int32.Parse(dr["Rol"].ToString());
            }
        }
    }
}

