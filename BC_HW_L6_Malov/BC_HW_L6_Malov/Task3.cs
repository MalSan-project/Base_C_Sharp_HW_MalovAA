using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L6_Malov
{
    //    3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    //       а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //       б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //       в) отсортировать список по возрасту студента;
    //       г) * отсортировать список по курсу и возрасту студента;
    //       д) разработать единый метод подсчета количества студентов по различным параметрам
    //          выбора с помощью делегата и методов предикатов.
    delegate int GetCount();
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
        public MyStudent(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
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


    }
}
