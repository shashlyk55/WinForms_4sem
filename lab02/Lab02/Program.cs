﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    /*
     Создать форму (или формы для ввода агрегируемых объектов). 
Разместить на ней ЭУ для ввода/вывода информации об объекте (создать свои 
типы). На форме разместить не менее 9-и различных типов ЭУ (радиокнопки, 
списки, поля ввода, метки, кнопки, слайдеры, календарь  и т.д.). 
Создать дополнительные кнопки для сохранения введенной 
информации и вывода (отображения сохраненных данных). Запись 
сохраняемых объектов и чтение выполнять в./из файл типа xml и/или json. 
Выполнить валидацию вводимых пользователем данных.  
     * 
    Учебный отдел. Объект – «Дисциплина». Поля: название, семестр 
(номер или номера – 1 и 2), курс (на котором читается), 
специальность (ПОИТ, ДЭВИ, ПОИБМС, ИСиТ), количество 
лекций в семестре, количество лабораторных, вид контроля 
(экзамен, зачет), лектор и т.д. Агрегируемый объект: «Лектор». 
Поля: кафедра, ФИО, аудитория и т.д.  
Дополнительно: Агрегируемый объект – «Список литературы». 
Поля: название, автор, год и т.д. 
     */
    internal static class Program
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