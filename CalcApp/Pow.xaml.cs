using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using calc;
namespace firstlab
{
    /// <summary>
    /// Interaction logic for Pow.xaml
    /// </summary>
    public partial class Pow : Window
    {
        public Pow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            
            if ((!String.IsNullOrEmpty(A_p.Text)) && (!String.IsNullOrEmpty(B_p.Text)))
            {

                double a, b;
                if (Double.TryParse(A_p.Text, out a) && Double.TryParse(B_p.Text, out b))
                {
                    a = Double.Parse(A_p.Text);
                    b = Double.Parse(B_p.Text);
                    p.Text = calc.PowSqr.pow(a, b).ToString();
                    a = b = 0;
                }
                else p.Text = "введены не числа";
            }
            else p.Text = "введите значения";
        }
    }
}
