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

namespace firstlab
{
    /// <summary>
    /// Interaction logic for Sqrt.xaml
    /// </summary>
    public partial class Sqrt : Window
    {
        public Sqrt()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if ((!String.IsNullOrEmpty(A_s.Text)) && (!String.IsNullOrEmpty(B_s.Text)))
            {

                double a, b;
                if (Double.TryParse(A_s.Text, out a) && Double.TryParse(B_s.Text, out b))
                {
                    a = Double.Parse(A_s.Text);
                    b = Double.Parse(B_s.Text);
                    s.Text = (calc.PowSqr.sqr(a, b).ToString() != "0") ? calc.PowSqr.sqr(a, b).ToString() : "отрицательное число и четная степень";
                    a = b = 0;
                }
                else s.Text = "введены не числа";
            }
            else s.Text = "введите значения";
        }
    }
}
