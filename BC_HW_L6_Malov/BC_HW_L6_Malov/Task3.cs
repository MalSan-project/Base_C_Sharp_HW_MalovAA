using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BC_HW_L6_Malov
{
    //    3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    //       а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //       б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //       в) отсортировать список по возрасту студента;
    //       г) * отсортировать список по курсу и возрасту студента;
    //       д) разработать единый метод подсчета количества студентов по различным параметрам
    //          выбора с помощью делегата и методов предикатов.
    delegate int SortOfMyParametr (MyStudent st1, MyStudent st2);
    delegate int GetCountDel(List<MyStudent> students,dynamic param);
    delegate int GetCountDelOut(List<MyStudent> students,out List<MyStudent> students1);
    delegate int GetCountDel2Out(List<MyStudent> students, int minparam,int maxparam, out List<MyStudent> students1);
    class Task3
    {
    }
    class MyStudent
    {
        string lastName { get; set; }
        string firstName { get; set; }
        string university { get; set; }
        string faculty { get; set; }
        int course { get; set; }
        string department { get; set; }
        int group { get; set; }
        string city { get; set; }
        int age { get; set; }
        public MyStudent(string lastName, string  firstName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
        public MyStudent()
        {
            lastName = "";
            firstName = "";
            university = "";
            faculty = "";
            department = "";
            course = 0;
            age = 0;
            group = 0;
            city = "";
        }
        #region Методы для получения числа студента по параметру\параметрам
        /// <summary>
        /// Метод проверки были ли совпадения в резултате поиска
        /// </summary>
        /// <param name="students"></param>
        public static void CheckCount(List<MyStudent> students)
        {
            if (students.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Совпадений не найдено!");
                Task1_2.Pause();
            }
        }
        /// <summary>
        /// Метод получения числа студентов по Фамилии
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="lname">фамилия</param>
        /// <returns></returns>
        public static int GetCountLName(List<MyStudent> students, string lname)
        {
            List<MyStudent> tempstudents = new List<MyStudent>();
            foreach (MyStudent el in students)
            {
                if (el.lastName == lname)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов по Фамилии, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданной фамилией</param>
        /// <returns></returns>
        public static int GetCountLName(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите фамилию по которой необходимо найти студентов:");
            string lname = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.lastName == lname)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов по Имени, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданным Именем</param>
        /// <returns></returns>
        public static int GetCountFName(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите имя по которому необходимо найти студентов:");
            string Fname = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.firstName == Fname)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов учащихся в заданном университете, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданного универа</param>
        /// <returns></returns>
        public static int GetCountUniver(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите университет по которому необходимо найти студентов:");
            string univer = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.university == univer)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов учащихся на заданном факультете, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданного факультета</param>
        /// <returns></returns>
        public static int GetCountFaculty(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите факультет по которому необходимо найти студентов:");
            string faculty = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.university == faculty)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод поиска числа студентов с заданной кафедры, возвращает лист ентих студентов
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданной кафедры</param>
        /// <returns></returns>
        public static int GetCountDepartament(List<MyStudent> students, out List<MyStudent> tempstudents)
        {            
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите кафедру по которой необходимо найти студентов:");
            string depart = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.department == depart)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов учащихся на заданном курсе, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="tempstudents">лист студентов с заданного курса</param>
        /// <returns></returns>
        public static int GetCountCourse(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            do
            {
                Console.WriteLine("Введите номер курса по которому необходимо найти студентов:");
                if (int.TryParse(Console.ReadLine(), out int cou))
                {
                    foreach (MyStudent el in students)
                    {
                        if (el.course == cou)
                        {
                            tempstudents.Add(el);
                        }
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
                    Task1_2.Pause();
                }
            } while (true);

            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов заданного возраста, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="age">возраст</param>
        /// <param name="tempstudents">лист студентов заданного возраста</param>
        /// <returns></returns>
        public static int GetCountAge(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            do
            {
                Console.WriteLine("Введите возраст по которому необходимо найти студентов:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    foreach (MyStudent el in students)
                    {
                        if (el.course == age)
                        {
                            tempstudents.Add(el);
                        }
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
                    Task1_2.Pause();
                }
            } while (true);

            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов из заданной группы, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="group">группа</param>
        /// <param name="tempstudents">лист студентов из заданной группы</param>
        /// <returns></returns>
        public static int GetCountGroup(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            do
            {
                Console.WriteLine("Введите номер группы по которой необходимо найти студентов:");
                if (int.TryParse(Console.ReadLine(), out int group))
                {
                    foreach (MyStudent el in students)
                    {
                        if (el.course == group)
                        {
                            tempstudents.Add(el);
                        }
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
                    Task1_2.Pause();
                }
            } while (true);

            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод получения числа студентов из заданного города, возвращающий лист с этими студентами
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="city">город</param>
        /// <param name="tempstudents">лист студентов из заданного города</param>
        /// <returns></returns>
        public static int GetCountCity(List<MyStudent> students, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            Console.WriteLine("Введите город по которому необходимо найти студентов:");
            string city = Console.ReadLine();
            foreach (MyStudent el in students)
            {
                if (el.city == city)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод посчёта количества студентов учащихся в заданном диапазоне курсов, возвращает лист этих студентов
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="minparam">минимальный курс поиска</param>
        /// <param name="maxparam">максимальный курс поиска</param>
        /// <param name="tempstudents">лист студентов учащихсяв заданном диапазоне</param>
        /// <returns></returns>
        public static int GetCountRangeCourse(List<MyStudent> students, int minparam, int maxparam, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            foreach (MyStudent el in students)
            {
                if (el.course >= minparam && el.course <= maxparam)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод посчёта количества студентов заданного диапазона возраста, возвращает лист этих студентов
        /// </summary>
        /// <param name="students">лист студентов</param>
        /// <param name="minparam">минимальный возраст поиска</param>
        /// <param name="maxparam">максимальный возраст поиска</param>
        /// <param name="tempstudents">лист студентов заданного диапазона возраста</param>
        /// <returns></returns>
        public static int GetCountRangeAge(List<MyStudent> students, int minparam, int maxparam, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            foreach (MyStudent el in students)
            {
                if (el.age >= minparam && el.age <= maxparam)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        /// <summary>
        /// Метод посчёта количества студентов учащихся в заданном диапазоне групп, возвращает лист этих студентов
        /// </summary>
        /// <param name="students">Лист студентов</param>
        /// <param name="minparam">минимальный номер группы</param>
        /// <param name="maxparam">максимальный номер группы</param>
        /// <param name="tempstudents">лист студентов учащихся в заданном диапазоне групп</param>
        /// <returns></returns>
        public static int GetCountRangeGroup(List<MyStudent> students, int minparam, int maxparam, out List<MyStudent> tempstudents)
        {
            tempstudents = new List<MyStudent>();
            foreach (MyStudent el in students)
            {
                if (el.group >= minparam && el.group <= maxparam)
                {
                    tempstudents.Add(el);
                }
            }
            CheckCount(tempstudents);
            return tempstudents.Count;
        }
        #endregion
        #region методы сравнения полей класса
        public static int MyComparAge(MyStudent st1, MyStudent st2)
        {
            return st1.age.CompareTo(st2.age);
        }
        public static int MyComparCourse(MyStudent st1, MyStudent st2)
        {
            return st1.course.CompareTo(st2.course);
        }
        public static int MyComparName(MyStudent st1, MyStudent st2)
        {
            return (st1.lastName + st1.firstName).CompareTo(st2.lastName + st2.firstName);
        }
        #endregion
        public static List<MyStudent> SortMyListAge(List<MyStudent> students)
        {
            students = students.OrderBy(a => a.age).ToList<MyStudent>();
            return students;
        }
        public static List<MyStudent> SortMyListCourseAndAge(List<MyStudent> students)
        {
            students = students.OrderBy(a => a.course).ThenBy(a => a.age).ToList<MyStudent>();
            return students;
        }
        public override string ToString()
        {
            return $"| Студент: {lastName} {firstName} {age} лет.Прописан в городе: {city}. Учится в {university} на факультете: {faculty} на кафедре: {department} курс № {course} группа № {group} |";
        }
        /// <summary>
        /// Метод вывода на экран списка студентов
        /// </summary>
        /// <param name="tempst"></param>
        public static void PrintMyListStudent(List<MyStudent> tempst)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------");
            foreach (MyStudent el in tempst)
                Console.WriteLine(el.ToString());
            Console.WriteLine("--------------------------------------------");
            Task1_2.Pause();

        }
        /// <summary>
        /// Метод запуска поиска числа студентов по диапазону параметров
        /// </summary>
        /// <param name="deleg"></param>
        /// <param name="students"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="activestudents"></param>
        /// <returns></returns>
        public static int GetRangeCount(GetCountDel2Out deleg, List<MyStudent> students, int min, int max, out List<MyStudent> activestudents)
        {
            int count = deleg(students, min, max, out activestudents);
            Console.WriteLine($"{count} и вот список этих студентов: ");
            PrintMyListStudent(activestudents);
            return count;
        }
        /// <summary>
        /// Запуск поиска числа студентов по пункту, выбранному пользователем 
        /// </summary>
        /// <param name="delegatcount">массив методов поиска</param>
        /// <param name="students">Список студентов</param>
        public static void RunGetCountProgram(GetCountDelOut[] delegatcount,List<MyStudent> students)
        {
            int answer,count;
            do
            {
                Console.Write("Можно подсчитать количество студентов по следующим параметрам:\n1.По Фамилии\n2.По Имени\n3.По Университету\n4.По Факультету\n5.По кафедре\n6.По Курсу\n7.По возрасту\n8.По номеру группы\n9.По Городу\nДля выхода введите 0\nВаш выбор=> ");
                if (int.TryParse(Console.ReadLine(), out answer) && answer > 0 && answer <= delegatcount.Length)
                {
                    count=delegatcount[answer - 1](students,out List<MyStudent> tempstudents);
                    Console.WriteLine($"Количество студентов по заданному параметру = {count}\nИ вот эти студенты:");
                    PrintMyListStudent(tempstudents);
                    Console.Write("Продолжить поиск с получившимся списком или вернёмся к дефолтному?\nДля продолжения с действующм списком введите 1, для выхода - что угодно только не 1=> ");
                    if ((int.TryParse(Console.ReadLine(), out answer)) && answer == 1)
                        RunGetCountProgram(delegatcount, tempstudents);
                    else
                        answer = 0;
                }
                else
                     if (answer != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("не валидный номер задачи. Повторите ввод!");
                    Task1_2.PauseAndClear();
                }
            } while (answer!=0);

        }
        /// <summary>
        /// Метод запуска 3-го задания
        /// </summary>
        public static void RunTask3()
        {
            int answer,count;
            GetCountDelOut[] delegatcount = { GetCountLName, GetCountFName, GetCountUniver,GetCountFaculty,GetCountDepartament,GetCountCourse,GetCountAge,GetCountGroup,GetCountCity};
            GetCountDel2Out[] delegatcount2 = { GetCountRangeCourse,GetCountRangeAge,GetCountRangeGroup};
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "BaseOfStudents.csv";            
            List<MyStudent> students = GetBaseSTudent(fileName);
            Console.WriteLine("Задание 3 к уроку 6. Работа с коллекциями.");
            do
            {
                Console.WriteLine("Дан список студентов:");
                PrintMyListStudent(students);
                Console.Write("Выберете что хотите сделать со списком:\n1) Подсчитать количество студентов учащихся на 5 и 6 курсах \n2) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся\n3) отсортировать список по возрасту студента\n4)отсортировать список по курсу и возрасту студента\n5) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.\nДля выхода введите 0\nВаш выбор=> ");
                if (int.TryParse(Console.ReadLine(),out answer)&&answer!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    switch (answer)
                    {
                        case 1:                            
                            Console.Write("Количество студентов учащихся на 5 и 6 курсах = ");
                            count = GetRangeCount(GetCountRangeCourse,students, 5, 6, out List<MyStudent> activestudents);                            
                            break;
                        case 2:
                            Console.Write("Количество студентов в возрасте от 18 до 20 лет = ");
                            count = GetRangeCount(GetCountRangeAge, students, 18, 20, out List<MyStudent> activestudents1);                            
                            break;
                        case 3:
                            students = SortMyListAge(students);
                            PrintMyListStudent(students);
                            break;
                        case 4:
                            students = SortMyListCourseAndAge(students);
                            PrintMyListStudent(students);
                            break;
                        case 5:
                            RunGetCountProgram(delegatcount, students);
                            break;
                    }
                    Task1_2.PauseAndClear();
                }
                else 
                    if (answer!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("не валидный номер задачи. Повторите ввод!");
                    Task1_2.PauseAndClear();
                }
            }
            while (answer != 0); 

        }
        public static List<MyStudent> GetBaseSTudent(string fileName)
        {
            List<MyStudent> students = new List<MyStudent>();

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var userString = reader.ReadLine().Split(';');
                    var student = new MyStudent(userString[0], userString[1], userString[2], userString[3], userString[4], int.Parse(userString[5]), int.Parse(userString[6]), int.Parse(userString[7]), userString[8]);
                    students.Add(student);
                }
            }
            return students;
        }


    }
}
