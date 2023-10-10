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
using System.Windows.Shapes;

namespace ToDoApplicationProgect.CustomErrorWindow
{
    /// <summary>
    /// Логика взаимодействия для Exitbox.xaml
    /// </summary>
    public partial class Exitbox : Window
    {
        public Exitbox()
        {
            InitializeComponent();
        }
        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

    }
}
