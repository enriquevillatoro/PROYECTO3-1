using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace PROYECTO3_1
{
    public partial class Agregar_productos_nuevos : Form
    {
        List<Bodega> BProducto = new List<Bodega>();
        List<Ventas> XP = new List<Ventas>();
        List<Bodega> Modify = new List<Bodega>();
        int posicionmodificar;
        //static List<Cliente> clientes = new List<Cliente>();

        int posicionproductomenor = 0;
        public Agregar_productos_nuevos()
        {
            InitializeComponent();
        }

        private void Agregar_productos_nuevos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///modificar
            for (int i = 0; i < Modify.Count; i++)
            {
                if(textBox1.Text == Modify[i].Producto)
                {
                    Modify[i].Producto = textBox1.Text;
                    Modify[i].Cantidad = Convert.ToInt16(textBox2.Text);
                    Modify[i].Precio1 = Convert.ToDecimal(textBox3.Text);


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buscar
           
             



            string fileName12 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";

            FileStream stream12 = new FileStream(fileName12, FileMode.Open, FileAccess.Read);
            StreamReader reader12 = new StreamReader(stream12);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader12.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                Bodega mdtemp = new Bodega();
                mdtemp.Producto = reader12.ReadLine();
                mdtemp.Cantidad = Convert.ToInt16(reader12.ReadLine());
                mdtemp.Precio1 = Convert.ToDecimal(reader12.ReadLine());
               

                //Agregar a la lista el temporal
                Modify.Add(mdtemp);
            }
            reader12.Close();

            //Se recorre la lista de clientes
            for (int i = 0; i < Modify.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (Modify[i].Producto == textBox1.Text)
                {
                  textBox2.Text= Modify[i].Cantidad.ToString();
                    textBox3.Text =Modify[i].Precio1.ToString();

                }
                /* TextBox2.Text = clientes[i].Nombre;
                TextBox3.Text = clientes[i].Apellido;
                TextBox4.Text = clientes[i].Nit;
                TextBox5.Text = clientes[i].Direccion;*/


                //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                posicionmodificar = i;

            }





            }


            private void button8_Click(object sender, EventArgs e)
            {
                Menu back = new Menu();
                back.Show();
                this.Hide();
            }

            private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                string fileName = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    Bodega avastecimineto = new Bodega();
                    avastecimineto.Producto = reader.ReadLine();
                    avastecimineto.Cantidad = Convert.ToInt16(reader.ReadLine());
                    avastecimineto.Precio1 = Convert.ToDecimal(reader.ReadLine());
                    BProducto.Add(avastecimineto);
                }
                reader.Close();
                


            List<Bodega> menor = new List<Bodega>();
            Bodega menortmep = new Bodega();
                int posicionmodificar=1;

            for (int i = 0; i < BProducto.Count; i++)
                {

                    if (BProducto[i].Cantidad < BProducto[posicionmodificar].Cantidad)
                    {
                        posicionproductomenor = i;
                    }
                  
                }

            menortmep.Producto = BProducto[posicionproductomenor].Producto;
            menortmep.Cantidad = BProducto[posicionproductomenor].Cantidad;
            menortmep.Precio1 = BProducto[posicionproductomenor].Precio1;
            menor.Add(menortmep);

            dataGridView6.DataSource = null;
            dataGridView6.Refresh();
            dataGridView6.DataSource = menor;
            dataGridView6.Refresh();


            }

        private void button5_Click(object sender, EventArgs e)
        {
            //abrir ventas

            List<Ventas> mostrar = new List<Ventas>();
            string fileName10 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\factura.txt";
            FileStream stream10 = new FileStream(fileName10, FileMode.Open, FileAccess.Read);
            StreamReader reader10 = new StreamReader(stream10);
            while (reader10.Peek() > -1)
            {
                Ventas ret = new Ventas();
                ret.Nit1 = reader10.ReadLine();
                ret.Codvendedor = Convert.ToInt16(reader10.ReadLine());
                ret.Producto2 = reader10.ReadLine();
               ret.Subtotal= Convert.ToDecimal(reader10.ReadLine());

                mostrar.Add(ret);
            }
            reader10.Close();
            dataGridView5.DataSource = null;
            dataGridView5.Refresh();
            dataGridView5.DataSource = mostrar;
            dataGridView5.Refresh();    
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName20 = @"C:\Users\Kike\source\repos\PROYECTO3-1\PROYECTO3-1\bin\Debug\bodega.txt.txt";

            //Para que sobreescriba los datos existentes se usa CREATE
            FileStream stream20 = new FileStream(fileName20, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer20 = new StreamWriter(stream20);
            for (int i = 0; i < Modify.Count; i++)
            {
                writer20.WriteLine(Modify[i].Producto);
                writer20.WriteLine(Modify[i].Cantidad);
                writer20.WriteLine(Modify[i].Precio1);
            }
            writer20.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }
    }

       
    }


