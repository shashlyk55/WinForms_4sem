using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Lab03
{
    public partial class MainForm : Form
    {
        private List<Discipline> _disciplineList;
        private Timer _timer;
        private AllOperationType _lastOperation;
        private History _operationHistory;
        public MainForm()
        {
            InitializeComponent();
            _timer = new Timer() { Interval = 1000 };
            _timer.Tick += CurrentTime_Tick;
            _timer.Tick += CurrentDate_Tick;
            _timer.Tick += LastOperation_Tick;

            _operationHistory = new History(new List<Memento>());

            _disciplineList = Serializer.DeserializationList("serialize.json");
            foreach (var item in _disciplineList)
            {
                listBox_ShowList.Items.Add(item);
            }

            //ShowList(_disciplineList);
            SaveState(ListOperationType.LoadList, _disciplineList);
            _lastOperation = AllOperationType.Launch;
            _timer.Start();

            this.toolStripLabel_itemsCounty.Text += this._disciplineList.Count;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
        }

        private void button_SaveToJSON_Click(object sender, EventArgs e)
        {
            try
            {

                /*if (CheckEmpty_Elements())
                {
                    throw new Exception("В форме есть незаполненные поля!");
                }*/

                string GetCheckedValues_Terms()
                {
                    string str = "";
                    if (checkBox_Term1.Checked)
                        str += "1";
                    if (checkBox_Term1.Checked && checkBox_Term2.Checked)
                        str += ", ";
                    if (checkBox_Term2.Checked)
                        str += "2";
                    return str;
                }

                string GetCheckedValues_Spec()
                {
                    string str = "";
                    for (int i = 0; i < checkedListBox_Spec.Items.Count; i++)
                    {
                        if (checkedListBox_Spec.GetItemChecked(i))
                        {
                            if (str.Length > 0)
                                str += ", ";

                            str += checkedListBox_Spec.Items[i].ToString();
                        }
                    }
                    return str;
                }

                Discipline discipline = new Discipline(
                    name: textBox_Discipline.Text,
                    term: GetCheckedValues_Terms(),
                    course: (int)numericUpDown_Course.Value,
                    spec: GetCheckedValues_Spec(),
                    controlType: radioButton_Exam.Checked ? "Экзамен" : "Зачет",
                    hoursCounty: trackBar_HourCounty.Value,
                    lector: new Lector(
                        surname: groupBox_LectorInfo.Controls["textBox_LectorSurname"].Text,
                        name: groupBox_LectorInfo.Controls["textBox_LectorName"].Text,
                        thirdname: groupBox_LectorInfo.Controls["textBox_LectorThirdname"].Text,
                        kafedra: comboBox_Kafedra.SelectedItem as string,
                        kabinet: (textBox_LectorKabinet.Text),
                        phone: groupBox_LectorInfo.Controls["textBox_LectorPhone"].Text
                    ),
                    DateTime.Now
                );

                var context = new ValidationContext(discipline);
                var results = new List<ValidationResult>();

                if (!Validator.TryValidateObject(discipline, context, results, true))
                {
                    //MessageBox.Show("Заполните все поля корректно!");
                    MessageBox.Show(results[0].ErrorMessage, "Ошибка валидации");
                    return;
                }

                _disciplineList.Add(discipline);
                listBox_ShowList.Items.Add(discipline);
                //ShowList(_disciplineList);

                Serializer.SerializationList(_disciplineList, "serialize.json");

                this.textBox_Discipline.Text = "";
                this.textBox_LectorSurname.Text = "";
                this.textBox_LectorName.Text = "";
                this.textBox_LectorThirdname.Text = "";
                this.textBox_LectorPhone.Text = "";
                this.textBox_LectorKabinet.Text = "";
                this.comboBox_Kafedra.SelectedIndex = -1;
                this.checkBox_Term1.Checked = false;
                this.checkBox_Term2.Checked = false;
                for (int i = 0; i < checkedListBox_Spec.Items.Count; i++)
                {
                    checkedListBox_Spec.SetItemChecked(i, false);
                }
                this.trackBar_HourCounty.Value = 1;

                SaveState(ListOperationType.ItemAdd, _disciplineList);
                _lastOperation = AllOperationType.AddItem;
            }
            catch (Exception ex)
            {
                Form error = new Error_Form(ex.Message);
                error.ShowDialog();
            }
        }

        private void ShowList(List<Discipline> list)
        {
            listBox_ShowList.Items.Clear();
            foreach (var item in list)
            {
                listBox_ShowList.Items.Add(item.ToString());
            }
        }

        private void button_LoadFromJSON_Click(object sender, EventArgs e)
        {
            _disciplineList.Clear();
            _disciplineList.AddRange(Serializer.DeserializationList("serialize.json"));

            ShowList(_disciplineList);

            toolStripLabel_itemsCounty.Text = "Всего элементов в списке: ";
            toolStripLabel_itemsCounty.Text += listBox_ShowList.Items.Count;


            _lastOperation = AllOperationType.LoadItem;
        }

        private void Search_MenuItem_Click(object sender, EventArgs e)
        {
            Form searchFrom = new SearchForm(_disciplineList);
            searchFrom.ShowDialog();
        }

        private void MenuItem_SortOnControlType_Click(object sender, EventArgs e)
        {
            _disciplineList = _disciplineList.OrderBy(x => x.ControlType).ToList();
            ShowList(_disciplineList);

            toolStripLabel_itemsCounty.Text = "Всего элементов в списке: ";
            toolStripLabel_itemsCounty.Text += listBox_ShowList.Items.Count;

            SaveState(ListOperationType.ItemsSortingBySecondName, _disciplineList);
            _lastOperation = AllOperationType.SortItemsByControlType;
        }

        private void MenuItem_SortOnHoursCounty_Click(object sender, EventArgs e)
        {
            _disciplineList = _disciplineList.OrderBy(x => x.HoursCounty).ToList();
            ShowList(_disciplineList);

            toolStripLabel_itemsCounty.Text = "Всего элементов в списке: ";
            toolStripLabel_itemsCounty.Text += listBox_ShowList.Items.Count;

            SaveState(ListOperationType.ItemsSortingBySecondName, _disciplineList);
            _lastOperation = AllOperationType.SortItemsByHourCounty;
        }

        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            Serializer.SerializationList(_disciplineList.OrderBy(x => x.HoursCounty).ToList(), "savingList.json");
            _lastOperation = AllOperationType.Saving;
        }

        private void AboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\tVersion 1.0.1\t\t\n\n\t\tSlesarev Ivan", "About", MessageBoxButtons.OK);
            _lastOperation = AllOperationType.ShowAboutProgram;
        }

        private void toolStripButton_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_Discipline.Text = "";
            this.textBox_LectorSurname.Text = "";
            this.textBox_LectorName.Text = "";
            this.textBox_LectorThirdname.Text = "";
            this.textBox_LectorPhone.Text = "";
            this.textBox_LectorKabinet.Text = "";
            this.comboBox_Kafedra.SelectedIndex = -1;
            this.checkBox_Term1.Checked = false;
            this.checkBox_Term2.Checked = false;
            for (int i = 0; i < checkedListBox_Spec.Items.Count; i++)
            {
                checkedListBox_Spec.SetItemChecked(i, false);
            }
            this.trackBar_HourCounty.Value = 1;

            errorProvider_Discipline.Clear();
            errorProvider_LectorKabinet.Clear();
            errorProvider_LectorKafedra.Clear();
            errorProvider_LectorName.Clear();
            errorProvider_LectorPhone.Clear();
            errorProvider_LectorSurname.Clear();
            errorProvider_LectorThirdname.Clear();
            errorProvider_Specialize.Clear();
            errorProvider_Term.Clear();

            _lastOperation = AllOperationType.ClearForm;
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            
            _disciplineList.RemoveAt(listBox_ShowList.SelectedIndex);
            ShowList(_disciplineList);


            toolStripLabel_itemsCounty.Text = "Всего элементов в списке: ";
            toolStripLabel_itemsCounty.Text += listBox_ShowList.Items.Count;

            SaveState(ListOperationType.ItemRemove, _disciplineList);
            _lastOperation = AllOperationType.RemoveItem;
        }

        private void toolStripButton_HideTools_Click(object sender, EventArgs e)
        {
            this.toolStrip.Hide();
        }

        private void Tools_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip.Show();
        }

        private List<Discipline> CloneList(List<Discipline> disciplines)
        {
            List<Discipline> clonedDisciplines = new List<Discipline>();
            foreach (Discipline discipline in disciplines)
                clonedDisciplines.Add(discipline.Clone() as Discipline);
            return clonedDisciplines;
        }
        private void SaveState(ListOperationType operationType, List<Discipline> discipline)
        {
            _operationHistory.Operations.Add(new Memento(operationType, CloneList(discipline)));
            _operationHistory.CurrentOperation = _operationHistory.Operations.Count - 1;
        }
        private void LoadState(Memento operation)
        {
            ShowList(operation.DisciplineList);
            _disciplineList = operation.DisciplineList;
        }
        private void toolStripButton_Back_Click(object sender, EventArgs e)
        {
            if (_operationHistory.CurrentOperation == 0)
                return;

            _operationHistory.CurrentOperation--;

            LoadState(_operationHistory.GetCurrentOperationMemento());
            _lastOperation = AllOperationType.Undo;
        }

        private void toolStripButton_Forward_Click(object sender, EventArgs e)
        {
            if (_operationHistory.Operations.Count == 0)
                return;
            if (_operationHistory.CurrentOperation == _operationHistory.Operations.Count - 1)
                return;

            _operationHistory.CurrentOperation++;

            LoadState(_operationHistory.GetCurrentOperationMemento());
            _lastOperation = AllOperationType.Redo;
        }
    }
}