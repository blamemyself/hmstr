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
        bool strah_uzhas = false;
        double leftsave = 0;
        double topsave = 0;
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
            if (tap_counter >= 10000 && strah_uzhas == false)
            {
                strah_uzhas = true;
                this.Height = 1080;
                this.Width = 1920;
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                this.Topmost = true;
                leftsave = this.Left;
                topsave = this.Top;
                this.Left = 0;
                this.Top = 0;
                pes_strashilka.Visibility = Visibility.Visible;


            }
            else
            {
                if (tap_mnojitel_active)
                {
                    tap_counter += 1;
                    tap_counter += tap_mojitel;

                }
                else
                {
                    tap_counter++;
                }

                Tap_counter.Content = "Тапов: " + tap_counter.ToString();
            }
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
                    hmstr_birja.Text = "Биржа: Permaviat";
                    break;
             
            }
        }

        private void Tap_Mnojetel_1(object sender, RoutedEventArgs e)
        {
            if (tap_counter >= 250)
            {
                tap_mnojitel_active = true;
                tap_mojitel++;
                tap_counter -= 250;

                MessageBox.Show("Вы приобрели апгрейд для хомячка: +1 тап!!!");
                tap_mnoj.Content = "Множитель тапов: " + tap_mojitel.ToString();
                Tap_counter.Content = "Тапов: " + tap_counter.ToString();
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
                tap_counter -= 500;

                MessageBox.Show("Вы приобрели апгрейд для хомячка: +3 тапа!!!");
                tap_mnoj.Content = "Множитель тапов: " + tap_mojitel.ToString();
                Tap_counter.Content = "Тапов: " + tap_counter.ToString();
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
                tap_counter -= 1000;
                
                MessageBox.Show("Вы приобрели апгрейд для хомячка: +9 тапов!!!");
                tap_mnoj.Content = "Множитель тапов: " + tap_mojitel.ToString();
                Tap_counter.Content = "Тапов: " + tap_counter.ToString();
            }
            else
            {
                tap_mnojitel_active = false;
                MessageBox.Show("У вас недостаточно тапов:" + tap_counter.ToString() + ". \nОсталось:" + (1000 - tap_counter));
            }
        }

        private void Pes_click(object sender, MouseButtonEventArgs e)
        {
            pes_strashilka.Visibility = Visibility.Hidden;
            this.Height = 800;
            this.Width = 450;
            this.WindowState = WindowState.Normal;
            this.WindowStyle = WindowStyle.SingleBorderWindow;
            this.Topmost = false;
            this.Left = leftsave;
            this.Top = topsave;
        }
    }
}
