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
    /// Логика взаимодействия для PriorityPage.xaml
    /// </summary>
    public partial class PriorityPage : Page
    {
        ToDoListEntities1 context;
        public PriorityPage()
        {
            InitializeComponent();
            context = new ToDoListEntities1();
            DataGridPriority.ItemsSource = context.Priority.ToList();
        }

        private void CreatePriority(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPriorityPage(context));
        }

        private void DeletePriority(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены что хотите удалить данный приоритет?", "Подтверждение", MessageBoxButton.YesNo);
                if(res == MessageBoxResult.Yes)
            {
                try
                {
                    Priority priority = DataGridPriority.SelectedItem as Priority;
                    context.Priority.Remove(priority);
                    context.SaveChanges();
                    NavigationService.Navigate(new PriorityPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Удаление данного приоритета удалит приоритет взаимосвзанных записей");
                }
            }
        }

        private void EditPriority(object sender, RoutedEventArgs e)
        {

        }
    }
}
