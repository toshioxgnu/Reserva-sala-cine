using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalaCine
{
    public partial class PERFILES : Form
    {
        Utilitades Utils = new Utilitades();

        public PERFILES()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Utils.llenaTabla(dataGridView1);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string rut = txtrut.ToString();
            if(Utils.validaRut(rut))
            {

            }
            else
            {
                MessageBox.Show("RUT INVALIDO");
            }
        }
    }
}
