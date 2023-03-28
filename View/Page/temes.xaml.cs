using indProectAnohina.View.Page.TaskPages;
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
    /// Логика взаимодействия для temes.xaml
    /// </summary>
    public partial class temes
    {
        public temes()
        {
            InitializeComponent();
            Caver5.Text = "Познавай тот ритм, что в жизни\nчеловеческой сокрыт.";
        }

       

        private void s1_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag1());

        }

        private void s2_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag2());
        }

        private void s3_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag3());

        }

        private void s4_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag4());
        }

        private void s5_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag5());
        }

        private void s6_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag6());

        }

        private void s7_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag7());
        }

        

        private void s10_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new MainPage());

        }

        private void Caver5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
