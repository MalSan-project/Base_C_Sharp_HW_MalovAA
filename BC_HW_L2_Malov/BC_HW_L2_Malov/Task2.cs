using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    //Урок 2. Задание 2. Написать метод подсчета количества цифр числа.
    public class Task2
    {
        static Task2()
        {
        }
        /// <summary>
        /// Метод подсчёта количества цифр в заданном числе
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetNumberOfDigits(double number)
        {
            int count = 0;
            while (number % 0.1 != 0)
                number = number * 10;
            while (number >=1)
            {
                number = number / 10;
                count++;
            }
            return count;

        }
        /// <summary>
        /// Метод запуска 2-го задания. Метод подсчета количества цифр числа.
        /// </summary>
        public void RunTask2()
        {
            double number = 0;
            Console.WriteLine("Урок 2.Задание 2. \nДанная программа находит количество цифр числа. \nВведите это число:");
            number = double.Parse(Console.ReadLine());
            Console.WriteLine($"количество цифр числа {number} => {GetNumberOfDigits(number)}");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
