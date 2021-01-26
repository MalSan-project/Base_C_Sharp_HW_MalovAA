using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    //Урок 2. Задание 6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    //        Хорошим называется число, которое делится на сумму своих цифр.
    //    Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    public class Task6
    {
        static Task6()
        {
        }
        /// <summary>
        /// Метод нахождения суммы цифр числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static double GetSumOfDigits(int number)
        {
            int sumdig = 0;            
            while (number >= 1)
            {
                sumdig = sumdig + number % 10;
                number = number / 10;                
            }
            return sumdig;
        }
        /// <summary>
        /// Метод подсчёта количества "хороших чисел"
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetCountGood(int number)
        {            
            int count = 0;
            for (int i=1;i<=number;i++)
            {
                if (i % GetSumOfDigits(i) == 0)
                    count++; 
            }
            return count;
        }
        /// <summary>
        /// Метод проверки желания пользователя продолжить с индивидуальным диапазоном
        /// </summary>
        /// <returns></returns>
        static int CheckAnswer()
        {
            int answer = 0;
            Console.Write("Если хочешь попробовать со своим диапазоном введи число до 2 147 483 647 \nЕсли хочешь закончить, введи 0 =>");
            answer = int.Parse(Console.ReadLine());
            return answer;
        }
        /// <summary>
        /// Метод запуска 6-го задания.Программа подсчёта суммы и количества хороших чисел 'на время'
        /// </summary>
        public void RunTask6()
        {
            int answer = 0;
            Console.WriteLine("Урок 2.Задание 6. \nДанная программа найдёт количество всех хороших чисел в заданном диапазоне и засечёт время на выполнение данной задачи.\nПроверим её выполнение на диапазоне от 1 до 1 000 000 000");
            DateTime start = DateTime.Now;
            Console.WriteLine($"Подсчёт окончен. Количество хороших чисел = {GetCountGood(1000000000)} \nВремя, затраченное на выполнение задачи: {DateTime.Now - start}");
            
            while ((answer = CheckAnswer())!=0)
            {
                start = DateTime.Now;
                Console.WriteLine($"Подсчёт окончен. Количество хороших чисел = {GetCountGood(answer)}\nВремя, затраченное на выполнение задачи: {DateTime.Now - start}");
            }

            Console.ReadKey();
            Console.Clear();


        }


    }
}
