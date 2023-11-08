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

namespace ToDoApplicationProgect.ShowPage
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        ToDoListEntities1 context;
        public TaskPage()
        {
            InitializeComponent();
            context = new ToDoListEntities1();
            DataGridTask.ItemsSource = context.Tasks.ToList();
        }

        private void CreateTask(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage.AddTaskPage(context));
        }

        private void DeleteTask(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены что хотите удалить данную задачу?", "Подтверждение", MessageBoxButton.YesNo);
            if(res == MessageBoxResult.Yes)
            {
                try
                {
                    Tasks tasks = DataGridTask.SelectedItem as Tasks;
                    context.Tasks.Remove(tasks);
                    context.SaveChanges();
                    NavigationService.Navigate(new TaskPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Данную задачу нельзя удалить");
                }
            }
        }
    }
}
