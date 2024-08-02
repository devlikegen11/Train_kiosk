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
    /// refinal.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class refinal : Page
    {
        public refinal()
        {
            InitializeComponent();
            godate.Text = _return.retrain[2];
            redate.Text = _return.retrain[3];
            godepart.Text = _return.retrain[0];
            goaproch.Text = _return.retrain[1];
            redepart.Text = _return.retrain[1];
            reaproch.Text = _return.retrain[0];
            gositfinal.Text = string.Join(",", resit1.regosit);
            resitfinal.Text = string.Join(",", resit2.resit);
            string money = _return.retrain[4];
            int setmoney = Convert.ToInt32(money);
            int pay = 30000 * setmoney;
            finalpay.Text = pay.ToString("#,##0") + "원";
        }

        private void fin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("결제 감사합니다.");

            NavigationService.Navigate(new Uri("/menu.xaml", UriKind.Relative));
        }

        private void gofinalback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/resit2.xaml", UriKind.Relative));
        }
    }
}
