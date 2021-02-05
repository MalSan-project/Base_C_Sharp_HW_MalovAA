using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L6_Malov
{
    //Домашняя работа к уроку 6 курса "Основы языка C#" студент Малов А.А.
    class Program
    {
        
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Доброго времени суток. Добро пожаловать на домашнюю работу студанта А.Малова к уроку №6 курса Основы языка C#.");
            do
            {
                Console.Write("Выберите интересующее вас задание:\n1|2.Работы с функциями через делегаты \n3.'Доработаный' пример использования коллекций \nДля выхода введите 0\nИтак, ваш выбор=> ");
                answer = Console.ReadLine();
                if (answer == "1" || answer == "2")
                    Task1_2.RunTask1_2();
                else
                    if (answer == "3")
                { }
                else
                    if (answer == "0")
                    Console.WriteLine("Good bye! Thanks for your time!)");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введён не корректный номер задания. Повторите ввод");
                    Task1_2.Pause();
                }

            } while (answer != "0");
            Task1_2.PauseAndClear();
        }
    }
}
