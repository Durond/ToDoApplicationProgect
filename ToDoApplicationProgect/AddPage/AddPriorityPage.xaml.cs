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
    /// Логика взаимодействия для AddPriorityPage.xaml
    /// </summary>
    public partial class AddPriorityPage : Page
    {
        //Работа с базой
        qweEntities context;
        public AddPriorityPage(qweEntities cont)
        {
            InitializeComponent();
            context = cont;
        }

        //Добавление приоритета в базу данных
        private void AddPriority(object sender, RoutedEventArgs e)
        {
            Priority priority = new Priority()
            {
                priorityId = Convert.ToInt32(NumberTextbox.Text),
                priority1 = PriorityTextBox.Text,
            };
           context.Priority.Add(priority);
           context.SaveChanges();
            MessageBox.Show("Приоритет добавлен", "Успешно", MessageBoxButton.OK);
            NavigationService.Navigate(new ShowPage.PriorityPage());
        }
        //Возвращение в окно приоритета
        private void BackPriority(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.PriorityPage());
        }
    }
}
