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
using ToDoApplicationProgect.AddPage;
using ToDoApplicationProgect.CustomErrorWindow;

namespace ToDoApplicationProgect
{
    public partial class MainWindow : Window
    {
        private static ToDoListEntities1 _context;
        public MainWindow()
        {
            InitializeComponent();
        }

        public static ToDoListEntities1 GetContext()
        {
            if (_context == null)
                _context = new ToDoListEntities1();
            return _context;
        }
            

        private void Exit(object sender, RoutedEventArgs e)
        {
            Exitbox er1 = new Exitbox();
            er1.Height = 130;
            er1.Width = 300;
            er1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            er1.ShowDialog();
        }

      

        private void ShowTask(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.TaskPage());
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
           
            myFrame.Navigate(new ShowPage.CategoryPage());
        }

        private void ShowPriority(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.PriorityPage());
        }

        private void ShowStatus(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.StatusPage());
        }

        private void ShowUsers(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.UsersPage());
        }
    }
}
