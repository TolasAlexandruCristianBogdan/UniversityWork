using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        // list to hold all of the names
        static List<String> names = new List<string>();

        BindingSource namesBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        internal void receivedata(string newName)
        {
            if (!names.Contains(newName))
            {
                names.Add(newName);
                namesBindingSource.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 opens Form2 when the "Go forward!" button is clicked
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // set the data source for the binding
            namesBindingSource.DataSource = names;

            // set the binding to the listbox
            listBox1.DataSource = namesBindingSource;

            // add the default names
            AddDefaultNames();
            this.Paint += new PaintEventHandler(Form2_Paint);

        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(247, 189, 91), Color.FromArgb(189, 115, 62), LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            // occurs whenever the form regains focus. comes back
            namesBindingSource.ResetBindings(false);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i >= 0)
            {
                DialogResult result = MessageBox.Show("Would you like to delete " + names[i] + "?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    names.RemoveAt(i);
                    namesBindingSource.ResetBindings(false);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "A->Z")
            {
                names.Sort();
            }
            else
            {
                names.Sort();
                names.Reverse();
            }
            namesBindingSource.ResetBindings(false);
        }

        private void AddDefaultNames()
        {
            names.Add("To Kill a Mockingbird");
            names.Add("The Great Gatsby");
            names.Add("The Da Vinci Code");
            names.Add("Dune");
            names.Add("The Lord of the Rings");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}