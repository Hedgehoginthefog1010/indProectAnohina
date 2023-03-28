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
    /// Логика взаимодействия для Pag6.xaml
    /// </summary>
    public partial class Pag6 
    {
        public Pag6()
        {
            InitializeComponent();
        }

        private void Sa1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void k6_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());
        }

        private void Sa3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Sa4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
