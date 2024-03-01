using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab03
{
    public class CustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            Regex regex = new Regex(@"^[A-Za-zА-Яа-я]+$");

            if (obj is Discipline discipline)
                if (regex.IsMatch(discipline.Name))
                    return true;

            return false;
        }
    }
}
