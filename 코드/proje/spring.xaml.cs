using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// spring.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class spring : Page
    {
        public spring()
        {
            InitializeComponent();
            packname.Text = one.packname[0];
            list = new List<string>();  // 리스트 초기화
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/one.xaml", UriKind.Relative)
                );
        }
        static public List<string> list = new List<string>();   // static - 이 필드가 클래스 차원에서 존재하며 모든 인스턴스에서 사용가능, 인스턴스화를 줄여준다(~~ = new~~하지 않고 list만 사용해도 가능) 
                                                               // public - 외부에서도 접근 가능하다.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = username.Text;
            string usernum = userfirnum.Text;
            string phone = phonnum.Text;
            string num = buynum.Text;
            list.Add(name);
            list.Add(usernum);
            list.Add(phone);
            list.Add(num);
            NavigationService.Navigate(new Uri("/springfinal.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            username.MaxLength = 8;     // 텍스트 박스 글자수 제한
            userfirnum.MaxLength = 6;   
            userlastnum.MaxLength = 7;
            phonnum.MaxLength = 11;
            buynum.MaxLength = 2;
        }

        private void userfirnum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void userlastnum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void phonnum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^010-[0-9]{4}-[0-9]{4}$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void buynum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
