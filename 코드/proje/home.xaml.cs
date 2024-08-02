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
    /// home.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void city_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buton1복사__C_복사__C__Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/menu.xaml", UriKind.Relative)
                );
        }

        private void oneway_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/one.xaml", UriKind.Relative)
                );
        }

        private void twoway_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/train.xaml", UriKind.Relative)
                );
        }
    }
}
