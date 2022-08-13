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
    public partial class compras : Form
    {
        public compras() //metodo
        {
            InitializeComponent(); //llamado de metodo
        }

        private void compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tproductos' Puede moverla o quitarla según sea necesario.
            this.tproductosTableAdapter.Fill(this.dataSet1.tproductos);

        }
        //Para clickear en el tabla de base de datos y enviarlo a las casillas correspondientes
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            }
        }

        //Declarar variables
        int suma;
        string [] nombreProducto = new string[100];
        int[] valorProducto = new int[100];
        int  indice=0;
        //Al presionar el boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty)
            {
                indice++;
                valorProducto[indice] = Int32.Parse(textBox2.Text);
                suma = suma + valorProducto[indice];
                textBox4.Text = suma.ToString();
                nombreProducto[indice] = textBox1.Text;

                textBox5.Text = "";
                for (int j = 1; j <= indice; j++)
                {
                    if (nombreProducto[j] != string.Empty)
                    {
                        textBox5.Text = j + ". " + nombreProducto[j] + "\r\n" + textBox5.Text;
                    }


                }

            }
            
        }

        
        //Para el boton eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text!=string.Empty)
            {
                nombreProducto[Int32.Parse(textBox3.Text)] = string.Empty;
                textBox5.Text = "";
                for (int j = 1; j <= indice; j++)
                {
                    if (nombreProducto[j] != string.Empty)
                    {
                        textBox5.Text = j + ". " + nombreProducto[j] + "\r\n" + textBox5.Text;
                    }

                }

                suma = suma - valorProducto[Int32.Parse(textBox3.Text)];
                textBox4.Text = suma.ToString();
                textBox3.Text = "";
            }
            
        }
        //Declaración de metodos
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Definir imprimir
        string imprimir;

        //Para boton enviar (generar factura)
        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= indice; j++)
            {
                if (nombreProducto[j] != string.Empty)
                {
                     imprimir =  nombreProducto[j] + "\r\n" + imprimir;
                }

            }
            MessageBox.Show("Productos comprados: " + "\r\n" + imprimir + "\r\n" + "Valor total: " + suma);
        }
        //Boton cerrar sesión
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
