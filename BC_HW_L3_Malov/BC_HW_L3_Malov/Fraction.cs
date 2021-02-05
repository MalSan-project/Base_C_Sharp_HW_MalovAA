using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L3_Malov
{
    //    Урок 3. Задание 3. 
    //    * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //      Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //       ArgumentException("Знаменатель не может быть равен 0");
    /// <summary>
    /// Класс дробей, представленных в виде рациональных чисел, где числитель - целое число, а знаменатель - натуральное число. В классе реализованы стандартные алгебраические операции (+,-,*,/)
    /// </summary>
    public class Fraction
    {
        int num;
        int den;

        public Fraction()
        {
            num = 0;
            den = 1;
        }
        public Fraction(int _num, int _den)
        {               
            num = _num;
            if (_den > 0)
                den = _den;
                else
                    if (_den == 0)
                    throw new ArgumentException("Делить на 0 нельзя!");
                else
                    throw new ArgumentException("Делитель должен являться натуральным числом!");
            
        }
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public int Den
        {
            get
            {
                return den;
            }
            set
            {
                if (value > 0)
                    den = value;
                else
                    if (value == 0)
                    throw new ArgumentException("Делить на 0 нельзя!");
                else
                    throw new ArgumentException("Делитель должен являться натуральным числом !=0");
            }
        }
        public override string ToString()
        {          
            return num + "/" + den;  
        }
        /// <summary>
        /// Метод сокращения дроби
        /// </summary>
        public void Reduction()
        {
            for (int i = num; i > 0; i--)
                if (num % i == 0 && den % i == 0)
                {
                    num = num / i;
                    den = den / i;
                    break;
                }
        }
        /// <summary>
        /// Перегруженный оператор сложения, реализованный для дробей
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction z = new Fraction();
            z.den = x.den * y.den;
            z.num = x.num * y.den + y.num * x.den;
            z.Reduction();
            return z;
        }
        /// <summary>
        /// Перегруженный оператор вычитания, реализованный для дробей
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator -(Fraction x, Fraction y)
        {
            Fraction z = new Fraction();
            z.den = x.den * y.den;
            z.num = x.num * y.den - y.num * x.den;
            z.Reduction();
            return z;
        }
        /// <summary>
        /// Перегруженный оператор умножения, реализованный для дробей
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction z = new Fraction();
            z.den = x.den * y.den;
            z.num = x.num * y.num;
            z.Reduction();
            return z;
        }
        /// <summary>
        /// Перегруженный оператор деления, реализованный для дробей
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction z = new Fraction();
            if (y.num == 0)
            {
                throw new ArgumentException("Делить на 0 нельзя!");
            }
            else
            if (y.num > 0)
            {
                z.den = x.den * y.num;
                z.num = x.num * y.den;
                z.Reduction();
            }
            else
            {
                z.den = -(x.den * y.num);
                z.num = -(x.num * y.den);
                z.Reduction();
            }
            return z;
        }
    }
}
 