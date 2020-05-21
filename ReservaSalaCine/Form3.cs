using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class Form3 : Form
    {
        CLASEEVALUA2josegonzalez usuario = new CLASEEVALUA2josegonzalez();
        private string archivoruta = @"C:\TXTS\VIGIAJOSEGONZALEZ.txt";
        List<CLASEEVALUA2josegonzalez> muestra = new List<CLASEEVALUA2josegonzalez>();

        public Form3()
        {
            InitializeComponent();
        }

        private void btn_muestratodo_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(archivoruta);
            string linea;
            linea = leer.ReadLine();
            while (linea != null)
            {
                string[] fecha;
                string[] datos = linea.Split(',');
                for (int i = 0; i < datos.Length; i += 5)
                {
                    fecha = datos[i + 4].Split(';');
                    CLASEEVALUA2josegonzalez usuario = new CLASEEVALUA2josegonzalez(datos[i], Convert.ToDateTime(datos[i + 1]),
                        Convert.ToDateTime(datos[i + 2]), datos[i+3], Convert.ToDateTime(fecha[0]));
                    muestra.Add(usuario);
                }
                linea = leer.ReadLine();
            }
            leer.Close();
            mostrar(muestra);
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {

        }

        public void mostrar(List<CLASEEVALUA2josegonzalez> lista)
        {
            foreach (CLASEEVALUA2josegonzalez dato in lista)
            {
                ListViewItem al = new ListViewItem(dato.Rut);
                al.SubItems.Add(dato.InicioSesion.ToString());
                al.SubItems.Add(dato.finSesion.ToString());
                al.SubItems.Add(dato.Accion);
                al.SubItems.Add(dato.AccionF.ToString());
                listView1.Items.Add(al);
            }
        }
    }
}
