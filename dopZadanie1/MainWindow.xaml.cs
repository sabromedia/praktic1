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

namespace dopZadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            double a1 = double.Parse(a1TextBox.Text);
            double b1 = double.Parse(b1TextBox.Text);
            double c1 = double.Parse(c1TextBox.Text);
            double a2 = double.Parse(a2TextBox.Text);
            double b2 = double.Parse(b2TextBox.Text);
            double c2 = double.Parse(c2TextBox.Text);

            double d = a1 * b2 - a2 * b1;

            if (d == 0)
            {
                resultLabel.Content = "Система не имеет единственного решения";
            }
            else
            {
                double x = (c1 * b2 - c2 * b1) / d;
                double y = (a1 * c2 - a2 * c1) / d;

                resultLabel.Content = "x = " + x.ToString() + ", y = " + y.ToString();
            }
        }
    }
}