using System;

namespace BCHW1Malov
//Домашняя работа 1-го урока курса "Основы языка c#".
//студент: Малов Александр.
{
    class Program
    {
        static void Task1()
        //1. написать программу «анкета». последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). в результате вся информация выводится в одну строчку.
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) *используя вывод со знаком $;
        {
            #region Объявление переменных
            string name = "";
            string surname = "";
            string age = "";
            string height = "";
            string weight = "";
            #endregion

            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 1 к уроку № 1.\nТебе будут последовательно заданы вопросы, попрошу ответить на них максимально честно.\n");
            Console.Write("Введите пожалуйста своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите пожалуйста свою фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите пожалуйста свой возраст: ");
            age = Console.ReadLine();
            Console.Write("Введите пожалуйста свой рост в сантиметрах: ");
            height = Console.ReadLine();
            Console.Write("Введите пожалуйста свой вес в килограммах(П.С. только не преуменьшайте, потом нам это ещё прегодиться): ");
            weight = Console.ReadLine();
            Console.WriteLine("Вывод с использованием склеивания: \n Уважаемый " + name + " " + surname + ", вы утверждаете что вам " + age + " лет. Ваш рост: " + height + " см. И ваш вес:" + weight + " киллограмм.");
            Console.WriteLine("Вывод используя форматированный вывод: \n Уважаемый {0} {1}, вы утверждаете что вам {2} лет. Ваш рост: {3} см. И ваш вес: {4} киллограмм.", name, surname, age, height, weight);
            Console.WriteLine("Вывод со знаком $: \n" + $"Уважаемый {name} {surname}, вы утверждаете что вам {age} лет. Ваш рост: {height} см. И ваш вес: {weight} киллограмм.");

            Console.ReadKey();
            Console.Clear();
        }
        static void Task2()
         //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
        {
            #region Объявление переменных
            string name = "";
            string surname = "";           
            double h = 0;
            double m = 0;
            double BMI = 0;
            #endregion

            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 2 к уроку № 1.\nДанная программа поможет тебе расчитать индекс массы тела.\n");
            Console.Write("Введите пожалуйста своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите пожалуйста свою фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите пожалуйста свой рост в сантиметрах: ");
            h = Double.Parse(Console.ReadLine()) / 100;
            Console.Write("Введите пожалуйста свой вес в килограммах(П.С. только не преуменьшайте, потом нам это ещё прегодиться): ");
            m = Double.Parse(Console.ReadLine());
            BMI = m / (h * h);
            Console.WriteLine("Уважаемый {0} {1} , ваш индекс массы тела: {2:0.##}",name,surname,BMI);
            Console.ReadKey();
            Console.Clear();
        }
        #region Task3
        static void Task3()
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        {
            #region Объявление переменных
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;
            double dis = 0;
            #endregion
            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 3 к уроку № 1.\nДанная программа поможет тебе расчитать расстояние между двумя точками в плоскости.\n");
            Console.Write("Введите пожалуйста координаты первой точки по оси ОХ: ");
            x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста координаты первой точки по оси ОY: ");
            y1 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста координаты второй точки по оси ОХ: ");
            x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста координаты второй точки по оси ОY: ");
            y2 = Int32.Parse(Console.ReadLine());
            dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками ({0},{1}) и ({2},{3}) равно: {4:0.##}",x1,y1,x2,y2,dis);
            Console.WriteLine("Ну или так: \nРасстояние между точками ({0},{1}) и ({2},{3}) равно: {4:0.##}", x1, y1, x2, y2, Distance(x1, y1, x2, y2));
            Console.ReadKey();
            Console.Clear();
        }
        static double Distance (int x1, int y1, int x2, int y2)
        ///Функция подсчёта расстояния между двумя точками
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        #endregion
        static void Task4()
//        Написать программу обмена значениями двух переменных.
//        а) с использованием третьей переменной;
//        б) *без использования третьей переменной.
        {
            #region Объявление переменных
            int a = 0;
            int b = 0;
            int c = 0;
            #endregion
            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 4 к уроку № 1.\nДанная программа просто меняет местами переменные.\n");
            Console.Write("Введите пожалуйста значение переменной a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста значение переменной b: ");
            b = Int32.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Теперь переменная а = {a} ,а переменная b= {b} \nСпособ решения: a = a + b => b = a - b => a = a - b ");
            Console.ReadKey();
            Console.Clear();
        }
        #region Task5
        //5.
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организуйте в центре экрана
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
        static void Task5()        
        ///Выполнение 5-го задания
        {
            Console.WriteLine("Уважаемый пользователь, я рад приветствовать тебя в домашнем задании № 5 к уроку № 1.\nДанная программа поможет разместить информацию о тебе в любой точке консоли.\n");
            #region Объявление переменных                     
            string myinfo = MyInformation();
            int x = 0;
            int y = 0;
            #endregion
            Console.WriteLine(myinfo);
            Console.SetCursorPosition((Console.WindowWidth / 2) - myinfo.Length/2, Console.WindowHeight / 2) ;
            Console.WriteLine(myinfo);
            do
            {
                Console.WriteLine("Задайте координаты по горизонтали(значение не должно превышать:  " + ((Console.WindowWidth) - myinfo.Length) + " ): ");
                x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Задайте координаты по вертикали(значение не должно превышать:  " + (Console.WindowHeight) + "): ");
                y = Int32.Parse(Console.ReadLine());
            } while (CheckPoint(myinfo, x, y));
            Print(myinfo, x, y);
            Console.ReadLine();
            Console.Clear();
        }
        static string MyInformation()
        ///Функция создания строки для вывода с именем, фамилией и городом
        {
            #region Объявление переменных
            string name = "";
            string surname = "";
            string city = "";
            string myinformation = "";
            #endregion
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            surname = Console.ReadLine(); 
            Console.Write("Напишите из какого вы города: ");
            city = Console.ReadLine();
            return myinformation = "Вас зовут: " + name + " " + surname + ", вы живёте в городе " + city+".";
        }
        static void Print (string myinformation,int x,int y)
        ///Функция вывода на экран консоли строки в заданной позиции каретки
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(myinformation);
        }
        static bool CheckPoint (string myinfo,int x,int y)
        //Проверка правильности ввода координат
        {
            if (x < 0 || x > ((Console.WindowWidth) - myinfo.Length) || y < 0 || y > Console.WindowHeight)
            {
                Console.WriteLine("Введены не корректные координаты");
                return true;
            }
            else
                return false;
        }
        #endregion
        static void RunAndClear (int check)
        // проверка выбора пользователя и запуск задания
        {
            if (check == 1)
                Task1();
            else
                if (check == 2)
                Task2();
            else
                if (check == 3)
                Task3();
            else
                if (check == 4)
                Task4();
            else
                if (check == 5)
                Task5();
            else
                if (check == 0)
                Console.WriteLine("Спасибо что посмотрели данную работу. До новых встречь!)");
            else
                Console.WriteLine("Введён неверный номер задания. Повторите попытку");
        }
        static void Main(string[] args)
        {
            int check = 0;
            do
            {
                Console.Write("Здравствуй, пользователь. Выбери задание которое хочется проверить: \nВ данной работе присутствуют задания 1,2,3,4,5. \nДля выхода из программы введи 0.\nИтак, Ваш выбор:  ");
                check = Int32.Parse(Console.ReadLine());
                RunAndClear(check);
            } while (check != 0);
        }
    }
}
