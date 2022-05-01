using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
namespace blindTyping
{
    public partial class game : Window
    {
        public game()
        {
            InitializeComponent();
            textWrite.AcceptsReturn = true;
            string fontPath = @"C:\Users\workAdmin\source\repos\blindTyping\texts\font.txt";
            string fontName = File.ReadAllText(fontPath);
            FontFamily f = new FontFamily(fontName);
            textWrite.FontFamily = f;
        }
        public int buttonName;
        
        string textAdress = @"C:\Users\workAdmin\source\repos\blindTyping\texts\";
        public void textInput()
        {
            switch (buttonName)
            {
                case 1:
                    textAdress += "kipling.txt";
                    break;
                case 2:
                    textAdress += "merezhkovskiy.txt";
                    break;
                case 3:
                    textAdress += "lermontov.txt";
                    break;
                case 4:
                    textAdress += "esenin.txt";
                    break;
                case 5:
                    textAdress += "nekrasov.txt";
                    break;
                case 6:
                    textAdress += "brodskiy.txt";
                    break;
                case 7:
                    textAdress += "evtushenko.txt";
                    break;
                case 8:
                    textAdress += "asadov.txt";
                    break;
                case 9:
                    textAdress += "pushkin.txt";
                    break;
            }

            Text.Text = File.ReadAllText(textAdress);
        }
        private void return_GameMenu_Click(object sender, RoutedEventArgs e)
        {
            gameMenu1 window = new gameMenu1();
            this.Close();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int errorCount = Text.Text.Length;
            if (Text.Text.Length >= textWrite.Text.Length)
            {
                for (int i = 0; i < textWrite.Text.Length; i++)
                {
                    if (textWrite.Text[i] == Text.Text[i])
                    {
                        errorCount--;
                    }
                }
                if (errorCount == 0)
                {
                    resBut.Content = "Все верно";
                }
                else
                {
                    resBut.Content = "Кол-во ошибок: " + errorCount;
                }
            }
        }
    }
}
