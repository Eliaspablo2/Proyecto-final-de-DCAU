using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_Final
{
    public partial class Form1 : Form
    {
        SqlConnection conenct = new SqlConnection("Server= ELIASPABLO\\LINKENDI; database=PF_DC; Integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conenct.Open();
            string nombre = textBox1.Text;
            string Correo = textBox3.Text;
            string Telefono = textBox4.Text;
            string cadena = "insert into Usuario(Nombre, Correo, Telefono) values ('" + nombre + "','" + Correo + "','" + Telefono + "')";
            SqlCommand comando = new SqlCommand(cadena, conenct);
            comando.ExecuteNonQuery();
            MessageBox.Show("los datos se agregaron correctamente");
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            conenct.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Principal = new Form2();
            Principal.Show();
            this.Close();
        }
    }
}
