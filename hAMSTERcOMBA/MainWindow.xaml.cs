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

namespace hAMSTERcOMBA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tap_counter = 0;
        int tap_mojitel = 1;
        bool tap_mnojitel_active = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Tap_reset_button(object sender, RoutedEventArgs e)
        {

            tap_counter = 0;
            Tap_counter.Content = "Тапов: " + tap_counter.ToString();
        }

        private void Tap_hamster(object sender, MouseButtonEventArgs e)
        {
            if (tap_mnojitel_active)
            {
                tap_counter += 1 + tap_mojitel;
            }
            else
            {
                tap_counter++;
            }
            
            Tap_counter.Content = "Тапов: " + tap_counter.ToString();
        }


        // Выбор биржи
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (hmstr_combobox.SelectedIndex) 
            { 
                case 0:
                    hmstr_birja.Text = "Биржа: Bibyt";
                    break;
                case 1:
                    hmstr_birja.Text = "Биржа: Binance";
                    break;
                case 2:
                    hmstr_birja.Text = "Биржа: Anima";
                    break;
             
            }
        }

        private void Tap_Mnojetel_1(object sender, RoutedEventArgs e)
        {
            if (tap_counter >= 250)
            {
                tap_mnojitel_active = true;
                tap_mojitel++;
            }
            else
            {
                tap_mnojitel_active = false;
                MessageBox.Show("У вас недостаточно тапов:" + tap_counter.ToString() + ". \nОсталось:" + (250-tap_counter));
            }
        }

        private void Tap_Mnojetel_3(object sender, RoutedEventArgs e)
        {
            if (tap_counter >= 500)
            {
                tap_mnojitel_active = true;
                tap_mojitel += 3;
            }
            else
            {
                tap_mnojitel_active = false;
                MessageBox.Show("У вас недостаточно тапов:" + tap_counter.ToString() + ". \nОсталось:" + (500 - tap_counter));
            }
        }

        private void Tap_Mnojetel_9(object sender, RoutedEventArgs e)
        {
            if (tap_counter >= 1000)
            {
                tap_mnojitel_active = true;
                tap_mojitel +=9;
            }
            else
            {
                tap_mnojitel_active = false;
                MessageBox.Show("У вас недостаточно тапов:" + tap_counter.ToString() + ". \nОсталось:" + (1000 - tap_counter));
            }
        }
    }
}
