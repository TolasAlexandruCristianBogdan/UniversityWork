using System;
using System.Collections.Generic;
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

namespace Ex2_Lab5
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.rect.Fill = new SolidColorBrush(Color.FromArgb(255,
            Convert.ToByte(this.slider1.Value),
            Convert.ToByte(this.slider2.Value),
            Convert.ToByte(this.slider3.Value)));
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.rect.Fill = new SolidColorBrush(Color.FromArgb(255,
            Convert.ToByte(this.slider1.Value),
            Convert.ToByte(this.slider2.Value),
            Convert.ToByte(this.slider3.Value)));
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.rect.Fill = new SolidColorBrush(Color.FromArgb(255,
            Convert.ToByte(this.slider1.Value),
            Convert.ToByte(this.slider2.Value),
            Convert.ToByte(this.slider3.Value)));
        }
    }

    
}
