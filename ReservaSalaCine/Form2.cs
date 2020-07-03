using System;
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
    public partial class Form2 : Form
    {
        Utilitades Utils = new Utilitades();
        List<CLASEEVALUA2josegonzalez> LISTAEVALUA2 = new List<CLASEEVALUA2josegonzalez>();
        CLASEEVALUA2josegonzalez Usuario = new CLASEEVALUA2josegonzalez();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textBox2.Text;
            if (Utils.validaRut(rut))
            {
                Usuario.Rut = textBox2.Text;
                Usuario.InicioSesion = DateTime.Now;
                Usuario.Accion = button1.Text;
                LISTAEVALUA2.Add(Usuario);

                sesion.sessionRut = Usuario.Rut;
                sesion.sessionInicio = Usuario.InicioSesion;

                var formprincipal = new Form1( LISTAEVALUA2);
                var formLogin = new Form2();
                formLogin.Hide();
                formprincipal.Show();
            }
            else
            {
                MessageBox.Show("Rut Incorrecto");
            }
        }

    }
}
