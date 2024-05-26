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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool counting = false;
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counting = !counting;
            if (counting)
            {
                count = 0;
                StartCounting();
            }
            else
            {
                CountTextBlock.Text = "";
            }
        }

        private async void StartCounting()
        {
            while (counting)
            {
                CountTextBlock.Text = count.ToString();
                await System.Threading.Tasks.Task.Delay(1000);
                count++;
            }
        }
    }
}
