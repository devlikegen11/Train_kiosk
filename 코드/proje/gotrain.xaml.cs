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
    /// gotrain.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class gotrain : Page
    {
        public gotrain()
        {
            InitializeComponent();
            depart.SelectedIndex = 0;
            approach.SelectedIndex = 1;
            //golist = new List<string>();
        }

        private void gotrainback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/train.xaml", UriKind.Relative)
                );
        }

        static public List<string> golist = new List<string> { "", "", "", "" };

        private void depart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                golist[0] = selectedItem.Content.ToString();
            }
        }

        private void approach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                golist[1] = selectedItem.Content.ToString();
            }
        }

        private void datepick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            golist[2] = datePicker.Text;
        }

        private void goperson_TextChanged(object sender, TextChangedEventArgs e)
        {
            goperson.MaxLength = 2;
            string goper = goperson.Text;
            golist[3] = goper;
        }

        private void gosit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gosit.xaml", UriKind.Relative));
        }
    }
}


