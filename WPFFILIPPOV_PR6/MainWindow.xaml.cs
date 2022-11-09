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

namespace WPFFILIPPOV_PR6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (pwBox.Password.ToString() == "Bruh" && logBox.Password.ToString() == "Bruh")
            {
                statusText.Text = "Верный bruh";
                Window1 window1 = new Window1();
                window1.Show();
            }
            else if (pwBox.Password.ToString() != "Bruh")
            {
                MessageBox.Show("Неверный пароль");
            }
            else if (logBox.Password.ToString() != "Bruh")
            {
                MessageBox.Show("Не найден логин");
            }
        }
    }
}
