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
    /// Логика взаимодействия для Pag2.xaml
    /// </summary>
    public partial class Pag2 
    {
        public Pag2()
        {
            InitializeComponent();
            Infor.Text = "Интервалы в музыке — мера определения соотношения\n" +
                "между двумя звуками разной высоты.\n\r" +
                "Несмотря на то, что интервалы можно представить в " +
                "виде математической\n(соотношение двух чисел) или\r" +
                "акустической (центы) величины,\n музыкальная теория " +
                "пошла простым путем,\n рассчитав музыкальные интервалы " +
                "на основе звукоряда,\r\nв котором главная роль отведена количеству\n " +
                "тонов и полутонов между двумя нотами.";
            
        }

        private void K2_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());
        }

        private void Infor_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Info3_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new tema1());

        }
    }
}
