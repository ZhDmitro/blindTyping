using System;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace blindTyping
{
    public partial class train : Window
    {
        public train()
        {
            InitializeComponent();
        }
        public DateTime time1 = new DateTime();
        public DateTime time2 = new DateTime();
        Hashtable vocabulary = new Hashtable();
        public int buttonName;
        int errorNum = 0;
        public bool canRemove = false;
        public string[] symbCode = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "OemOpenBrackets", "Oem6", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Oem1", "OemQuotes", "Z", "X", "C", "V", "B", "N", "M", "OemComma", "OemPeriod", "Space" };
        public void strInput()
        {
            //выбор текста отображающегося в текстовом поле(TextBlock) strText, зависит от  поля buttonName,
            //значение которого задается в обработчике событий lessonClick в модуле trtainingMenu.cs
            switch (buttonName)
            {
                case 1:
                    strText.Text = "фыва олдж авыф ждло фыол вадж фаож вылд фж ыд вл ао дыл фыл фыждл ф жлдыф фылд выфлыф вд жфы олвы вадвыо дыфо ыалд жд";
                    break;
                case 2:
                    strText.Text = "вол пожал провода выл пол дылда эволар роды права жды фол паровол лэ рофл фора два дэло продавал лады жора врал воров";
                    break;
                case 3:
                    strText.Text = "мир трон лень коронованы лодка ладонь дорожить эллада ноги горожане ждать капкан порода пока логи примеры головоломка";
                    break;
                case 4:
                    strText.Text = "увалень шарманка сорока шлем барабан быть лошадинное село лось паром переправа желоб финны фанера лук куль дерево нож";
                    break;
                case 5:
                    strText.Text = "цирк вышка долина юра человек чучело керосин щука цитрус юла гусь афины вожжи мюсли филин праща щавель нарцис индивид";
                    break;
                case 6:
                    strText.Text = "йога замер колосья яблоня электросамокат хризантемы подъезд пьедестал хурма журавель йогурт ясли эмиссия хоровод заря";
                    break;
                case 7:
                    strText.Text = "вафельный торт жреческий плащ вишневый сад фиолетовое платье разумная жизнь партийный съезд курсовой проект лысый кот";
                    break;
                case 8:
                    strText.Text = "я могу неплохо печатать вслепую я могу хорошо печатать вслепую я отлично печатаю вслепую я печатаю вслепую без ошибок";
                    break;
                case 9:
                    strText.Text = "для того чтобы научиться печатать вслепую не нужно торопиться нужно просто много тренироваться и стараться делать все";
                    break;
                case 10:
                    strText.Text = "франк эдгар макгуррин придумал слепой метод печати в одна тысяча восемьсот восемьдесят восьмом году и получил награду";
                    break;
                case 11:
                    strText.Text = "слепой десятипальцевый метод печати имеет свои неоспоримые преимущества в скорости и удобстве печатания на клавиатуре";
                    break;
                case 12:
                    strText.Text = "расположение клавиш на современных клавиатурах стандартизовано поэтому наиболее часто встречающиеся буквы расположены";
                    break;
                case 13:
                    strText.Text = "тренированный работник может не глядя печатать от двухсот до четырехсот символов за минуту значительно меньше уставая.";
                    break;
                case 14:
                    strText.Text = "после обучения ты сможешь быстро перепечатывать конспекты лекций и необходимый материал из учебников это очень хорошо.";
                    break;
                case 15:
                    strText.Text = "это приложение поможет быстрее освоить навык слепого десятипальцевого печатания или поднять его на более высокий уровень.";
                    break;
            }
        }
        public void addVocabulary()
        {
            vocabulary.Add("Q", 'й');
            vocabulary.Add("W", 'ц');
            vocabulary.Add("E", 'у');
            vocabulary.Add("R", 'к');
            vocabulary.Add("T", 'е');
            vocabulary.Add("Y", 'н');
            vocabulary.Add("U", 'г');
            vocabulary.Add("I", 'ш');
            vocabulary.Add("O", 'щ');
            vocabulary.Add("P", 'з');
            vocabulary.Add("OemOpenBrackets", 'х');
            vocabulary.Add("Oem6", 'ъ');
            vocabulary.Add("A", 'ф');
            vocabulary.Add("S", 'ы');
            vocabulary.Add("D", 'в');
            vocabulary.Add("F", 'а');
            vocabulary.Add("G", 'п');
            vocabulary.Add("H", 'р');
            vocabulary.Add("J", 'о');
            vocabulary.Add("K", 'л');
            vocabulary.Add("L", 'д');
            vocabulary.Add("Oem1", 'ж');
            vocabulary.Add("OemQuotes", 'э');
            vocabulary.Add("Z", 'я');
            vocabulary.Add("X", 'ч');
            vocabulary.Add("C", 'с');
            vocabulary.Add("V", 'м');
            vocabulary.Add("B", 'и');
            vocabulary.Add("N", 'т');
            vocabulary.Add("M", 'ь');
            vocabulary.Add("OemComma", 'б');
            vocabulary.Add("OemPeriod", 'ю');
            vocabulary.Add("Space", ' ');
        }
        //обработчик события  нажатия кнопки "назад" окна train
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            trtainingMenu window = new trtainingMenu();
            this.Close();
            window.Show();
        }
        //обработчик события нажатия кнопки "начать" в окне train 
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //добавление словаря для возможности считывать введенные с клавиатуры символы и сравнивать их со строкой
            addVocabulary();
            canRemove = true;
            startBut.IsEnabled = false;
            DateTime time = DateTime.Now;
            time1 = time;
            //time1.Subtract(time2);
        }
        // обработчик события нажатия клавиш(если canRemove=true)
        private void strText_KeyDown(object sender, KeyEventArgs e)
        {
            bool IsRuSymbol = false;
            string path = @"C:\Users\workAdmin\source\repos\blindTyping\texts\timer.txt";
            string[] allStrTime = File.ReadAllLines(path);
            foreach (string str in symbCode)
            {
                if (str == e.Key.ToString())
                {
                    IsRuSymbol = true;
                }
            }
            if (canRemove && IsRuSymbol && vocabulary[e.Key.ToString()].ToString() == strText.Text[0].ToString()) 
            {
                strText.Text = strText.Text.Remove(0, 1);
                strText.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("#75ebc9");
            }
            else if (canRemove)
            {
                errorNum++;
                if (allStrTime[15] == "true")
                {
                    //Background back=Background.
                    strText.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                }
            }
            
            if (strText.Text.Length == 0)
            {
                canRemove = false;
                strText.Text = "Урок пройден; Кол-во ошибок: " + errorNum;
                DateTime time = DateTime.Now;
                time2 = time;
                string strTime= time2.Subtract(time1).ToString();
                strTime = strTime.Remove(8);
                strTime = strTime.Remove(0, 3);
                startBut.Content = strTime;
                allStrTime[buttonName - 1] = strTime;
                File.WriteAllLines(path, allStrTime);
            }
            
        }
    }
    
}
