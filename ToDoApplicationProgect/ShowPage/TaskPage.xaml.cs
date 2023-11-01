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
    }
}
