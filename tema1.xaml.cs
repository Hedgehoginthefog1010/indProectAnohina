using indProectAnohina.View.Page;
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

namespace indProectAnohina
{
    /// <summary>
    /// Логика взаимодействия для tema1.xaml
    /// </summary>
    public partial class tema1 
    {
        public tema1()
        {
            InitializeComponent();
        }

        private void Mane_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new Pag2());
        }
    }
}
