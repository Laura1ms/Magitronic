using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionCompras
{
    public partial class Form1 : Form
    {    
        //para iniciar el formulario de inicio
        public Form1()
        {
            InitializeComponent();
        }

        //Cargar formulario

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        //Para boton aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            Double Bandera;
            Bandera = aplicacionCompras.Datos.AdminDatos.AdminUsuario.VerificarUsuario(user.Text, password.Text);
            if (Bandera == 1)
            {
                MessageBox.Show("Bienvenido/a Administrador");
                aplicacionCompras.Formularios.inventario forminventario = new Formularios.inventario();
                forminventario.ShowDialog();
                user.Clear();
                password.Clear();
                user.Focus();

            }
            else if (Bandera == 2)
            {
                MessageBox.Show("Bienvenido/a usuario");
                aplicacionCompras.Formularios.compras formcompras = new Formularios.compras();
                formcompras.ShowDialog();
                user.Clear();
                password.Clear();
                user.Focus();
            }
            else
            {
                MessageBox.Show("No existe Usuario");
                user.Clear();
                password.Clear();
                user.Focus();
            }
        }
        //Para botón cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //para cuando el valor de usuario y contraseña es diferente
        private void user_TextChanged(object sender, EventArgs e)
        {

        }
        private void password_TextChanged(object sender, EventArgs e)
        {

        }
        //Para boton registrarse
        private void button3_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Formularios.RegistroUser formularioRegistroUser = new RegistroUser();
            formularioRegistroUser.Show();
        }

        //Declaracion de metodos
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
