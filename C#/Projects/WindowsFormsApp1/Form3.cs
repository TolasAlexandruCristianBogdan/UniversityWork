using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //Close form 2 and show 1
            Form2 f2 = new Form2();

            f2.receivedata(textBox1.Text);

            // this refers to Form3
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form3_Paint);
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(247, 189, 91), Color.FromArgb(189, 115, 62), LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
