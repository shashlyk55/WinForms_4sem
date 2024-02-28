using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class FormHistory
    {
        public Stack<MainForm> History { get; private set; }
        public FormHistory()
        {
            History = new Stack<MainForm>();
        }
    }
}
