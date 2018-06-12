using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO3_1
{
    public partial class Menu : Form
    {
        Ventas usuario = new Ventas();

        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "JUAN")
            {

                if (textBox2.Text == "1234")
                {
                    Agregar_productos_nuevos abrir = new Agregar_productos_nuevos();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR");

                }

            }
            else
            {
                MessageBox.Show("ERROR DE CONTRASEÑA");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "PEDRO" || textBox4.Text == "LUIS")
            {

                if (textBox5.Text == "1234" || textBox5.Text == "2222")
                {
                    Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR");

                }

            }
            else
            {
                MessageBox.Show("ERROR DE CONTRASEÑA");

            }


            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
