using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L3_Malov
{
    //Урок 3. Задание 1. 
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    /// <summary>
    /// Класс содержит структуру Complex, с методами сложения, вычитания и умножения комплексных чисел
    /// </summary>
    class Task1ComplexStruct
    {
    }
    struct ComplexStruct
    {
        public double im;
        public double re;

        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public ComplexStruct Multi (ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public ComplexStruct Minus (ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public override string ToString ()
        {
            return re +"+"+ im + "i";
        }

    }

}
