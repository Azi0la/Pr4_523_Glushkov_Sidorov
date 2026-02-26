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
    /// Логика взаимодействия для Problem3.xaml
    /// </summary>
    public partial class Problem3 : Page
    {
        public Problem3()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(XoTB.Text) && !String.IsNullOrEmpty(XkTB.Text) && !String.IsNullOrEmpty(DxTB.Text))
            {
                double xo, xk, dx, result;
                if (Double.TryParse(XoTB.Text, out xo) && Double.TryParse(XkTB.Text, out xk) && Double.TryParse(DxTB.Text, out dx))
                {
                    for (double i = xo; i <= xk; i += dx)
                    {
                        
                    }
                   
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
            XoTB.Clear();
            XkTB.Clear();
            AnsTB.Clear();
        }
    }
}
