using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Error_Form : Form
    {
        public Error_Form()
        {
            InitializeComponent();
        }
        public Error_Form(string message)
        {
            InitializeComponent();
            this.label_Error.Text = message;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
