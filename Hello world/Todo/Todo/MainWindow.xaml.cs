using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        void add()
        {
            String data = txtinput.Text;
           // myList.Add(data);


            //#1: toi di hoc
            //myList[] -> add: toi di hoc
            //loop:myList[toi di hoc] -> itemList -> add toi di hoc, checkbox
            //itemList: [toi di hoc]

            //#2: lau nha
            //myList[toi di hoc] -> add: lau nha
            //loop:myList[toi di hoc, lau nha] -> [itemList -> add toi di hoc, checkbox] [itemList -> add lau nha, checkbox]
            //itemList: [toi di hoc, toi di hoc, lau nha]

            //#3
            //itemList: [toi di hoc, toi di hoc, lau nha,toi di hoc, toi di hoc, lau nha, di doc sach]

            //foreach (string value in myList)
            //{
                // Tạo một StackPanel mới chứa giá trị và CheckBox
                StackPanel newItem = new StackPanel();
                newItem.Orientation = Orientation.Horizontal;
                TextBlock textBlock = new TextBlock();
                textBlock.Text = data;
                CheckBox checkBox = new CheckBox();
                // Thêm StackPanel mới vào ItemsControl
                newItem.Children.Add(textBlock);
                newItem.Children.Add(checkBox);
                itemList.Items.Add(newItem);
            //}
        }
      
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String data = txtinput.Text;
            string inputValue = txtinput.Text;
            if (string.IsNullOrEmpty(txtinput.Text))
            {
                
                errorTextBlock.Text = "Please enter a value";
                errorTextBlock.Visibility = Visibility.Visible;
                txtinput.BorderBrush = Brushes.Red;
                return;
            }
         
            else
            {
                if (txtinput.Text != "")
                {
                    errorTextBlock.Visibility = Visibility.Collapsed;
                    txtinput.BorderBrush = Brushes.Black;
                    string messageBoxText = "ban da nhap du lieu";
                    string caption = "Thong bao";
                    MessageBoxButton button = MessageBoxButton.YesNo;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBoxResult result;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    add();
                }
            }
            txtinput.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //show();
            
        }
    }
}