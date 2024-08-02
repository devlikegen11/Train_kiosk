using proje;
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
    /// springfinal.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class springfinal : Page
    {
        public springfinal()
        {
            InitializeComponent();
            buyer.Text = spring.list[0]; // 다른 페이지지만 같은 공간인 proje에서 작성되고 있기떄문에 spring 페이지에서 static public으로 만든 list를 사용 가능하다.
            packname.Text = one.packname[0];
            buyernum.Text = spring.list[3] + "명";
            string n = spring.list[3];
            int outValue = Convert.ToInt32(n);
            int money = 53000 * outValue;
            bloock.Text = money.ToString("#,##0") + "원";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/spring.xaml", UriKind.Relative));
        }

        private void money_Click(object sender, RoutedEventArgs e)
        {
            string name = spring.list[0];
            MessageBox.Show($"{name}님 결제 감사합니다.");

            NavigationService.Navigate(new Uri("/menu.xaml", UriKind.Relative));
        }
    }
}
