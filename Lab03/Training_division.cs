using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

/*
 * Учебный отдел. 
 * Объект – «Дисциплина». Поля: название, семестр (номер или номера – 1 и 2), 
 * курс (на котором читается), специальность (ПОИТ, ДЭВИ, ПОИБМС, ИСиТ), количество лекций в семестре, 
 * количество лабораторных, вид контроля (экзамен, зачет), лектор и т.д. 
 * Агрегируемый объект: «Лектор». Поля: кафедра, ФИО, аудитория и т.д. 
 * Дополнительно: Агрегируемый объект – «Список литературы». Поля: название, автор, год и т.д.
*/

namespace Lab03
{
    public class Lector
    {
        public Lector(string surname, string name, string thirdname, string kafedra, int kabinet, string phone)
        {
            this.Surname = surname;
            this.Name = name;
            this.ThirdName = thirdname;
            this.Kabinet = kabinet;
            this.Phone = phone;
            this.Kafedra = kafedra;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string ThirdName { get; set; }
        public string Kafedra { get; set; }
        public int Kabinet { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name} {ThirdName}    каб. {Kabinet}   тел. {Phone}";
        }
    }

    public class Discipline
    {
        public Discipline(string name, string term, int course, string spec, string controlType, int hoursCounty, Lector lector)
        {
            Name = name;
            Term = term;
            Course = course;
            Spec = spec;
            ControlType = controlType;
            HoursCounty = hoursCounty;
            Lector = lector;
        }

        public string Name { get; set; }
        public string Term { get; set; }
        public int Course { get; set; }
        public string Spec { get; set; }
        public string ControlType { get; set; }
        public int HoursCounty { get; set; }
        public Lector Lector { get; set; }

        public override string ToString()
        {
            return $"{Name}    Курс: {Course}, {Spec}  Контроль: {ControlType}.  {Lector}";
        }

    }
}
