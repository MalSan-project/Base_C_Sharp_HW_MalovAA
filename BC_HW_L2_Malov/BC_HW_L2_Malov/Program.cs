using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    //Домашнее задание к уроку 2 Базового курса C#
    //Студент Малов А.А.
    //Для удобства задания разбиты по классам, вызов происходит в классе Program.
    class Program
    {
        /// <summary>
        /// Метод проверки ответа пользователя на выбор задания
        /// </summary>
        /// <param name="answer"></param>
        static void CheckAnswerRun(int answer)
        {
            #region Создание объектов классов задач
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
            Task6 task6 = new Task6();
            Task7 task7 = new Task7();
            #endregion
            if (answer == 1)
                task1.RunTask1();
            else
                if (answer == 2)
                task2.RunTask2();
            else
                if (answer == 3)
                task3.RunTask3();
            else
                if (answer == 4)
                task4.RunTask4();
            else
                if (answer == 5)
                task5.RunTask5();
            else
                if (answer == 6)
                task6.RunTask6();
            else
                if (answer == 7)
                task7.RunTask7();
            else
                if (answer == 0)
                Console.WriteLine("Как пожелаете. \nУвидимся на следующем домашнем задании, и, благодарю за потраченное время.\n");
            else
                Console.WriteLine("Введён не корректный номер задания!");


        }
                
        static void Main(string[] args)
        {
            #region Объявление переменных
            int answer = 0;
            string tasks = "Введи номер интересующего задания:\n1. Написать метод, возвращающий минимальное из трех чисел. \n2. Написать метод подсчета количества цифр числа. \n3. Подсчитать сумму всех введённых, нечетных положительных чисел.\n4.Реализовать метод проверки логина и пароля. \n5. Задание на расчёт индекса массы тела\n6. Программа подсчёта суммы и количества хороших чисел 'на время'\n7.Игры с рекурсивными методами \nДля выхода из программы введи 0 \nИтак, ваш выбор =>";
            #endregion
            Console.WriteLine("Доброго времени суток, пользователь. \nБлагодарю, что решил потратить время на просмотр моего домашнего задания к уроку №2 курса: 'Основы C#'.");
            do
            {
                Console.Write(tasks);
                answer = int.Parse(Console.ReadLine());
                CheckAnswerRun(answer);
            } while (answer != 0);
            Console.ReadKey();
        }
    }
}
