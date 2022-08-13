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
    public partial class FormularioUsuarios : Form //clase FormularioUsuarios
    {
        public FormularioUsuarios() //metodo
        {
            InitializeComponent(); //llamado de metodo
        }
        

        //Campo que carga todos los usuarios
        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsLogin.UserTabla' Puede moverla o quitarla según sea necesario.
            this.userTablaTableAdapter.Fill(this.dsLogin.UserTabla);

        }
        //Boton para salir
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton para registrar usuarios
        private void button1_Click(object sender, EventArgs e)
        {
          
                aplicacionCompras.Datos.Datos.usuario DatosUser;

                DatosUser = new Datos.Datos.usuario();
                int id = Int32.Parse(textBox7.Text);
                int rol = Int32.Parse(textBox6.Text);
                DatosUser.IdUser = id;
                DatosUser.UserName = textBox1.Text;
                DatosUser.contrasena = textBox5.Text;
                DatosUser.Nombre = textBox2.Text;
                DatosUser.Apellido1 = textBox3.Text;
                DatosUser.Apellido12 = textBox4.Text;
                DatosUser.Rol = rol;

                aplicacionCompras.Datos.AdminDatos.AdminUsuario.RegistroUsuario(DatosUser);

                MessageBox.Show("Registrado con exito");
        }
        //Declaración de metodos
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
