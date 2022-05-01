using System;
using System.Windows;
using System.Windows.Controls;
namespace blindTyping
{
    public partial class gameMenu1 : Window
    {
        public gameMenu1()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            game window = new game();
            this.Close();
            window.Show();
            switch (((Button)sender).Name)
            {
                case "one":
                    window.buttonName = 1;
                    break;
                case "two":
                    window.buttonName = 2;
                    break;
                case "three":
                    window.buttonName = 3;
                    break;
                case "four":
                    window.buttonName = 4;
                    break;
                case "fife":
                    window.buttonName = 5;
                    break;
                case "six":
                    window.buttonName = 6;
                    break;
                case "seven":
                    window.buttonName = 7;
                    break;
                case "eight":
                    window.buttonName = 8;
                    break;
                case "nine":
                    window.buttonName = 9;
                    break;
            }
            window.textInput();
        }
    }
}