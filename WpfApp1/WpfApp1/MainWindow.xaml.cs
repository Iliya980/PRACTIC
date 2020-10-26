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

namespace WpfApp1
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

        double a, b, y;
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtBoxA.Text);
            b = Convert.ToDouble(txtBoxB.Text);
            y = ((5*a*a)-(7*a)+2);

            if (y == b)
            {
                MessageBox.Show("Пройдет");
            }
            else
            {
                MessageBox.Show("Не пройдет");
            }
        }
    }
}
