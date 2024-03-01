using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Memento
    {
        private ListOperationType operationType;
        private List<Discipline> disciplineList;

        public Memento(ListOperationType operationType, List<Discipline> disciplinesList)
        {
            this.operationType = operationType;
            this.disciplineList = disciplinesList;
        }

        public List<Discipline> DisciplineList { get => disciplineList; }
    }
}
