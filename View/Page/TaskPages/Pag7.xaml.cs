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
using static indProectAnohina.Core.Core;

namespace indProectAnohina.View.Page.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Pag7.xaml
    /// </summary>
    public partial class Pag7 
    {
        public Pag7()
        {
            InitializeComponent();
        }

        private void Sl1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sl9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void k7_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());
        }
    }
}
