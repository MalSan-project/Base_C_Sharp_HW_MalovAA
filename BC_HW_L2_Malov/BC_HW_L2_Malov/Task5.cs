using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    //Урок 2.Задание 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    public class Task5
    {
        static Task5()
        {
        }
        /// <summary>
        /// Метод расчёта на сколько кг похудеть или сколько кг набрать для нормализации веса.
        /// </summary>
        /// <param name="BMI"></param>
        /// <param name="h"></param>
        /// <param name="m"></param>
        static void CheckMass(double BMI, double h, double m)
        {
            double normmass = 0;
            if (BMI < 18.5)
            {
                normmass = 19 * (h * h) - m;
                Console.WriteLine($"Вам нужно набрать {normmass:0.#} кг");
            }
            else
                if (BMI > 25)
            {
                normmass = m - 24 * (h * h);
                Console.WriteLine($"Вам нужно сбросить {normmass:0.#} кг");
            }
        }
        /// <summary>
        /// Метод сравнения индекса массы тела с таблицей нормативов показателей
        /// </summary>
        /// <param name="BMI"></param>
        static void CheckBMI(double BMI)
        {
            if (BMI <= 16)
            {
                Console.WriteLine("У вас ужасный диффицит массы тела! Акститесь и начинайте есть!");
            }
            else
                if (BMI > 16 && BMI <= 18.5)
            {
                Console.WriteLine("У вас недостаточная масса тела! Нужно больше кушать!");
            }
            else
                if (BMI > 18.5 && BMI <= 25)
            {
                Console.WriteLine("Молодцом! У вас всё в норме!)");
            }
            else
                if (BMI > 25 && BMI <= 30)
            {
                Console.WriteLine("Вот те на, у вас избыточная масса тела!\nНе критично, но пора последить за фигурой!");
            }
            else
                if (BMI > 30 && BMI <= 35)
            {
                Console.WriteLine("Внимание! У вас ожирение 1-ой степени.\nОжирение - это не шутка, это болезнь которую нужно лечить! Займитесь спортом пока не поздно!");
            }
            else
                if (BMI > 35 && BMI <= 40)
            {
                Console.WriteLine("Тревога! У вас ожирение 2-ой степени.\nЭто уже не шутки!\nПроблемы с кровеносной системой, проблемы с сердцем, повышенной потоотделение...\nЭто только маленькая часть проблем, которые будут сопровождать вас, если вы не одумаетесь и не займётесь своим телом!");
            }
            else
            {
                Console.WriteLine("У вас ожирение третьей степени. Нельзя так себя запускать.\n Уверен именно глядя на вас группа 'Ума-Турман' написала свой кавер на популярную песню 1990 года\nЕсли оставить всё как есть - судьба ваша незавидна...");
            }
        }
        /// <summary>
        /// Метод запуска 5-го задания.Подсчёт ИМТ.Сравнение с нормативами.Рекомендации по массе тела.
        /// </summary>
        public void RunTask5()
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
        {
            #region Объявление переменных
            string name = "";
            string surname = "";
            double h = 0;
            double m = 0;
            double BMI = 0;
            #endregion

            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 5 к уроку № 2.\nДанная программа поможет тебе расчитать индекс массы тела, и без утайки скажет что тебе с этим делать");
            Console.Write("Введите пожалуйста своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите пожалуйста свою фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите пожалуйста свой рост в сантиметрах: ");
            h = Double.Parse(Console.ReadLine()) / 100;
            Console.Write("Введите пожалуйста свой вес в килограммах(П.С. только не преуменьшайте, потом нам это ещё прегодиться): ");
            m = Double.Parse(Console.ReadLine());
            BMI = m / (h * h);
            Console.WriteLine("Уважаемый {0} {1} , ваш индекс массы тела: {2:0.##}", name, surname, BMI);
            CheckBMI(BMI);
            CheckMass(BMI, h, m);

            Console.ReadKey();
            Console.Clear();
        }
                   
        

    }
}
