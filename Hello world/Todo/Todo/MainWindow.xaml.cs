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

namespace Todo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> myList = new List<String>();
        object yourContainer;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        void ClickButton()
        {
            string textBoxValue = txtInput.Text;
            MessageBox.Show("The value you entered is: " + textBoxValue);
        }
        void addList()
        {
           String data = txtInput.Text;
           myList.Add(data);

        }
        TextBox CreateNewTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Width = 200;
            textBox.Height = 25;
            textBox.Margin = new Thickness(5);
            return textBox;
        }
        void showList()
        {
            StackPanel rowPanel = new StackPanel();
            rowPanel.Orientation = Orientation.Horizontal;
            foreach (var item in myList)
            {
               

                // Create a new TextBox instance
                TextBlock textBox = new TextBlock();
                textBox.Text = item.ToString();
                rowPanel.Children.Add(textBox);

                // Create a new CheckBox instance
                CheckBox checkBox = new CheckBox();
                checkBox.IsChecked = false;
                rowPanel.Children.Add(checkBox);

                //Add the StackPanel to the main StackPane
            }
            myStackPanel.Children.Add(rowPanel);
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
           
            addList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            showList();
        }
    }
}