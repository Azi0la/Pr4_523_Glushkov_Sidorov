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
    /// Логика взаимодействия для Problem2.xaml
    /// </summary>
    public partial class Problem2 : Page
    {
        public static string function;
        public Problem2()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            function = rb.Content.ToString();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(xTB.Text) && !String.IsNullOrEmpty(mTB.Text))
            {
                double x;
                double y;
                if (Double.TryParse(xTB.Text, out x) && Double.TryParse(mTB.Text, out y))
                {

                    double fx;
                    switch (function)
                    {
                        case "sh(x)":
                            fx = Math.Sinh(x); 
                            break;
                        case "x^2":
                            fx = Math.Pow(x, 2);
                            break;
                        case "e^x":
                            fx = Math.Exp(x);
                            break;
                        default:
                            fx = Math.Sinh(x);
                            break;
                    }

                    double res;
                    if (x > y)
                    {
                        res = Math.Pow(fx - y, 3) + Math.Atan(fx);
                    }
                    else if (x < y) 
                    {
                        res = Math.Pow(y - fx, 3) + Math.Atan(fx);
                    }
                    else
                    {
                        res = Math.Pow(y + fx, 3) + 0.5;
                    }

                    AnsTB.Text = res.ToString();

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
            xTB.Clear();
            mTB.Clear();
            AnsTB.Clear();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) 
            {
                NavigationService.GoBack();
            }
        }
    }
}
