using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public partial class MainForm
    {
        // сохранение состояния
        public FormMemento SaveState()
        {
            return new FormMemento(listBox_ShowList.Items);
        }

        // восстановление состояния
        public void RestoreState(FormMemento memento)
        {
            listBox_ShowList.Items.Clear();
            listBox_ShowList.Items.AddRange(memento.Disciplines);
        }
    }
}
