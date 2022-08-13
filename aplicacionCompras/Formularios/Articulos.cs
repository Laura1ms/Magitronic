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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent(); //llamado al metodo
        }
        //Cargar campo de articulos
        private void Articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tproductos' Puede moverla o quitarla según sea necesario.
            this.tproductosTableAdapter.Fill(this.dataSet1.tproductos);
        }
        //Botón para salir
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton registrar productos
        private void button1_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Formularios.RegistroArticulos formularioRegistroArticulo = new RegistroArticulos();
            formularioRegistroArticulo.Show();
        }

        //Declaracion de metodos
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        }
    }

