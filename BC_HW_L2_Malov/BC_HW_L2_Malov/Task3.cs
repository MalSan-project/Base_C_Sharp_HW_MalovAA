using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    //Урок 2. Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    public class Task3
    {
        static Task3()
        {
        }
        /// <summary>
        /// Метод запуска 3-го задания. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        public void RunTask3()
        {
            double sum = 0;
            double number = 0;
            string allnumber = "";
            string oddnumber = "";
            Console.WriteLine("Урок 2.Задание 3. \nДанная программа будет считать сумму введёных тобой чисел, пока не будет введён 0(Ноль)");
            do
            {
                Console.Write("Введите число(Если хотите закончить вычисления введите 0)");
                number = double.Parse(Console.ReadLine());
                allnumber = allnumber+" | " + number;
                if (number % 2 != 0 && number>0)
                {
                    sum = sum + number;
                    oddnumber = oddnumber + " | " + number;
                }                
            } while (number != 0);
            Console.WriteLine("Были введены числа: \n"+allnumber+"\nИз них нечётными и положительными являются: \n"+oddnumber+"\nА сумма этих нечётных чисел => "+sum);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
