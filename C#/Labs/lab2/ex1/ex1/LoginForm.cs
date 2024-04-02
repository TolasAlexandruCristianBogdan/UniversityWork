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

namespace ex1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckCredentialsFromFile(string username, string password)
        {
            // Specificați calea către fișierul în care sunt stocate utilizatorii și parolele
            string filePath = "logindata.txt";

            // Citim fiecare linie din fișier și verificăm dacă se potrivește cu utilizatorul și parola introduse
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string storedUsername = parts[0];
                string storedPassword = parts[1];

                if (username == storedUsername && password == storedPassword)
                {
                    return true; 
                }
            }
            return false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (CheckCredentialsFromFile(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
        
        
    }
}
                    
                
    

