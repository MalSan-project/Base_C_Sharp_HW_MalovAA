using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_HW_L7_Malov
{

//    Домашняя работа к уроку 7 курса "Основы языка С#" студент Малов А.А.
//       Урок 1. 
//       а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//       б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
//       в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Doubler());
        }
    }
}
