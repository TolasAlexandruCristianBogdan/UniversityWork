using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        localhost.WebService1 serv = new localhost.WebService1();
        private void button1_Click(object sender, EventArgs e)
        {
            
            Array T = serv.GetNames();
            foreach (string name in T) {listBox1.Items.Add(name); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           double C =double.Parse(textBox2.Text);
           double F=serv.FtoC(C);
            textBox3.Text=F.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double C = double.Parse(textBox1.Text);
            double F = serv.CtoF(C);
            textBox3.Text = F.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = serv.dt();
            label5.Text = time;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /* double E = double.Parse(textBox4.Text);
             double L = serv.EtoL(E);
             textBox5.Text = L.ToString();*/
            try
            {
                double E = double.Parse(textBox4.Text);
                double L = serv.EtoL(E);
                textBox5.Text = L.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Valoarea introdusă în câmpul E nu este validă. Introduceți o valoare numerică validă.", "Eroare de conversie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
