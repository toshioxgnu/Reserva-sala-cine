using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class Form1 : Form
    {
        CLASEEVALUA2josegonzalez usuario = new CLASEEVALUA2josegonzalez();
        private string archivoruta = @"C:\TXTS\VIGIAJOSEGONZALEZ.txt";

        SalaCine Cine = new SalaCine(1, "El Planeta de los Simios");

        private SalaCine[] cine;

        public Form1()
        {
            InitializeComponent();
            if (pelicula != null) pelicula.Text = Cine.Pelicula;

        }

        private void btn_elegir_Click(object sender, EventArgs e)
        {
            string asientosReservados = "";

            foreach (var c in Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cd = (CheckBox)c;

                    if (cd.Checked)
                    {
                        string celda = cd.Text.ToString();
                        Cine.asientosSala[traduceLetra(celda[0].ToString()), Int32.Parse(celda[1].ToString())] = new Asiento(traduceLetra(celda[0].ToString()),Int32.Parse(celda[1].ToString()), true );
                        asientosReservados = asientosReservados + cd.Text.ToString()+ ", ";
                    }
                }
            }

            usuario.Rut = sesion.sessionRut;
            usuario.InicioSesion = sesion.sessionInicio;
            usuario.Accion = "Reserva asiento :"+ asientosReservados ;
            usuario.AccionF = DateTime.Now; 

            MessageBox.Show("Asientos " + asientosReservados + " Han sido reservados ");

        }

        public string traduceFila(int pos)
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
        public int traduceLetra(string letra)
        {
            switch (letra)
            {
                case "A": return 1;
                case "B": return 2;
                case "C": return 3;
                case "D": return 4;
                case "E": return 5;
                default: return 0;
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

        private void cierraSesion_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter writer = File.AppendText(archivoruta))
            {
                writer.WriteLine(linea);
            }

        }
    }
}
