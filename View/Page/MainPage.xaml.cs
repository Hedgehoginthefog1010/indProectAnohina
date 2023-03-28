using indProectAnohina.Core;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Randomer_Click(object sender, RoutedEventArgs e)
        {
            Random n= new Random();
             int o=n.Next(1,7);

            if (o == 1)
            {
                MessageBox.Show("Ваша тема - 1","тема",MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 2)
            {
                MessageBox.Show("Ваша тема - 2", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 3)
            {
                MessageBox.Show("Ваша тема - 3", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 4)
            {
                MessageBox.Show("Ваша тема - 4", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 5)
            {
                MessageBox.Show("Ваша тема - 5", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 6)
            {
                MessageBox.Show("Ваша тема - 6", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (o == 7)
            {
                MessageBox.Show("Ваша тема - 7", "тема", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            

        }

        
            
            
            
        

        

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вам надоело???", "грустно", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обучающее приложение, в котором вам выпадет номер темы.\n Нажмите,получите и перейдите темы","Инструктаж",
                MessageBoxButton.OK,
                MessageBoxImage.Information) ;
        }

        private void tema_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());
        }
    }
}
