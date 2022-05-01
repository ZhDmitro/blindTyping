using System;
using System.Windows;
namespace blindTyping
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Обработчик события нажатия на кнопку "Настройки" (option) главного окна
        private void Option_Click(object sender, RoutedEventArgs e)
        {
            options window = new options();
            this.Close();
            window.Show();
            
        }
        //Обработчик события нажатия на кнопку "Задания" (game) главного окна
        private void Game_Click(object sender, RoutedEventArgs e)
        {
            gameMenu1 window = new gameMenu1();
            this.Close();
            window.Show();
        }
        //Обработчик события нажатия на кнопку "Начать" (train) главного окна
        private void Train_Click(object sender, RoutedEventArgs e)
        {
            trtainingMenu window = new trtainingMenu();
            this.Close();
            window.Show();
        }
    }
}