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
    /// resit1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class resit1 : Page
    {
        public resit1()
        {
            InitializeComponent();
        }

        private void retrainback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/return.xaml", UriKind.Relative));
        }

        static public List<string> regosit = new List<string>();
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            string sitC1 = "C1";
            regosit.Add(sitC1);
            C1.IsEnabled = false;
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            string sitE3 = "E3";
            regosit.Add(sitE3);
            E3.IsEnabled = false;
        }

        private void F1_Click(object sender, RoutedEventArgs e)
        {
            string sitF1 = "F1";
            regosit.Add(sitF1);
            F1.IsEnabled = false;
        }

        private void repaymoney_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/resit2.xaml", UriKind.Relative));
        }
    }
}
