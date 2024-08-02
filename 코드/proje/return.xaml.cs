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
    /// _return.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class _return : Page
    {
        public _return()
        {
            InitializeComponent();
            depart.SelectedIndex = 0;
            approach.SelectedIndex = 1;
        }

        private void gotrainback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/train.xaml", UriKind.Relative)
                );
        }

        static public List<string> retrain = new List<string> { "", "", "", "", "" };

        private void depart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                retrain[0] = selectedItem.Content.ToString();
            }
        }

        private void approach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                retrain[1] = selectedItem.Content.ToString();
            }
        }

        private void datepick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            retrain[2] = datePicker.Text;
        }

        private void datereturn_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datereturn = sender as DatePicker;
            retrain[3] = datereturn.Text;
        }

        private void goperson_TextChanged(object sender, TextChangedEventArgs e)
        {
            goperson.MaxLength = 2;
            string goper = goperson.Text;
            retrain[4] = goper;
        }

        private void gobackoo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/resit1.xaml", UriKind.Relative));
        }

        
    }
}
