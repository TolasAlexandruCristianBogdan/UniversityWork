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

namespace Tema1VidicanIoanaBogdana
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path: "ciorbe.txt");
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
            }
            sr.Close();
            listBox1.SelectionMode = SelectionMode.One;


            StreamReader sr1 = new StreamReader(path: "main.txt");
            {
                string line1;
                while ((line1 = sr1.ReadLine()) != null)
                    listBox2.Items.Add(line1);
            }
            sr1.Close();
            listBox2.SelectionMode = SelectionMode.One;


            StreamReader sr2 = new StreamReader(path: "desert.txt");
            {
                string line2;
                while ((line2 = sr2.ReadLine()) != null)
                    listBox3.Items.Add(line2);
            }
            sr2.Close();
            listBox3.SelectionMode = SelectionMode.One;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            switch (a)
            {
                case 0:
                    pictureBox1.Image = new Bitmap("ciorba1.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    pictureBox1.Image = new Bitmap("ciorba2.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            }

        private void Soup_Click(object sender, EventArgs e)
        {

        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            int a2 = listBox3.SelectedIndex;
            switch (a2)
            {
                case 0:
                    pictureBox2.Image = new Bitmap("desert1.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    pictureBox2.Image = new Bitmap("desert2.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int a1 = listBox2.SelectedIndex;
            switch (a1)
            {
                case 0:
                    pictureBox3.Image = new Bitmap("main1.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    pictureBox3.Image = new Bitmap("main2.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
