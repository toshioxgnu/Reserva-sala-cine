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
            string rut = txtrut.Text.ToString();
            if(Utils.validaRut(rut))
            {
                string nombre = txtnombre.Text.ToString();
                string apepat = txtapat.Text.ToString();
                string apemat = txtapmat.Text.ToString();
                string clave = txtclave.Text.ToString();
                string sqlintert = "insert into PERFILESJOSEGONZALEZ (RUT,NOMBRE,APPAT,APMAT,CLAVE) values ("+rut+","+nombre+ "," + apepat + "," + apemat + "," + clave + ",)";
                DataTable registro = new DataTable();
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\basesLeones\\BDPROGjosegonzalez.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlintert, conn);
                Utils.llenaTabla(dataGridView1);
            }
            else
            {
                MessageBox.Show("RUT INVALIDO");
            }
        }
    }
}
