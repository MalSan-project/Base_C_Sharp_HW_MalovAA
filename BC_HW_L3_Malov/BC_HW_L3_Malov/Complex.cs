using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L3_Malov
{
    /// <summary>
    ///класс Complex, содержит методы вычитания, суммирования, деления и произведения комплексных чисел;
    /// </summary>
    public class Complex
    {
        double im;
        double re;

        public Complex ()
        {
            im = 0;
            re = 0;
        }
        public Complex (double _im,double _re)
        {
            im = _im;
            re = _re;
        }
        public double Im
        {
            get => im; 
            set 
            { 
                if(value!=0)
                    im = value; 
            }            
        }
        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public override string ToString()
        {
            if (re == 0 && im == 0)
                return "0";
            else
                if (re == 0)
                return im + "i";
            else
                if (im == 0)
                return $"{re}";
            else
                if (im < 0)
                return Math.Round(re,3)+""+ Math.Round(im, 3) + "i";
            else
            return Math.Round(re, 3) + "+" + Math.Round(im, 3) + "i";
        }
        public static Complex operator + (Complex x,Complex y)
        {
            Complex z = new Complex();
            z.im = x.im + y.im;
            z.re = x.re + y.re;
            return z;
        }
        public static Complex operator - (Complex x, Complex y)
        {
            Complex z = new Complex();
            z.im = x.im - y.im;
            z.re = x.re - y.re;
            return z;
        }
        public static Complex operator *(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.im = x.re*y.im + x.im*y.re;
            z.re = x.re*y.re - x.im*y.im;
            return z;
        }
        public static Complex operator /(Complex x, Complex y)
        {
            if ($"{y}" == "0")
                    throw new ArgumentException("Делить на 0 нельзя!");
                else
                {
                    Complex z = new Complex();
                    z.im = (x.im * y.re - x.re * y.im) / (Math.Pow(x.re, 2) + (Math.Pow(y.im, 2)));
                    z.re = (x.re * y.re + x.im * y.im) / (Math.Pow(x.re, 2) + (Math.Pow(y.im, 2)));
                    return z;
                }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        
        
        /// <summary>
        /// По классике метод запуска Задания 1 к уроку 3.
        /// </summary>
       

    }
}
