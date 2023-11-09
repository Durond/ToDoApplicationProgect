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
using ToDoApplicationProgect.ShowPage;

namespace ToDoApplicationProgect.CustomErrorWindow
{
    /// <summary>
    /// Логика взаимодействия для Successwindow.xaml
    /// </summary>
    public partial class Successwindow : Window
    {
        public Successwindow()
        {
            InitializeComponent();
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
