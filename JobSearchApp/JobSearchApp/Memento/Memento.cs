using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchApp.Memento
{
    public class Memento
    {
        private ObservableCollection<Vacancy> vacancyList;

        public Memento(ObservableCollection<Vacancy> vacancyList)
        {
            this.vacancyList = vacancyList;
        }

        public ObservableCollection<Vacancy> VacancyList { get => vacancyList; }
    }
}
