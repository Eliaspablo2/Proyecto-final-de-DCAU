using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace proyecto_Final
{
    public partial class Form3 : Form
    {
        SqlConnection conenct = new SqlConnection("Server= ELIASPABLO\\LINKENDI; database=PF_DC; Integrated security = true");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conenct.Open();
            string ID = textBox1.Text;
            string cadena = "select * from Usuario where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conenct);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label7.Text = registro["Nombre"].ToString();
                label9.Text = registro["Correo"].ToString();
                label10.Text = registro["Telefono"].ToString();
            }
            else
            {
                MessageBox.Show("El codigo no existe.");
                conenct.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Principal = new Form2();
            Principal.Show();
            this.Close();
        }
    }
}
