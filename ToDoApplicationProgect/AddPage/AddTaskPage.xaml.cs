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
    /// Логика взаимодействия для AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        ToDoListEntities1 context;
        public AddTaskPage(ToDoListEntities1 cont)
        {
            InitializeComponent();
            context = cont;
            TaskPriorityTextbox.ItemsSource = cont.Priority.ToList();
            TaskStatusTextBox.ItemsSource = cont.Status.ToList();
            UserIdTextBox.ItemsSource = cont.Users.ToList();
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            Tasks tasks = new Tasks()
            {
                id = Convert.ToInt32(taskIdTextbox.Text),
                title = TaskNameTextbox.Text,
                description = DescriptionTextBox.Text,
                priority = (TaskPriorityTextbox.SelectedItem as Priority).priorityId,
                 due_date = Convert.ToDateTime(DatastarttaskTextbox.Text),
                 status = (TaskStatusTextBox.SelectedItem as Status).statusid,
                 created_at =Convert.ToDateTime(DatataskcreateTextBox.Text),
                 user_id=(UserIdTextBox.SelectedItem as Users).id,
            };
            context.Tasks.Add(tasks);
            context.SaveChanges();
            NavigationService.Navigate(new ShowPage.TaskPage());

        }

        private void BackTask(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.TaskPage());
        }
    }
}
