using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
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
            Chart.ChartAreas.Add(new ChartArea("Main"));
            var currentSeries = new Series("Res")
            {
                IsValueShownAsLabel = true
            };
            Chart.Series.Add(currentSeries);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            AnsTB.Clear();
            if (!String.IsNullOrEmpty(XoTB.Text) && !String.IsNullOrEmpty(XkTB.Text) 
                && !String.IsNullOrEmpty(DxTB.Text) && !String.IsNullOrEmpty(aTB.Text)
                && !String.IsNullOrEmpty(bTB.Text))
            {
                double xo, xk, dx, a, b, result;
                if (Double.TryParse(XoTB.Text, out xo) && Double.TryParse(XkTB.Text, out xk) 
                    && Double.TryParse(DxTB.Text, out dx) && Double.TryParse(aTB.Text, out a)
                    && Double.TryParse(bTB.Text, out b))
                {

                    Series series = Chart.Series.FirstOrDefault();
                    series.Points.Clear();
                    for (double i = xo; i <= xk; i += dx)
                    {
                        result = a * Math.Pow(i, 3) + Math.Pow(Math.Cos(Math.Pow(i, 3) - b), 2);
                        AnsTB.Text += result;
                        AnsTB.Text += "\n";

                        series.Points.AddXY(i.ToString(), result);

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
            DxTB.Clear();
            aTB.Clear();
            bTB.Clear();
            AnsTB.Clear();
        }

        
    }

}
