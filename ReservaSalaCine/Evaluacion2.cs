using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class Evaluacion_2 : Form
    {
        public Evaluacion_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\TXTS\VIGIACRISTIANMORALES.txt");
            label2.Text = "";
            string linea;
            linea = leer.ReadLine();
            while (linea != null)
            {
                label2.Text = label2.Text + linea + "\n";

                linea = leer.ReadLine();
            }
            leer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\TXTS\VIGIACRISTIANMORALES.txt");
            label2.Text = "";
            string linea;
            linea = leer.ReadLine();
            while (linea != null)
            {
                string[] busca = linea.Split(',');
                if (busca[0].Equals(textBox1.Text))
                {
                    label2.Text = label2.Text + linea + "\n";
                }
                linea = leer.ReadLine();
            }
            leer.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

