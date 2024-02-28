using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public class FormMemento
    {
        public ListBox.ObjectCollection Disciplines { get; private set; }
        public FormMemento(ListBox.ObjectCollection disciplines)
        {
            Disciplines = disciplines;
        }
    }
}
