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
        Exception ex = new Exception();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ClearFirstSecond()
        {
            tb_first_parametr.Clear();
            tb_second_parametr.Clear();
        }
        public void ClearFirstSecondThird()
        {
            tb_first_parametr.Clear();
            tb_second_parametr.Clear();
            tb_third_parametr.Clear();
        }

        private void btn_about_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Виденин Андрей Антонович, ИСП-34, Практические работы №4,5,6\nПрактическая работа №4\r\nРабота с классами. Перегрузка методов.\r\n1. Разработать класс по заданию.\r\n2. Разработать программу для демонстрации использования класса и его методов.\r\n3. Предусмотреть в программе две кнопки «Выход» и «О программе», где вывести\r\nФИО разработчика, номер работы и формулировку задания.\n\n\n\r Вариант 2:\r\nСоздать класс Pair (пара чисел). Создать необходимые методы и свойства.\r\nОпределить методы метод сложения полей и операцию сложения пар (а, b) + (с, d)\r\n= (а + c, b + d). Создать перегруженные методы для увеличения полей на 1,\r\nсложения трех пар чисел.\n\n\n\rПрактическая работа №5\r\nОпределение операций в классе\r\n1. Доработать класс разработанный в практической работе №5 по заданию.\r\n2. Разработать программу для демонстрации использования операций класса.\r\n3. Предусмотреть в программе две кнопки «Выход» и «О программе», где вывести\r\nФИО разработчика, номер работы и формулировку задания.\n\n\rВариант 2:\r\nИспользовать класс Pair (пара чисел). Разработать операцию сложения пар (а, b) +\r\n(с, d) = (а + c, b + d). Разработать операцию для уменьшения полей на 1.\n\n\rПрактическая работа №6\r\nСоздание наследованных классов.\r\n1. Доработать класс разработанный в практической работе №6 по заданию.\r\n2. Разработать программу для демонстрации использования производного класса и\r\nего методов.\r\n3. Предусмотреть в программе две кнопки «Выход» и «О программе», где вывести\r\nФИО разработчика, номер работы и формулировку задания.\n\n\n\rИспользовать класс Pair (пара чисел). Определить класс-наследник Money с\r\nхарактеристиками: рубли и копейки. Переопределить операцию сложения и\r\nопределить методы вычитания и деления денежных сумм.");
        }        

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_add_to_list_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBox_of_objects.Items.Add(new Pair(Convert.ToInt32(tb_first_parametr.Text), Convert.ToInt32(tb_second_parametr.Text), listBox_of_objects.Items.Count + 1));
                ClearFirstSecond();
            }
            catch (Exception)
            {
                MessageBox.Show("Неккоректно введенные данные");
            }
        }
        private void btn_sum_pair_elements_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rb_one_object.IsChecked == true)
                {
                    Pair pair = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_first_parametr.Text) - 1];
                    MessageBox.Show($"Сумма элементов пары под номером {tb_first_parametr.Text} равна {pair.SumOfFirstSecond()}");
                }
                else if (rb_two_objects.IsChecked == true)
                {
                    Pair pair = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_first_parametr.Text) - 1];
                    Pair pair2 = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_second_parametr.Text) - 1];
                    MessageBox.Show($"Сумма элементов пар под номерами {tb_first_parametr.Text}, {tb_second_parametr.Text} равна {Pair.SumOfPair(pair, pair2)}");
                }
                else if (rb_three_objects.IsChecked == true)
                {
                    Pair pair = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_first_parametr.Text) - 1];
                    Pair pair2 = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_second_parametr.Text) - 1];
                    Pair pair3 = (Pair)listBox_of_objects.Items[Convert.ToInt32(tb_third_parametr.Text) - 1];
                    MessageBox.Show($"Сумма элементов пар под номерами {tb_first_parametr.Text}, {tb_second_parametr.Text}, {tb_third_parametr.Text} равна {Pair.SumOfPair(pair, pair2, pair3)}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неккоректно введенные данные");
            }
        }
        private void cb_WorkWithPair_ChoosePair_Unchecked(object sender, RoutedEventArgs e)
        {
            rb_three_objects.IsChecked = true;
            lbl_first.Content = "Первый параметр:";
            lbl_second.Content = "Второй параметр";
            ClearFirstSecondThird();
            rb_one_object.Visibility = Visibility.Collapsed;
            rb_two_objects.Visibility = Visibility.Collapsed;
            lbl_third.Visibility = Visibility.Collapsed;
            tb_third_parametr.Visibility = Visibility.Collapsed;
            rb_three_objects.Visibility = Visibility.Collapsed;
            btn_add_to_list.Visibility = Visibility.Visible;
            btn_sum_pair_elements.Visibility = Visibility.Collapsed;
        }

        private void cb_WorkWithPair_ChoosePair_Checked(object sender, RoutedEventArgs e)
        {
            lbl_first.Content = "Первый номер пары:";
            lbl_second.Content = "Второй номер пары:";
            ClearFirstSecond();
            rb_one_object.Visibility = Visibility.Visible;
            rb_two_objects.Visibility = Visibility.Visible;
            lbl_third.Visibility = Visibility.Visible;
            tb_third_parametr.Visibility = Visibility.Visible;
            rb_three_objects.Visibility = Visibility.Visible;
            btn_add_to_list.Visibility = Visibility.Collapsed;
            btn_sum_pair_elements.Visibility = Visibility.Visible;
        }
        private void listBox_of_objects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_WorkWithPair_ChoosePair.IsChecked == false)
            {
                if (listBox_of_objects.SelectedIndex == -1)
                {
                    btn_delete_item.Visibility = Visibility.Collapsed;
                    btn_change_item.Visibility = Visibility.Collapsed;
                }
                else if (btn_delete_item.Visibility == Visibility.Visible)
                {
                    Pair pair = (Pair)listBox_of_objects.Items[listBox_of_objects.SelectedIndex];
                    tb_first_parametr.Text = $"{pair.first}";
                    tb_second_parametr.Text = $"{pair.second}";
                }
                else
                {
                    btn_delete_item.Visibility = Visibility.Visible;
                    btn_change_item.Visibility = Visibility.Visible;
                    Pair pair = (Pair)listBox_of_objects.Items[listBox_of_objects.SelectedIndex];
                    tb_first_parametr.Text = $"{pair.first}";
                    tb_second_parametr.Text = $"{pair.second}";
                }
            }
        }
        private void btn_change_item_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int first_fromTB = Convert.ToInt32(tb_first_parametr.Text);
                int second_fromTB = Convert.ToInt32(tb_second_parametr.Text);
                Pair pair = (Pair)listBox_of_objects.Items[listBox_of_objects.SelectedIndex];
                if ((pair.first == first_fromTB) && (pair.second == second_fromTB))
                {
                    MessageBox.Show("Введенные параметры ничем ни отличаются от уже имеющихся, изменение не применено");
                }
                else
                {
                    pair.first = first_fromTB;
                    pair.second = second_fromTB;
                    listBox_of_objects.Items[listBox_of_objects.SelectedIndex] = pair;
                    ClearFirstSecond();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неккоректно введенные данные");
            }
        }
        private void btn_delete_item_Click(object sender, RoutedEventArgs e)
        {
            listBox_of_objects.Items.RemoveAt(listBox_of_objects.SelectedIndex);
            ClearFirstSecond();
        }

        private void rb_one_object_Checked(object sender, RoutedEventArgs e)
        {   
            ClearFirstSecondThird();
            tb_second_parametr.IsEnabled = false;
            tb_third_parametr.IsEnabled = false;
        }

        private void rb_two_objects_Checked(object sender, RoutedEventArgs e)
        {
            ClearFirstSecondThird();
            tb_second_parametr.IsEnabled = true;
            tb_third_parametr.IsEnabled = false;
        }

        private void rb_three_objects_Checked(object sender, RoutedEventArgs e)
        {
            ClearFirstSecondThird();
            tb_second_parametr.IsEnabled = true;
            tb_third_parametr.IsEnabled = true;
        }
    }
}