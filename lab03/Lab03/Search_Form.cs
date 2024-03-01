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
            var tempList = list;
            if(checkBox_UseRegex.Checked)
            {
                if (checkedListBox_SearchParams.CheckedIndices.Contains(0))
                {
                    tempList = tempList.Where(x => (x.Lector.Surname + " " + x.Lector.Name + " " + x.Lector.ThirdName).Contains(this.textBox_SearchLector.Text)).ToList();
                    //tempList = tempList.Where(x => Regex.IsMatch(x.Lector.Surname + x.Lector.Name + x.Lector.ThirdName, textBox_SearchLector.Text)).ToList();
                }
                if (checkedListBox_SearchParams.CheckedIndices.Contains(1))
                {
                    tempList = tempList.Where(x => x.Term.Contains(this.textBox_SearchTerm.Text)).ToList();
                    //tempList = tempList.Where(x => Regex.IsMatch(x.Term, textBox_SearchTerm.Text)).ToList();
                }
                if (checkedListBox_SearchParams.CheckedIndices.Contains(2))
                {
                    tempList = tempList.Where(x => x.Course.ToString().Contains(this.textBox_SearchCourse.Text)).ToList();
                    //tempList = tempList.Where(x => Regex.IsMatch(x.Course.ToString(), textBox_SearchCourse.Text)).ToList();
                }
                listBox_SearchResults.Items.Clear();
                foreach(var item in tempList)
                {
                    listBox_SearchResults.Items.Add(item);
                }
                Serializer.SerializationList(tempList, "resultsOfSearch.json");
            }
            else
            {
                if (checkedListBox_SearchParams.CheckedIndices.Contains(0))
                {
                    tempList = tempList.Where(x => (x.Lector.Surname + " " + x.Lector.Name + " " + x.Lector.ThirdName) == this.textBox_SearchLector.Text).ToList();
                }
                if (checkedListBox_SearchParams.CheckedIndices.Contains(1))
                {
                    tempList = tempList.Where(x => x.Term == this.textBox_SearchTerm.Text).ToList();
                }
                if(checkedListBox_SearchParams.CheckedIndices.Contains(2))
                {
                    tempList = tempList.Where(x => x.Course.ToString() == this.textBox_SearchCourse.Text).ToList();
                }
                listBox_SearchResults.Items.Clear();
                foreach (var item in tempList)
                {
                    listBox_SearchResults.Items.Add(item);
                }
                Serializer.SerializationList(tempList, "resultsOfSearch.json");
            }


        }
    }
}
