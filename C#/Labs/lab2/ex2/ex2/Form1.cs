using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Citim obiectele din fișier și le adăugăm în primul listBox
            string[] items = File.ReadAllLines("objects.txt");
            listBox1.Items.AddRange(items);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Verificăm dacă sunt selectate elemente în primul listBox
            if (listBox1.SelectedItems.Count > 0)
            {
                // Iterăm prin fiecare element selectat din primul listBox
                foreach (var selectedItem in listBox1.SelectedItems)
                {
                    // Adăugăm elementul în al doilea listBox
                    listBox2.Items.Add(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați cel puțin un obiect din lista din stânga.", "Alegere necesară", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verificăm dacă sunt selectate elemente în al doilea listBox
            if (listBox2.SelectedItems.Count > 0)
            {
                // Iterăm prin fiecare element selectat din al doilea listBox
                foreach (var selectedItem in listBox2.SelectedItems)
                {
                    // Ștergem elementul din al doilea listBox
                    listBox2.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați cel puțin un obiect din lista din dreapta.", "Alegere necesară", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Închidem aplicația la apăsarea butonului de ieșire
            Application.Exit();
        }
    }
}
