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
using ToDoApplicationProgect.AddPage;
using ToDoApplicationProgect.EditPage;

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
            CategoryTable.ItemsSource = context.Categories.ToList();
        }

        private void EditCategory(object sender, RoutedEventArgs e)
        {
            Categories categories = CategoryTable.SelectedItem as Categories;
            NavigationService.Navigate(new EditCategoryPage(context, categories));
        }

        private void DeleteCategory(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены что хотите удалить данную категорию?", "Подтверждение", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                try
                {
                    Categories categories = CategoryTable.SelectedItem as Categories;
                    context.Categories.Remove(categories);
                    context.SaveChanges();
                    NavigationService.Navigate(new CategoryPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Удаление данной категории удалит категорию из всего приложения");
                }
            }
        }


        private void CreateCategory(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new AddCategoryPage(context));
           
        }
    }
}
