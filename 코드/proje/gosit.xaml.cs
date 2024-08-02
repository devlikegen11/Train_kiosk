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
    /// gosit.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class gosit : Page
    {
        public gosit()
        {
            InitializeComponent();
            sitnum = new List<string>();
        }

        private void gotrainback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/train.xaml", UriKind.Relative));
        }

        private void paymoney_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gofinal.xaml", UriKind.Relative));
        }
        static public List<string> sitnum = new List<string>();
        private void A3_Click(object sender, RoutedEventArgs e)
        {
            //string sitA3 = A3.ToString();
            string sitA3 = "A3";
            sitnum.Add(sitA3);
            A3.IsEnabled = false;   // 버튼 클릭시 비활성화
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            string sitB2 = "B2";
            sitnum.Add(sitB2);
            B2.IsEnabled = false;
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            string sitC1 = "C1";
            sitnum.Add(sitC1);
            C1.IsEnabled = false;
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            string sitC2 = "C2";
            sitnum.Add(sitC2);
            C2.IsEnabled = false;
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            string sitC3 = "C3";
            sitnum.Add(sitC3);
            C3.IsEnabled = false;
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            string sitE3 = "E3";
            sitnum.Add(sitE3);
            E3.IsEnabled = false;
        }

        private void F1_Click(object sender, RoutedEventArgs e)
        {
            string sitF1 = "F1";
            sitnum.Add(sitF1);
            F1.IsEnabled = false;
        }
    }
}
