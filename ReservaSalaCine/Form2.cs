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


namespace ReservaSalaCine
{
    public partial class Form2 : Form
    {
        //se crea lista para guardar datos de usuarios//
        List<CLASEEVALUA2cristianmoralesa > LISTAEVALUA2 = new List<CLASEEVALUA2cristianmoralesa>();
        CLASEEVALUA2cristianmoralesa Usuario = new CLASEEVALUA2cristianmoralesa();
       
        public Form2()
        {
            InitializeComponent();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textBox2.Text;
            if (validaRut(rut))
            {
                Usuario.Rut = textBox2.Text;
                Usuario.InicioSesion = DateTime.Now;
                Usuario.Accion = button1.Text;
                Usuario.AccionF = DateTime.Now;
                LISTAEVALUA2.Add(Usuario);

                datossesion.datossesionRut = Usuario.Rut;
                datossesion.datossesionInicio = Usuario.InicioSesion;

                var formprincipal = new Form1(LISTAEVALUA2);
                var formLogin = new Form2();
                formLogin.Hide();
                formprincipal.Show();
            }
            else
            {
                MessageBox.Show("Rut Incorrecto");
            }

        }


        public bool validaRut(string rut)
        {
            int[] constantesValidacion = { 3, 2, 7, 6, 5, 4, 3, 2 };
            double suma = 0;

            switch (rut.Length)
            {
                case 9: rut = "0" + rut; break;
                case 8: rut = "00" + rut; break;
                case 7: rut = "000" + rut; break;
                case 6: rut = "0000" + rut; break;

            }

            for (int j = 0; j < constantesValidacion.Length; j++)
            {
                suma = suma + (Int16.Parse(rut[j].ToString()) * constantesValidacion[j]);

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var Evaluacion_2 = new Evaluacion_2();
            Evaluacion_2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            var Evaluacion_2 = new Evaluacion_2();
            Evaluacion_2.Show();


        }
    }
}
