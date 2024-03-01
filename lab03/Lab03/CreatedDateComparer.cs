using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class CreatedDateComparer : IComparer<Discipline>
    {
        public int Compare(Discipline x, Discipline y)
        {
            return DateTime.Compare(x.CreatedDate, y.CreatedDate);
        }
    }
}
