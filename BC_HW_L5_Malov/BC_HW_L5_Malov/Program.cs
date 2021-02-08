using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BC_HW_L5_Malov
{
    //R:\Учёба\Разработчик игр\Основы С#\Lesson5\BC_HW_L5_Malov\BC_HW_L5_Malov\Account.txt
    class Program
    {
        static void Main(string[] args)
        {
            #region Инициализация объектов класса заданий
            Task1 task1 = new Task1();
            MyMessege task2 = new MyMessege();
            MyMessege task3 = new MyMessege();
            USE_Task4 task4 = new USE_Task4();
            Riddler task5 = new Riddler();
            #endregion

            string answer = "0"; ;
            Console.WriteLine("Доброго время суток, пользователь. Добро пожаловать в домашнюю работу к уроку 5 курса Основы C#");
            string fileName;
            do
            {
                Console.Write("Выбери задание,выполнение которое желаешь просмотреть:\n1.Корректность ввода логина и пароля, относительно шаблона\n2.Работа класса Messege\n3.Проверка 2-ух строк на предмет перестановочности символов\n4.Задача ЕГЭ\n5.Занимательные загадочки!)\nДля выхода введи 0\nТвой ответ=>");
                if ((answer = Console.ReadLine()) == "1")
                {
                    fileName = AppDomain.CurrentDomain.BaseDirectory + "Account.txt";
                    task1.RunTask1(fileName);
                }
                else
                    if (answer == "2")
                {
                    fileName = AppDomain.CurrentDomain.BaseDirectory + "ForMyMessege.txt";
                    task2.RunTask2(fileName);
                }
                else
                    if (answer == "3")
                {
                    task3.RunTask3();
                }
                else
                    if (answer == "4")
                {
                    fileName = AppDomain.CurrentDomain.BaseDirectory + "BaseStudent.txt";
                    task4.RunTask4(fileName);
                }
                else
                    if (answer == "5")
                {
                    fileName= AppDomain.CurrentDomain.BaseDirectory + "Riddles.txt";
                    task5.RunTask5(fileName);
                }
                else
                    if (answer != "0")
                    Console.WriteLine("Вы ввели не корректный номер задания. Повторите ввод.");
            }
            while (answer != "0");
            Console.WriteLine("До встречи на домашних работах к следующим урокам.");
            Console.ReadKey();
        }
    }
}
