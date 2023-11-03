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

namespace ToDoApplicationProgect.EditPage
{
    /// <summary>
    /// Логика взаимодействия для EditCategoryPage.xaml
    /// </summary>
    public partial class EditCategoryPage : Page
    {
        ToDoListEntities1 context;
        public EditCategoryPage(ToDoListEntities1 cont)
        {
            InitializeComponent();
            context = cont;
        }


        private void BackCategory(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.CategoryPage()); 
        }

        //private void EditCategory(ToDoListEntities1 cont, Categories categories)
        //{
        //    NumberTextbox.Text = categories.id.ToString();

        //}

    }
}
