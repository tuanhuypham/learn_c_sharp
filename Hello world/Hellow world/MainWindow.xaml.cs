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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hellow_world
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string messageBoxText = "Hello can i help you";
        string caption = "notification";
        MessageBoxButton button = MessageBoxButton.YesNo;
        MessageBoxImage icon = MessageBoxImage.Warning;
        MessageBoxResult result;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        void showBox()
        {
            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            showBox(); 
        }
    }
}
