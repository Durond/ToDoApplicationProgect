using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            var statuslist = context.Status.ToList();
            statuslist.Insert(0, new Status() { status1 = "Все", statusid = 0 });
            StatusBox.ItemsSource = statuslist;
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

     

        public void RefreshData()
        {

            var list = context.Tasks.ToList();
            if(StatusBox.SelectedIndex>0)
            {
                Status stat = StatusBox.SelectedItem as Status;
                list = list.Where(x => x.Status1 == stat).ToList();
            }

           if(!string.IsNullOrWhiteSpace(Filtertextb.Text))
            {
                list = list.Where(x => x.UserName.ToLower().Contains(Filtertextb.Text.ToLower())).ToList();
            }
            DataGridTask.ItemsSource = list;
        }
   



        private void changename(object sender, TextChangedEventArgs e)
        {
            RefreshData();
        }

        private void Changestatus(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }
    }
}
