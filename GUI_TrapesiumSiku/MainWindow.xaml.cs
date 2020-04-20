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

namespace GUI_TrapesiumSiku
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
            TrapesiumSiku objek_1 = new TrapesiumSiku();
            objek_1.construct(4, 3, 5, 2, 7);

            MessageBox.Show("Luas:" + objek_1.luas());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TrapesiumSiku objek_2 = new TrapesiumSiku();
            objek_2.construct(1, 2, 8, 1, 9);

            MessageBox.Show("Keliling:" + objek_2.keliling());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TrapesiumSiku objek_3 = new TrapesiumSiku();
            objek_3.construct(5, 5, 1, 9, 12);

            MessageBox.Show("Luas:" + objek_3.luas());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TrapesiumSiku objek_4 = new TrapesiumSiku();
            objek_4.construct(13, 14, 16, 7, 9);

            MessageBox.Show("Keliling:" + objek_4.keliling());
        }
    }
}
