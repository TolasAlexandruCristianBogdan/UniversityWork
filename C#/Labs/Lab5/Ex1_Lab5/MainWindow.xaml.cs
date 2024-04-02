using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex1_Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "login.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] userData = line.Split(' ');
                    if (textbox1.Text == userData[0] && textbox2.Text == userData[1])
                    {
                        Window1 window1 = new Window1(userData[0]);
                        window1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!", "Error!");
                    }
                }

            }
        }

    }
}
