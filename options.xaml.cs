using System;
using System.IO;
using System.Windows;
namespace blindTyping
{
    public partial class options : Window
    {
        public options()
        {
            InitializeComponent();
            string path = @"C:\Users\workAdmin\source\repos\blindTyping\texts\timer.txt";
            string[] allStr = File.ReadAllLines(path);
            if (allStr[15] == "true")
            {
                ErrorCheck.IsChecked = true;
            }
            else
            {
                ErrorCheck.IsChecked = false;
            }
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\workAdmin\source\repos\blindTyping\texts\timer.txt";
            string[] allStr = File.ReadAllLines(path);
            if ((bool)ErrorCheck.IsChecked)
            {
                allStr[15] = "true";
            }
            else
            {
                allStr[15] = "false";
            }
            File.WriteAllLines(path, allStr);
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void fontOption_Click(object sender, RoutedEventArgs e)
        {
            fontOptions window = new fontOptions();
            this.Close();
            window.Show();
        }
    }
}
