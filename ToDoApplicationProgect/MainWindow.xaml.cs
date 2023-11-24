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
        private static qweEntities _context;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Логика работы с базой данных при отсутствии базы данных
        public static qweEntities GetContext()
        {
            if (_context == null)
                _context = new qweEntities();
            return _context;
        }
            
        //Пользовательское окно обработки выхода
        private void Exit(object sender, RoutedEventArgs e)
        {
            Exitbox er1 = new Exitbox();
            er1.Height = 130;
            er1.Width = 300;
            er1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            er1.ShowDialog();
        }

      
        //переход на страницу задач
        private void ShowTask(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.TaskPage());
        }

        //переход на страницу категорий
        private void Category_Click(object sender, RoutedEventArgs e)
        {
           
            myFrame.Navigate(new ShowPage.CategoryPage());
        }

        //переход на страницу приоритета
        private void ShowPriority(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.PriorityPage());
        }

        //переход на страницу статуса
        private void ShowStatus(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.StatusPage());
        }
        //переход на страницу пользователей
        private void ShowUsers(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.UsersPage());
        }
    }
}
