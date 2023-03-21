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
    /// Логика взаимодействия для Pag3.xaml
    /// </summary>
    public partial class Pag3 
    {
        public Pag3()
        {
            InitializeComponent();
            Infor3.Text = "Аккорд, который состоит из трёх звуков,\n" +
                " называют трезвучием.\r\nВ зависимости от того, какие терции участвуют\n" +
                " в построении трезвучия, а также\n" +
                " в зависимости от порядка терций, \n" +
                "мы получаем тот или иной вид трезвучия.\r\n" +
                "Обращение трезвучия:\r\n" +
                "Расположение звуков в порядке прима- терция- квинта " +
                "(снизу вверх) называется основным. \n" +
                "В этом случае звуки трезвучия расположены по терциям.\n Если порядок звуков изменяется так," +
                " что нижний звук становится терцией или квинтой,\n то такое положение звуков называется «обращением». " +
                "Как и у интервалов.";
        }

        private void Infor3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Info4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мажорное трезвучие состоит из б.3 и м.3.\n" +
                "Такое трезвучие называют ещё «большим».\n" +
                "Между его крайними звуками ч.5 (консонирующий интервал).Минорное трезвучие состоит из м.3 и б.3. " +
                "\nТакое трезвучие называют ещё «мáлым». \nМежду крайними звуками аккорда ч.5 \n" +
                "(консонирующий интервал).\nУвеличенное трезвучие состоит из б.3 и б.3.\n Между крайними звуками ув.5 (диссонирующий интервал).\nУменьшённое трезвучие состоит из м.3 и м.3.\nМежду крайними звуками ум.5 \n(диссонирующий интервал).", "Информация",MessageBoxButton.OK,MessageBoxImage.Information);

        }

        private void K2_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new temes());

        }
    }
}
