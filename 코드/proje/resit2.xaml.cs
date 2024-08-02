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

namespace proje
{
    /// <summary>
    /// resit2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class resit2 : Page
    {
        public resit2()
        {
            InitializeComponent();
        }

        private void retrainback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/resit1.xaml", UriKind.Relative));
        }

        static public List<string> resit = new List<string>();

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            string sitA2 = "A2";
            resit.Add(sitA2);
            A2.IsEnabled = false;
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            string sitA4 = "A4";
            resit.Add(sitA4);
            A4.IsEnabled = false;
        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            string sitD4 = "D4";
            resit.Add(sitD4);
            D4.IsEnabled = false;
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {
            string sitE1 = "E1";
            resit.Add(sitE1);
            E1.IsEnabled = false;
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            string sitE3 = "E3";
            resit.Add(sitE3);
            E3.IsEnabled = false;
        }

        private void refinal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/refinal.xaml", UriKind.Relative));
        }
    }
}