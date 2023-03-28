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

namespace indProectAnohina.View.Page
{
    /// <summary>
    /// Логика взаимодействия для Pag5.xaml
    /// </summary>
    public partial class Pag5 
    {
        public Pag5()
        {
            InitializeComponent();
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes","Test",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void K5_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void C7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void C8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
