using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Agregar = new Form1();
            Agregar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Buscar = new Form3();
            Buscar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
    }
}
