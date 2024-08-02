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
    /// train.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class train : Page
    {
        public train()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/home.xaml", UriKind.Relative)
                );
        }
        private void gotrain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gotrain.xaml", UriKind.Relative));
        }

        private void gobacktrain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/return.xaml", UriKind.Relative));
        }
    }
}
