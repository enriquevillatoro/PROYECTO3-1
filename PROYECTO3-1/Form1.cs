using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO3_1
{
    public partial class Form1 : Form

    {
        List<Clientes> Buscar = new List<Clientes>();
        List<Bodega> BProducto = new List<Bodega>();
        List<Ventas> XP = new List<Ventas>();
        List<Ventan> copia = new List<Ventan>();

        public Form1()
        {
            InitializeComponent();
            List<Bodega> ventemp = new List<Bodega>();
            string fileName3 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";
            FileStream stream3 = new FileStream(fileName3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);
            while (reader3.Peek() > -1)
            {
                Bodega retemp = new Bodega();
                retemp.Producto = reader3.ReadLine();
                retemp.Cantidad = Convert.ToInt16 (reader3.ReadLine());
                retemp.Precio1 = Convert.ToDecimal(reader3.ReadLine());
                ventemp.Add(retemp);
            }

            reader3.Close();
            for (int i = 0; i < ventemp.Count; i++)
            {
                comboBox1.Items.Add(ventemp[i].Producto);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DatoClientes abrir = new DatoClientes();
            abrir.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu back = new Menu ();
            back.Show();
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Clientes ctemp = new Clientes();
                ctemp.Nit = reader.ReadLine();
                ctemp.Nombre = reader.ReadLine();
                ctemp.Apellido = reader.ReadLine();
                Buscar.Add(ctemp);
            }
            reader.Close();

            for (int i=0; i<= Buscar.Count; i++ )
            {
                if(Buscar[i].Nit == textBox1.Text)
                {
                    textBox5.Text = Buscar[i].Nombre;
                    textBox8.Text = Buscar[i].Apellido;

                    break;
                }
                else if(Buscar[i].Nit != textBox1.Text)
                {
                    textBox1.Text = " ";
                    MessageBox.Show("ERROR seria necesario que cree una cuenta de usuario");

                }break;
               
            }


            string fileName2 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";
            FileStream stream1 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);

            while (reader1.Peek() > -1)
            {
                Bodega Ltemp = new Bodega();
                Ltemp.Producto = reader1.ReadLine();
                Ltemp.Cantidad = Convert.ToInt16(reader1.ReadLine());
                Ltemp.Precio1 = Convert.ToDecimal(reader1.ReadLine());
                BProducto.Add(Ltemp);
            }
            reader1.Close();
            
            for (int x = 0; x < BProducto.Count; x++)
            {
                comboBox1.Items.Add(BProducto[x].Producto);
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            List<Bodega> inventario = new List<Bodega>();
            string fileName3 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";
            FileStream stream3 = new FileStream(fileName3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);
            while (reader3.Peek() > -1)
            {
                Bodega retemp = new Bodega();
                retemp.Producto = reader3.ReadLine();
                retemp.Cantidad = Convert.ToInt16(reader3.ReadLine());
                retemp.Precio1 = Convert.ToDecimal(reader3.ReadLine());
                inventario.Add(retemp);
            }
            reader3.Close();

            Ventan vtemp = new Ventan();

            string FileName = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\venta.txt";
            FileStream stream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(comboBox1.Text);
            writer.WriteLine(textBox3.Text);

            decimal subtotal;

            for (int i = 0; i < inventario.Count; i++)
            {
                if (comboBox1.Text == inventario[i].Producto)
                {
                    subtotal = Convert.ToDecimal(textBox3.Text) * inventario[i].Precio1;
                    inventario[i].Cantidad = inventario[i].Cantidad - Convert.ToInt16(textBox3.Text);
                    writer.WriteLine(Convert.ToString(subtotal));
                    break;
                }
            }
            writer.Close();


            string fileName4 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\venta.txt";
            FileStream stream4 = new FileStream(fileName4, FileMode.Open, FileAccess.Read);
            StreamReader reader4 = new StreamReader(stream4);
            while (reader4.Peek() > -1)
            {
                Ventan vestemp = new Ventan();
                vestemp.Producto = reader4.ReadLine();
                vestemp.Cantidad = Convert.ToInt16(reader4.ReadLine());
                vestemp.Precio = Convert.ToDecimal(reader4.ReadLine());
                copia.Add(vestemp);
            }
            reader4.Close();


            string fileName5 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";
            FileStream stream5 = new FileStream(fileName5, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer5 = new StreamWriter(stream5);
            for (int i = 0; i < inventario.Count; i++)
            {
                writer5.WriteLine(inventario[i].Producto);
                writer5.WriteLine(inventario[i].Cantidad);
                writer5.WriteLine(inventario[i].Precio1);

            }
            writer5.Close();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = copia;
            dataGridView1.Refresh();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ventas vetempor = new Ventas();
            vetempor.Nit1 = textBox1.Text;
            vetempor.Codvendedor = textBox2.Text;
            vetempor.Fechaventa = Convert.ToDateTime(dateTimePicker1.Text);

            decimal sumatotal=0;
            for (int i = 0; i < copia.Count; i++)
            {
                sumatotal = sumatotal + copia[i].Precio;
            }
            vetempor.Precio = sumatotal;
            /*for (int i = 0; i < copia.Count; i++)
            {
                vetempor.Productosavender[i].Producto = copia[i].Producto;
                vetempor.Productosavender[i].Cantidad = copia[i].Cantidad;
                vetempor.Productosavender[i].Precio = copia[i].Precio;
            }*/

            XP.Add(vetempor);

            string fileName6 = "factura.txt";
            FileStream stream6 = new FileStream(fileName6, FileMode.Append, FileAccess.Write);
            StreamWriter writer6 = new StreamWriter(stream6);
            for (int i = 0; i < XP.Count; i++)
            {

                writer6.WriteLine(XP[i].Nit1);
                writer6.WriteLine(XP[i].Codvendedor);
                writer6.WriteLine(XP[i].Precio);
                writer6.WriteLine(XP[i].Fechaventa);

            }
            writer6.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

