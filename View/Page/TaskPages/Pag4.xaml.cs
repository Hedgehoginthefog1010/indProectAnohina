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
    /// Логика взаимодействия для Pag4.xaml
    /// </summary>
    public partial class Pag4
    {
        public Pag4()
        {
            InitializeComponent();
            Infor4.Text = "Среди трех видов минорных гамм,натуральный минор – самый общий. \r\n" +
                "В состав натурального минора входят минорные трезвучия,\nчто делает звучание минорной гаммы грустным и мрачным." +
                "\r\n\nГармонический минор – разновидность натурального минора с повышенной VII ступенью. \r\nПовышенная VII ступень имитирует\nвводный тон и " +
                "позволяет строить мажорные интервалы в минорных тональностях.\r\n\nMелодический минор меняет свое звучание \n" +
                "в зависимости от того, в какую сторону движется звукоряд.\r\nМелодический минор также называют джазовым минором.\n\r" +
                "В полной версии мелодического минора при движении\n вверх исполняется мелодический минор,\n а при движении вниз – натуральный минор.";
        }
        

        private void K4_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());

        }

        private void Infor4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
