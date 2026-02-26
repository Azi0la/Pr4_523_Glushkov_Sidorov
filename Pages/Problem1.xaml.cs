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

namespace Pr4_523_Glushkov_Sidorov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Problem1.xaml
    /// </summary>
    public partial class Problem1 : Page
    {
        public Problem1()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(xTB.Text) & !String.IsNullOrEmpty(yTB.Text) & !String.IsNullOrEmpty(zTB.Text))
            {
                double x;
                double y;
                double z;
                if(Double.TryParse(xTB.Text, out x) && Double.TryParse(yTB.Text, out y) && Double.TryParse(zTB.Text, out z))
                {
                    double a = Math.Abs(Math.Cos(x) - Math.Cos(y));
                    double b = (1+ 2*Math.Pow(Math.Sin(y), 2));
                    double c = Math.Pow(a, b);
                    double d = (1 + z + (Math.Pow(z, 2)/2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));
                    double answ = c * d;
                    answTB.Text = answ.ToString();
                }
                else
                {
                    MessageBox.Show("Введено не число");
                }
            }
            else
            {
                MessageBox.Show("Введены пустые значения");
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            xTB.Text = "";
            yTB.Text = "";
            zTB.Text = "";
            answTB.Text = "";
        }
    }
}
