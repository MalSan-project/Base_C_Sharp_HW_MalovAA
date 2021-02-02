using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BC_HW_L5_Malov
//2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
//    а) Вывести только те слова сообщения, которые содержат не более n букв.
//    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//    в) Найти самое длинное слово сообщения.
//    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//    Продемонстрируйте работу программы на текстовом файле с вашей программой.

//3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать:
//        а) с использованием методов C#;
//        б) * разработав собственный алгоритм.
//         Например: badc являются перестановкой abcd.
{
    /// <summary>
    /// Класс сообщения для работы с ними
    /// </summary>
    public class MyMessege
    {
        string mes;
        string[] mesward;
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public MyMessege()
        {
            mes = "";
            mesward = new string[] { "" };
        }
        /// <summary>
        /// Конструктор заполнения класса через строку
        /// </summary>
        /// <param name="_messege"></param>
        public MyMessege(string _messege)
        {
            mes = _messege;
            mesward = mes.Split(new char[] { ' ', '.', ',', '!', '?', ')', '(', ':', ';', '>', '<', '-' }, StringSplitOptions.RemoveEmptyEntries);
        }
        /// <summary>
        /// Конструктор заполнения класса из файла
        /// </summary>
        /// <param name="name">доп элемент для перегрузки</param>
        /// <param name="fileName">полный путь к файлу</param>
        public MyMessege(string name,string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] tempMes = File.ReadAllLines(fileName);
                foreach (string el in tempMes)
                {
                    mes = mes+"\n"+el;
                }                
                mesward = mes.Split(new char[] { ' ', '.', ',', '!', '?', ')', '(', ':', ';','>','<', '-' }, StringSplitOptions.RemoveEmptyEntries);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Сообщение из файла успешно получено!;)");
                PauseAndClear();
            }
            else
                throw new FileNotFoundException();
        }
        /// <summary>
        /// Конструктор заполнения класса из массива строк
        /// </summary>
        /// <param name="manymessege">массив строк</param>
        public MyMessege(string[] manymessege)
        {
            mes = manymessege.ToString();
            mesward = mes.Split(new char[] { ' ', '.', ',', '!', '?', ')', '(', ':', ';', '>', '<' ,'-'}, StringSplitOptions.RemoveEmptyEntries);
        }
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public override string ToString()
        {
            return mes;
        }
        
        /// <summary>
        /// Метод вывода на экран слов, которые не превышают заданное количество букв
        /// </summary>
        /// <param name="number">количество букв</param>
        public void PrintRangeWord(int number)
        {
            int count = 0;
            Console.WriteLine($"Далее будут представлены все слова сообщения, в которых не более {number} букв.");           
            for (int i = 0; i < mesward.Length; i++)
                if (mesward[i].Length <= number)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" {mesward[i]} |");
                    Console.ResetColor();
                    count++;
                }
            if (count==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Не найдено ни одного слова, которое бы содержало не более {number} букв");
                Console.ResetColor();
            }
            PauseAndClear();
        }
        /// <summary>
        /// Метод удаления всех слов сообщения заканчивающихся на заданный символ
        /// </summary>
        /// <param name="end">заданный символ</param>
        public void TrimMyMessege(char end)
        {
            StringBuilder delwardmes = new StringBuilder(mes);
            Console.WriteLine($"Будут удалены все слова, заканчивающиеся на символ {end}: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < mesward.Length; i++)
                if (mesward[i][mesward.Length - 1] == end)
                {
                    Console.Write($"{mesward[i]} |");
                    delwardmes.Replace(mesward[i], "", 0, mesward[i].Length);
                }
            Console.ResetColor();
            Console.WriteLine($"Получилась следующая строка :\n"+delwardmes);
            PauseAndClear();
        }
        /// <summary>
        /// Метод вывода на экран самых длиных слов 
        /// </summary>
        public void PrintLongestWard ()
        {
            string[] tempward=mesward;
            Array.Sort(tempward);
            Console.WriteLine($"Максимальная длина слова в сообщении =>{tempward[tempward.Length-1].Length}\nТакую длину имеют следующие слова:\n");
            for (int i = tempward.Length - 1; i >= 0; i--)
                if (tempward[i].Length == tempward[tempward.Length - 1].Length)
                    Console.Write($"{tempward[i]} |");
                else
                    break;
            PauseAndClear();
        }
        /// <summary>
        /// Метод аузы и очистки консоли
        /// </summary>
        public void PauseAndClear()
        {
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Метод вывода самых длинных слов сообщения, который возвращает строку из этих слов
        /// </summary>
        /// <param name="getlongmes">возвращаемая строка из длиных слов</param>
        public void PrintLongestWard(out StringBuilder getlongmes)
        {
            getlongmes = new StringBuilder();
            string[] tempward = mesward;
            Array.Sort(tempward);
            Console.WriteLine($"Максимальная длина слова в сообщении =>{tempward[tempward.Length - 1].Length}\nТакую длину имеют следующие слова:\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = tempward.Length - 1; i >= 0; i--)
                if (tempward[i].Length == tempward[tempward.Length - 1].Length)
                {
                    Console.Write($"{tempward[i]} |");
                    getlongmes.Append($"{tempward[i]} ");
                }
                else
                    break;
            if (getlongmes.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не удалось найти ни одного слова!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Из получившихся слов получилась следующая строка:\n{getlongmes}");
            }
            PauseAndClear();
        }
        /// <summary>
        /// метод проверки перестановки строк
        /// </summary>
        /// <param name="str"></param>
        public void IsMyReverseString1(string str)
        {
            char[] tempstr=((str.Split(new char[] { ' ', '.', ',', '!', '?', ')', '(', ':', ';', '>', '<', '-', '—', '»', '«' }, StringSplitOptions.RemoveEmptyEntries).ToString().ToLower()).ToCharArray());
            char[] tempwardmes = (mesward.ToString().ToLower()).ToCharArray();
            if (tempwardmes.Length==tempstr.Length)
            {
                Array.Sort(tempstr);
                Array.Sort(tempwardmes);
                if (tempstr == tempwardmes)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Строки {mes} и {str} являются перестановкой друг друга!");
                    PauseAndClear();
                }
                else
                {
                    Console.WriteLine($"Строка{mes}\n и строка: {str}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не являются перестановкой букв друг друга!");
                    PauseAndClear();
                }
            }
        }
        /// <summary>
        /// Метод проверки перестановки строк, более эстетично записанный
        /// </summary>
        /// <param name="str"></param>
        public void IsMyReverseString2(string str)
        {
           if (mes.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(str.Select(Char.ToUpper).OrderBy(x => x)))
            {
                Console.WriteLine($"Строка{mes}\n и строка: {str}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Являются перестановкой букв друг друга!");
                PauseAndClear();
            }
           else
            {
                Console.WriteLine($"Строка{mes}\n и строка: {str}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не являются перестановкой букв друг друга!");
                PauseAndClear();
            }
        }
        /// <summary>
        /// Метод проверки выбора действия с текстом для задания 2
        /// </summary>
        /// <param name="newmes"></param>
        /// <returns></returns>
        static string CheckAnswerTask2(MyMessege newmes)
        {            
            Console.Write("Итак, твой ответ =>");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine($"Дан следующий текст: {newmes.mes.ToString()}\n------------------------------------");
                do
                {
                    Console.Write("Введите число, и программа выведет все слова сообщения, которые имеют меньше или такое же количество букв=>");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        newmes.PrintRangeWord(number);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не корректное число! Повторите ввод!");
                        Console.ResetColor();
                    }
                }
                while (true); 
                
                newmes.PauseAndClear();
            }
            else
                if (answer == "2")
            {
                Console.WriteLine($"---------------------------\nДан следующий текст: {newmes.mes.ToString()}\n------------------------------------");
                do
                {
                    Console.Write("Введите символ, и программа удалит все слова текста,которые заканчиваются на данный символ");
                    if (Char.TryParse(Console.ReadLine(),out char end))
                    {
                        newmes.TrimMyMessege(end);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не корректный символ! Повторите ввод!");
                        Console.ResetColor();
                    }
                }
                while (true);

                newmes.PauseAndClear();

            }
            else
                if (answer == "3" || answer == "4")
            {
                Console.WriteLine($"---------------------------\nДан следующий текст: {newmes.mes.ToString()}\n------------------------------------");
                newmes.PrintLongestWard(out StringBuilder longestmes);
                newmes.PauseAndClear();
            }            
            else
                if (answer == "0")
            {
                Console.WriteLine("Спасибо за внимание. Увидимся на следующем уроке");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректный номер действия! Повторите ввод!");
                Console.ResetColor();
            }
            return answer;
        }
        /// <summary>
        /// Метод запуска 2-го задания
        /// </summary>
        /// <param name="fileName"></param>
        public void RunTask2(string fileName)
        {
            string answertask2;
            string file = AppDomain.CurrentDomain.BaseDirectory + "ForMyMessege.txt";
            MyMessege newmes = new MyMessege("", file);
            do
            {
                Console.WriteLine("Задание 2 к уроку 5.\nВыберите действие, которое хотите сделать с сообщением:\n1) Вывести только те слова сообщения, которые содержат не более n букв.\n2. Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n3 and 4. Найти самое длинное слово сообщения.\nЧтобы выйти нажмите 0.");                
                answertask2 = CheckAnswerTask2(newmes);
            }
            while (answertask2 != "0");
        }
        public void RunTask3()
        {
            string answertask3;
            do
            {
                Console.WriteLine("Задание 2 к уроку 5.\nДоброго времени суток, пользователь.\nДанная программа проверит, является ли 1 строка перестановкой букв другой.");
                Console.Write("Введи первую строку=>");
                MyMessege first = new MyMessege(Console.ReadLine());
                Console.Write("Введи вторую строку=>");
                string str = Console.ReadLine();
                first.IsMyReverseString1(str);
                first.IsMyReverseString2(str);
                Console.WriteLine("Чтобы выйти - вводи 0\nЧтобы продолжить с новыми строками - вводи что-то другое. Не 0!)");
                answertask3 = Console.ReadLine();
            }
            while (answertask3 != "0");
            Console.WriteLine("До встречи на новых работах!)");
            PauseAndClear();
        }    
    }
}
