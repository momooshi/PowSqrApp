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
using calc;
namespace firstlab
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

        private void Pow_A_Click(object sender, RoutedEventArgs e)
        {
            Pow pow = new Pow();
            pow.Show();
            this.Close();
        }

        private void Sqr_x_Click(object sender, RoutedEventArgs e)
        {
            Sqrt sqrt = new Sqrt();
            sqrt.Show();
            this.Close();
        }
    }
}
