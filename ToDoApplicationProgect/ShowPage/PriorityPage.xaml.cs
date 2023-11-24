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
        //Работа с базой
        qweEntities context;
        public PriorityPage()
        {
            InitializeComponent();
            context = new qweEntities();
            DataGridPriority.ItemsSource = context.Priority.ToList();
        }

        //переход на страниццу создания приоритета
        private void CreatePriority(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPriorityPage(context));
        }

        //Логика при удалении приоритета
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
    }
}
