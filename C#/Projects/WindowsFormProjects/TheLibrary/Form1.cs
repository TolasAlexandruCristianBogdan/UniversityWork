using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void label_mess_Click(object sender, EventArgs e)
        {

        }
        private void button_hello_Click(object sender, EventArgs e)
        {
            labelmess.Text = "MANAGE OUR BOOKS!";
        }

        private void button_hit_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("books1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(247, 189, 91), Color.FromArgb(189, 115, 62), LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 opens Form2 when the "Go forward!" button is click
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
