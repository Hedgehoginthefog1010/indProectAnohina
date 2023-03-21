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
    /// Логика взаимодействия для Pag1.xaml
    /// </summary>
    public partial class Pag1 
    {
        public Pag1()
        {
            InitializeComponent();
            Infor1.Text= "Гаммы, наравне с музыкальными диатоническими ладами,\n" +
                " не только помогают понять, как устроена музыка,\n но и повышают мастерство музыканта." +
                "\r\n Знание структуры и состава гамм\n открывает доступ к свободной\n " +
                "импровизации в любой тональности,\n служит инструментом развития\n ловкости рук и пальцев музыканта.";
        }

        private void K1_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());

        }

        private void Info1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Фундаментальная гамма из семи нот, знакомая каждому с детства.\n Вокруг натуральной мажорной гаммы\n строится вся музыкальная теория.\nПринцип построения:\nТон, тон, полутон, тон, тон, тон, полутон", "Информация",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void Info2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Среди трех видов минорных гамм,\n натуральный минор – самый общий.\n В состав натурального минора\nвходят минорные трезвучия,\n что делает звучание минорной гаммы грустным и мрачным.\n\nПринцип построения:\nТон, полутон, тон, тон, полутон, тон, тон", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        

    }
}
}
