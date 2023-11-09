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

namespace ToDoApplicationProgect.ShowPage
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        ToDoListEntities1 context;
        public UsersPage()
        {
            InitializeComponent();
            context = new ToDoListEntities1();
            UserTable.ItemsSource = context.Users.ToList();
        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {

            MessageBoxResult res = MessageBox.Show("Вы уверены что хотите удалить данного пользователя?", "Подтверждение", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                try
                {
                   Users users = UserTable.SelectedItem as Users;
                    context.Users.Remove(users);
                    context.SaveChanges();
                    NavigationService.Navigate(new UsersPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "У данного пользователя еще есть невыполненая задача");
                }
            }

        }

        private void CreateUser(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUserPage(context));
        }
    }
}
