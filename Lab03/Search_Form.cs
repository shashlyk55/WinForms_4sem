using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public List<Discipline> list { get; }
        public SearchForm(List<Discipline> list)
        {
            InitializeComponent();
            this.list = list;
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            if(checkBox_UseRegex.Checked)
            {
                var regex= new Regex(this.textBox_InputSearch.Text);


            }
            else
            {



            }


        }
    }
}
