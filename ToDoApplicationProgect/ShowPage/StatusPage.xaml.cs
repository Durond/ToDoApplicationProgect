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
    /// Логика взаимодействия для StatusPage.xaml
    /// </summary>
    public partial class StatusPage : Page
    {
        ToDoListEntities1 context;
        public StatusPage()
        {
            InitializeComponent();
            context = new ToDoListEntities1();
            DataGridStatus.ItemsSource = context.Status.ToList();
        }

        private void CreateStatus(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddStatusPage(context));
        }

        private void DeleteStatus(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены что хотите удалить данный статус?", "Подтверждение", MessageBoxButton.YesNo);
                if (res == MessageBoxResult.Yes)
            {
                try
                {
                    Status status = DataGridStatus.SelectedItem as Status;
                    context.Status.Remove(status);
                    context.SaveChanges();
                    NavigationService.Navigate(new StatusPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Удаление данного Статуса затронет существующие связи");
                }
            }    
               
        }

  
    }
}
