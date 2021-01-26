using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    // Урок 2. Задача 4. Реализовать метод проверки логина и пароля.  
    // На вход подается логин и пароль. 
    // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    // С помощью цикла do while ограничить ввод пароля тремя попытками.


    public class Task4
    {
        static Task4()
        {
        }
        /// <summary>
        /// Метод проверки ввода логина и пароля пользователем
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pass"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static bool CheckAnswer (string log,string pass, int count)
        {
            string rightlog = "root";
            string rightpass = "GeekBrains";
            if (rightpass == pass && rightlog == log)
            {
                Console.WriteLine("Введена верная пара логин/пароль! Можете идти дальше.");
                return false;
            } 
            else
            {
                Console.WriteLine($"Введена не верная пара логин/пароль.");
                if (count == 0)
                {
                    Console.WriteLine("Вы израсходовали все попытки.");
                    return false;
                }
                else
                {
                    Console.WriteLine($"Попробуйте ещё раз\nОсталось попыток: {count}");
                    return true;
                }
            }

        }
        /// <summary>
        /// Метод запуска 4-го задания. Метод проверки логина и пароля.
        /// </summary>
        public void RunTask4()
        {
            int count = 3;
            string log = "";
            string pass = "";
            Console.WriteLine("Урок 2.Задание 4. \nЧтобы пройти дальше вам нужно ввести правильную пару логин/пароль.");
            do
            {
                Console.Write("Ввдите логин => ");
                log = Console.ReadLine();
                Console.Write("Ввдите пароль => ");
                pass = Console.ReadLine();
                count--;
            }
            while (CheckAnswer(log, pass, count));

            Console.ReadKey();
            Console.Clear();
        }
    }
}
