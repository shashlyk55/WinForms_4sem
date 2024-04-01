using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchApp.Memento
{
    public class History
    {
        public List<Memento> Operations { get; }
        public int CurrentOperation { get; set; } = -1;
        public History(List<Memento> operations)
        {
            Operations = operations;
        }

        public Memento GetCurrentOperationMemento()
        {
            return Operations[CurrentOperation];
        }
    }
}
