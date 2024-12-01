﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace KhabirovaMasterPol
{
    /// <summary>
    /// Логика взаимодействия для MasterPage.xaml
    /// </summary>
    public partial class MasterPage : Page
    {
        public MasterPage()
        {
            InitializeComponent();
            var Master = KhabirovaMasterPolEntities.GetContext().Partners.ToList();
            MasterListView.ItemsSource = Master;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var currentPartners = KhabirovaMasterPolEntities.GetContext().Partners.ToList();
            MasterListView.ItemsSource = currentPartners;
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MasterClass.MainFrame.Navigate(new AddEditPage(null));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MasterClass.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Partners));
        }
    }
}
