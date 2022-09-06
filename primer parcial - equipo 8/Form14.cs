using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace primer_parcial___equipo_5
{
    public partial class iniciarseccion : Form
    {
        public iniciarseccion()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=.LAPTOP-C6KTNLFR;database=logins; integrated security=true");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iniciarseccion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from nombre wheare nombre='"+textBox1.Text+"' and clave='"+textBox2.Text+ "' ";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                Form form = new Form1();

                form.Show();
            }
            else
            {
                MessageBox.Show("ususario o contraseña incorrecta","iniciar seccion");
            }
            conexion.Close();   
        }
    }
}
