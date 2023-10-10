﻿using System;
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
using System.Windows.Shapes;
using ToDoApplicationProgect.CustomErrorWindow;

namespace ToDoApplicationProgect
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Exitbox er1 = new Exitbox();
            er1.Height = 130;
            er1.Width = 300;
            er1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            er1.ShowDialog();
        }

      

        private void ShowTask(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new ShowPage.TaskPage());
        }
    }
}
