using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_HW_L8_Malov_Task3
{
    //Домашняя работа к уроку 8 курса "Основы языка С#" студент Малов А.А.
    //3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
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
            Application.Run(new Form1());
        }
    }
}
