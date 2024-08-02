using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    /// one.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class one : Page
    {
        public one()
        {
            InitializeComponent();
            packname = new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        static public List<string> packname = new List<string>();
        private void onepack1_Click(object sender, RoutedEventArgs e)
        {
            string pack = "1~2월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }

        private void onepack2_Click(object sender, RoutedEventArgs e)
        {
            string pack = "3~4월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }

        private void onepack3_Click(object sender, RoutedEventArgs e)
        {
            string pack = "5~6월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/home.xaml", UriKind.Relative)
                );
        }

        private void onepack4_Click(object sender, RoutedEventArgs e)
        {
            string pack = "7~8월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }

        private void onepack5_Click(object sender, RoutedEventArgs e)
        {
            string pack = "9~10월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }

        private void onepack6_Click(object sender, RoutedEventArgs e)
        {
            string pack = "11~12월 패키지";
            packname.Add(pack);
            NavigationService.Navigate(
                new Uri("/spring.xaml", UriKind.Relative)
                );
        }
    }
}
