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
    public partial class DatoClientes : Form
    {
        List<Clientes> N = new List<Clientes>();
        public DatoClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar datos de clientes
            Clientes esc = new Clientes();
            esc.Nit = textBox3.Text;
            esc.Nombre = textBox1.Text;
            esc.Apellido = textBox2.Text;

            N.Add(esc);
            string FileName = "clientes.txt";
            FileStream stream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < N.Count; i++)
            {
                writer.WriteLine(N[i].Nombre);
                writer.WriteLine(N[i].Apellido);
                writer.WriteLine(N[i].Nit);
            }
            writer.Close();

            MessageBox.Show("Guardado Satisfactoriamente");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FileName = "clientes.txt";
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Clientes V = new Clientes();

                V.Nombre = reader.ReadLine();
                V.Apellido = reader.ReadLine();
                V.Nit = reader.ReadLine();
                N.Add(V);

            }
            reader.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = N;
            dataGridView1.Refresh();
        }
    }
}

