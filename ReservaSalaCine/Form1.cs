using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class Form1 : Form
    {
        
        SalaCine Cine = new SalaCine(1, "El Planeta de los Simios");

        private SalaCine[] cine;

        public Form1()
        {
            InitializeComponent();
            if (pelicula != null) pelicula.Text = Cine.Pelicula;
        }


        public bool validaRut(string rut)
        {
            int[] constantesValidacion = { 3, 2, 7, 6, 5, 4, 3, 2 };
            double suma = 0;

            switch (rut.Length)
            {
                case 9: rut = "0" + rut;break;
                case 8: rut = "00" + rut; break;
                case 7: rut = "000" + rut; break;
                case 6: rut = "0000" + rut; break;

            }

            double division = suma / 11;
            int divisionentero = (int)division;
            double resto = division - divisionentero;
            double resta = 11 - (11 * resto);
            var digito = Math.Round(resta);

            string digitorut = rut[9].ToString();

            if (digitorut == "k")
            {
                digitorut = "9";
            }
            else if (digitorut == "0")

            {
                digitorut = "11";
            }

            if (digito.ToString() == digitorut)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_elegir_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Cine.asientosSala[1, 1] = new Asiento(1, 1, true);
                MessageBox.Show("Asiento " + TraduceLetra(1) + 1 + " ha sido "+ traduceOcupado(Cine.asientosSala[1,1]));

            }

            if (checkBox2.Checked == true)
            {
                Cine.asientosSala[1, 2] = new Asiento(1, 2, true);
                MessageBox.Show("Asiento " + TraduceLetra(1) + 1 + " ha sido " + traduceOcupado(Cine.asientosSala[1, 2]));

            }
            if (checkBox3.Checked == true)
            {
                Cine.asientosSala[1, 3] = new Asiento(1, 3, true);
                MessageBox.Show("Asiento " + TraduceLetra(1) + 1 + " ha sido " + traduceOcupado(Cine.asientosSala[1, 3]));

            }
            if (checkBox4.Checked == true)
            {
                Cine.asientosSala[1, 4] = new Asiento(1, 4, true);
                MessageBox.Show("Asiento " + TraduceLetra(1) + 1 + " ha sido " + traduceOcupado(Cine.asientosSala[1, 4]));

            }
            if (checkBox4.Checked == true)
            {
                Cine.asientosSala[1, 5] = new Asiento(1, 5, true);
                MessageBox.Show("Asiento " + TraduceLetra(1) + 5 + " ha sido " + traduceOcupado(Cine.asientosSala[1, 5]));
            }
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string TraduceLetra(int pos)
        {
            switch (pos)
            {
                case 1: return "A";
                case 2: return "B"; 
                case 3: return "C"; 
                case 4: return "D"; 
                case 5: return "E"; 
                default: return "No encontrado";
            }
        }

        public string traduceOcupado(Asiento asiento)
        {
            if (asiento.Ocupado)
            {
                return "Ocupado";
            }
            else
            {
                return "Desocupado;";
            }
        }
    }
}
