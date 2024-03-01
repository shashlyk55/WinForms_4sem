using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Principal;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;




namespace Lab03
{
    public class Discipline
    {
        private string _name;
        private string _term;
        private int _course;
        private string _spec;
        private string _controlType;
        private int _hoursCounty;
        private Lector _lector;
        private DateTime _date;

        public Discipline(string name, string term, int course, string spec, string controlType, int hoursCounty, Lector lector, DateTime createdDate)
        {
            Name = name;
            Term = term;
            Course = course;
            Spec = spec;
            ControlType = controlType;
            HoursCounty = hoursCounty;
            Lector = lector;
            CreatedDate = createdDate;
        }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        [Custom(ErrorMessage = "название должно содержать только буквы")]
        public string Name { get => _name; set => _name = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public string Term { get => _term; set => _term = value; }
        public int Course { get => _course; set => _course = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public string Spec { get => _spec; set => _spec = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public string ControlType { get => _controlType; set => _controlType = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public int HoursCounty { get => _hoursCounty; set => _hoursCounty = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public Lector Lector { get => _lector; set => _lector = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public DateTime CreatedDate { get => _date; set => _date = value; }
        public override string ToString()
        {
            return $"{Name} Курс-Семестр: {Course}-{Term}, {Spec}  Контроль: {ControlType} Часы: {HoursCounty}.  {Lector}";
        }
        public object Clone()
        {
            return new Discipline(
                Name,
                Term,
                Course,
                Spec,
                ControlType,
                HoursCounty,
                (Lector)Lector.Clone(),
                CreatedDate
            );

        }
    }
}
