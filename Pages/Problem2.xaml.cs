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
            RadioButton rb = (RadioButton)sender; // явное преобразование object в RadioButton
            function = rb.Content.ToString();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(xTB.Text) & !String.IsNullOrEmpty(mTB.Text))
            {
                double x;
                double y;
                if (Double.TryParse(xTB.Text, out x) && Double.TryParse(mTB.Text, out y))
                {
                    
                    if(x > y)
                    {

                    }
                }
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
