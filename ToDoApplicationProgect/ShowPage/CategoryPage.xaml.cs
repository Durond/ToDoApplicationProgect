using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        ToDoListEntities1 context;
        public CategoryPage()
        {
            InitializeComponent();
            context = new ToDoListEntities1();
            DataGridTask.ItemsSource = context.Categories.ToList();
        }

        private void EditCategory(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCategory(object sender, RoutedEventArgs e)
        {

        }

        private void CreateCategory(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new AddPage.AddCategoryPage());
        }
    }
}
