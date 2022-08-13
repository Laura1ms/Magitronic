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
    public partial class inventario : Form
    {
        public inventario() //metodo 
        {
            InitializeComponent(); //llamado del metodo de inicio
        }
        //Boton usuario
        private void ususarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Formularios.FormularioUsuarios formularioUser = new FormularioUsuarios(); //Constructor metodo
            
            formularioUser.MdiParent = this; //indicar que es un hijo del formulario
            formularioUser.Show();
        }
        //Botón articulos
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Formularios.Articulos formularioarticulos = new Articulos();
            formularioarticulos.MdiParent = this;
            formularioarticulos.Show();

        }
        //Para cargar el inventario de usuarios
        private void inventario_Load(object sender, EventArgs e)
        {
            aplicacionCompras.Formularios.FormularioUsuarios formularioUser = new FormularioUsuarios(); //para crear el metodo del formulario usuarios

            formularioUser.MdiParent = this;
            formularioUser.Show();
        }
        //botón cerrar sesión
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
