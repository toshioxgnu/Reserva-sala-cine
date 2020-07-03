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
                string sqlintert = "insert into PERFILESJOSEGONZALEZ (RUT,NOMBRE,APPAT,APMAT,CLAVE) values ('"+rut+"','"+nombre+ "','" + apepat + "','" + apemat + "','" + clave + "')";
                DataTable registro = new DataTable();
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\basesLeones\\BDPROGjosegonzalez.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlintert, conn);
                adapter.Fill(registro);
                conn.Close();
                Utils.llenaTabla(dataGridView1);
                Utils.ResetAllControls(this);
            }
            else
            {
                MessageBox.Show("RUT INVALIDO");                
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string apepat = txtapat.Text.ToString();

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\basesLeones\\BDPROGjosegonzalez.mdf;Integrated Security=True;Connect Timeout=30");
            DataTable registro = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            string clave = txtclave.Text.ToString();
            string sqlbusca = "select * from PERFILESJOSEGONZALEZ where APPAT = '"+apepat+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlbusca, conn);
            adapter.Fill(registro);

            if (registro != null)
            {
                dataGridView1.DataSource = registro;
            }
            else
            {
                MessageBox.Show("No HAY DATOS");
            }           
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\basesLeones\\BDPROGjosegonzalez.mdf;Integrated Security=True;Connect Timeout=30");
            DataTable registro = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            string clave = txtclave.Text.ToString();
            string sqlbusca = "select * from PERFILESJOSEGONZALEZ where CLAVE = '" + clave + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlbusca, conn);
            adapter.Fill(registro);

            if (registro != null)
            {
                string sqlelimina = "delete from PERFILESJOSEGONZALEZ where CLAVE = '"+clave+"'";
                adapter = new SqlDataAdapter(sqlelimina, conn);
                adapter.Fill(registro);
                Utils.llenaTabla(dataGridView1);
            }
            else
            {
                MessageBox.Show("No HAY DATOS");
            }

            conn.Close();
        }

        private void btn_traspasa_Click(object sender, EventArgs e)
        {

        }
    }
}
