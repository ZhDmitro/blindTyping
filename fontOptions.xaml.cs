using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
namespace blindTyping
{  
    public partial class fontOptions : Window
    {
        public fontOptions()
        {
            InitializeComponent();
        }
        private void returnOptions_Click(object sender, RoutedEventArgs e)
        {
            options window = new options();
            this.Close();
            window.Show();
        }

        private void fontBut_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\workAdmin\source\repos\blindTyping\texts\font.txt";
            File.WriteAllText(path, ((Button)sender).Content.ToString());
        }
    }
}
