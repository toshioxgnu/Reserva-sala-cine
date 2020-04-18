﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class Form1 : Form
    {
        SalaCine[] CineMelocoton = new SalaCine[5];

        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox2.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox3.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox4.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox5.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox10.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox9.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox8.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox7.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox6.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox15.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox14.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox13.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox12.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox11.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox20.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox19.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox18.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox17.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox16.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox25.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox24.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox23.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox22.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox21.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox30.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox29.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox28.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox27.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox26.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox35.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox34.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox33.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox32.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox31.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox40.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox39.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox38.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox37.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox36.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox45.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox44.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox43.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox42.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox41.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox50.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox49.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox48.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox47.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
            if (checkBox46.Checked == true)
                MessageBox.Show("Asiento Seleccionado");
        }

    }
}
