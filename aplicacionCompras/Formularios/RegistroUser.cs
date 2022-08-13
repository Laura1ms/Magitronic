using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionCompras.Formularios
{
    //Registro de usuarios
    public partial class RegistroUser : Form
    {
        public RegistroUser()
        {
            InitializeComponent(); //llamado al metodo
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Datos.Datos.usuario DatosUser;

            DatosUser = new Datos.Datos.usuario();
            int id = Int32.Parse(Idtxt.Text);
            DatosUser.IdUser = id;
            DatosUser.UserName = UserTxt.Text;
            DatosUser.contrasena = passtxt.Text;
            DatosUser.Nombre = nombreTxt.Text;
            DatosUser.Apellido1 = apellido1Txt.Text;
            DatosUser.Apellido12 = apellido2Txt.Text;
            DatosUser.Rol = 2;

            aplicacionCompras.Datos.AdminDatos.AdminUsuario.RegistroUsuario(DatosUser);

            MessageBox.Show("Registrado con exito");
        }

        //Declaracion de metodos
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void apellido2Txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void apellido1Txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void nombreTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
