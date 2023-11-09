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

namespace ToDoApplicationProgect.AddPage
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        ToDoListEntities1 context;
        public AddUserPage(ToDoListEntities1 cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void AddCategory(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                id = Convert.ToInt32(TabnumTextbox.Text),
                name = FioTextBox.Text,
                password = PassTextBox.Text,
            };
            context.Users.Add(users);
            context.SaveChanges();
            NavigationService.Navigate(new ShowPage.UsersPage());
        }

        private void BackUsers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.UsersPage());
        }
    }
}
