using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public partial class MainForm
    {
        void CurrentTime_Tick(object sender, EventArgs e)
        {
            toolStripLabel_time.Text = "Время: " + DateTime.Now.ToLongTimeString();
        }
        void CurrentDate_Tick(object sender, EventArgs e)
        {
            toolStripLabel_date.Text = "Дата: " + DateTime.Now.ToShortDateString();
        }
        void LastOperation_Tick(object sender, EventArgs e)
        {
            this.toolStripLabel_lastOperation.Text = "Последнее действие: " + AllOperationTypeAdapter.GetString(_lastOperation);
        }
    }
}
