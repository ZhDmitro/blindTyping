using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
namespace blindTyping
{
    public partial class trtainingMenu : Window
    {
        public trtainingMenu()
        {
            InitializeComponent();
            string path = @"C:\Users\workAdmin\source\repos\blindTyping\texts\timer.txt";
            string[] time = File.ReadAllLines(path);
            one.Content += "   " + time[0];
            two.Content += "   " + time[1];
            three.Content += "   " + time[2];
            four.Content += "   " + time[3];
            fife.Content += "   " + time[4];
            six.Content += "   " + time[5];
            seven.Content += "   " + time[6];
            eight.Content += "   " + time[7];
            nine.Content += "   " + time[8];
            ten.Content += "   " + time[9];
            eleven.Content += "   " + time[10];
            twelve.Content += "   " + time[11];
            thirteen.Content += "   " + time[12];
            fourteen.Content += "   " + time[13];
            fifteen.Content += "   " + time[14];
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }
        //обработчик события нажатия кнопки выбора урока
        private void lesson_Click(object sender, RoutedEventArgs e)
        {
            train window = new train();
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
                case "ten":
                    window.buttonName = 10;
                    break;
                case "eleven":
                    window.buttonName = 11;
                    break;
                case "twelve":
                    window.buttonName = 12;
                    break;
                case "thirteen":
                    window.buttonName = 13;
                    break;
                case "fourteen":
                    window.buttonName = 14;
                    break;
                case "fifteen":
                    window.buttonName = 15;
                    break;
            }
            window.strInput();
        }
    }
}
