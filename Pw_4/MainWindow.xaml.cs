using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pw_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_about_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }        

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_add_to_list_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_sum_pair_elements_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cb_WorkWithPair_ChoosePair_Click(object sender, RoutedEventArgs e)
        {
            if (cb_WorkWithPair_ChoosePair.IsChecked == false)
            {
                lbl_first.Content = "Первый параметр:";
                lbl_second.Content = "Второй параметр";
                lbl_third.Visibility = Visibility.Collapsed;
                tb_third_parametr.Visibility = Visibility.Collapsed;
                btn_add_to_list.Visibility = Visibility.Visible;
                btn_sum_pair_elements.Visibility = Visibility.Collapsed;
            }
            else
            {
                lbl_first.Content = "Первый номер пары:";
                lbl_second.Content = "Второй номер пары:";
                lbl_third.Visibility = Visibility.Visible;
                tb_third_parametr.Visibility = Visibility.Visible;
                btn_add_to_list.Visibility = Visibility.Collapsed;
                btn_sum_pair_elements.Visibility = Visibility.Visible;
            }
        }
    }
}