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

namespace lab03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp=null;
            if ((tb1.Text != "") || (tb2.Text != "")) {
                temp = tb1.Text;
                tb1.Text = tb2.Text;
                tb2.Text = temp;

            }
            else
            {
                MessageBox.Show("Мінімум одне поле повинно містити текст", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Window1 taskWindow = new Window1();
            taskWindow.Show();
        }
      
           
    }
}
