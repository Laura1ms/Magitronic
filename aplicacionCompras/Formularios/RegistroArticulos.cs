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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent(); //llamado al metodo
        }
        //Boton registro de articulos
        private void button1_Click(object sender, EventArgs e)
        {
            aplicacionCompras.Datos.Datos.productos DatosProductos;

            DatosProductos = new Datos.Datos.productos();
            int id = Int32.Parse(Idproducto.Text);
            DatosProductos.Idproducto = id;
            DatosProductos.Producto = ProductoTxt.Text;
            DatosProductos.Precio = Int32.Parse(PrecioTxt.Text);
            DatosProductos.Marca = MarcaTxt.Text;
            DatosProductos.Cantidad = Int32.Parse(CantidadTxt.Text);
            DatosProductos.Categoria = CategoriaTxt.Text;
            

            aplicacionCompras.Datos.AdminDatos.Adminproductos.RegistroProducto(DatosProductos);

            MessageBox.Show("Producto registrado exitosamente.");

        }
    }
}
