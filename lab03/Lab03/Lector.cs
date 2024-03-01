using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Lector
    {
        private string _surname;
        private string _name;
        private string _thirdname;
        private string _kafedra;
        private string _kabinet;
        private string _phone;
        public Lector(string surname, string name, string thirdname, string kafedra, string kabinet, string phone)
        {
            this.Surname = surname;
            this.Name = name;
            this.ThirdName = thirdname;
            this.Kabinet = kabinet;
            this.Phone = phone;
            this.Kafedra = kafedra;
        }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Допустимы только русские буквы в фамилии")]
        public string Surname { get => _surname; set => _surname = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Допустимы только русские буквы в имени")]
        public string Name { get => _name; set => _name = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Допустимы только русские буквы в отчестве")]
        public string ThirdName { get => _thirdname; set => _thirdname = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public string Kafedra { get => _kafedra; set => _kafedra = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        [RegularExpression(@"^[0-9]{1,3}$", ErrorMessage = "Допустимы только цифры в кабинете")]
        public string Kabinet { get => _kabinet; set => _kabinet = value; }
        [Required(ErrorMessage = "поле не должно быть пустым!")]
        public string Phone { get => _phone; set => _phone = value; }

        public override string ToString()
        {
            return $"{Surname} {Name} {ThirdName} каб. {Kabinet} тел. {Phone}";
        }
        public object Clone()
        {
            return new Lector(
                Surname,
                Name,
                ThirdName,
                Kafedra,
                Kabinet,
                Phone
                );
        }
    }
}
