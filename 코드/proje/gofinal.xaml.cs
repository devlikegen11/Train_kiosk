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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proje
{
    /// <summary>
    /// gofinal.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class gofinal : Page
    {
        public gofinal()
        {
            InitializeComponent();
            depart.Text = gotrain.golist[0];
            aproch.Text = gotrain.golist[1];
            date.Text = gotrain.golist[2];
            sitfinal.Text = String.Join(",", gosit.sitnum); // ,로 끊어서 리스트 출력
            string money = gotrain.golist[3];
            int setmoney = Convert.ToInt32(money);
            int pay = 30000 * setmoney;
            finalpay.Text = pay.ToString("#,##0") + "원";
        }

        private void gofinalback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gotrain.xaml", UriKind.Relative));
        }

        private void fin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("결제 감사합니다.");

            NavigationService.Navigate(new Uri("/menu.xaml", UriKind.Relative));
        }
    }
}
