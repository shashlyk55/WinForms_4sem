using System;
using System.Collections;
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
    public partial class MainForm : Form
    {
        private List<Discipline> _disciplineList;
        private FormHistory history;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckRussianText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[а-яёА-ЯЁ]") && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void textBox_Discipline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Regex.IsMatch(e.KeyChar.ToString(), @"[а-яёА-ЯЁ \.]"))
                e.Handled = true;
        }



        private void textBox_Discipline_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Discipline.Text))
                errorProvider_Discipline.SetError(textBox_Discipline, "Поле не должно быть пустым!");
            else
                errorProvider_Discipline.Clear();
        }

        private void textBox_LectorSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LectorSurname.Text))
                errorProvider_LectorSurname.SetError(textBox_LectorSurname, "Поле не должно быть пустым!");
            else
                errorProvider_LectorSurname.Clear();
        }

        private void textBox_LectorName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LectorName.Text))
                errorProvider_LectorName.SetError(textBox_LectorName, "Поле не должно быть пустым!");
            else
                errorProvider_LectorName.Clear();
        }

        private void textBox_LectorThirdname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LectorThirdname.Text))
                errorProvider_LectorThirdname.SetError(textBox_LectorThirdname, "Поле не должно быть пустым!");
            else
                errorProvider_LectorThirdname.Clear();
        }


        private void textBox_LectorKabinet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LectorKabinet.Text))
                errorProvider_LectorKabinet.SetError(textBox_LectorKabinet, "Поле не должно быть пустым!");
            else
            {
                errorProvider_LectorKabinet.Clear();

                if (!Regex.IsMatch(textBox_LectorKabinet.Text, @"^[0-9]*$"))
                    errorProvider_LectorKabinet.SetError(textBox_LectorKabinet, "Поле должно содержать только цифры!");
                else
                    errorProvider_LectorKabinet.Clear();
            }
        }
        private bool IsMaskCompleted(string mask, string text)
        {
            // Удаляем все нецифровые символы из маски и текста
            string cleanedMask = new string(mask.Where(char.IsDigit).ToArray());
            string cleanedText = new string(text.Where(char.IsDigit).ToArray());

            // Сравниваем длины очищенной маски и текста
            return cleanedMask.Length == cleanedText.Length;
        }
        private void textBox_LectorPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!IsMaskCompleted(textBox_LectorPhone.Mask, textBox_LectorPhone.Text))
                errorProvider_LectorPhone.SetError(textBox_LectorPhone, "Неверный формат ввода!");
            else
                errorProvider_LectorPhone.Clear();
        }

        private void comboBox_Kafedra_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox_Kafedra.SelectedIndex == -1)
                errorProvider_LectorKafedra.SetError(comboBox_Kafedra, "Кафедра должна быть выбрана!");
            else
                errorProvider_LectorKafedra.Clear();
        }
        private void checkedListBox_Spec_Validating(object sender, CancelEventArgs e)
        {
            if (checkedListBox_Spec.SelectedIndex == -1)
                errorProvider_Specialize.SetError(checkedListBox_Spec, "Выберите специальность!");
            else
                errorProvider_Specialize.Clear();
        }
        private void groupBox_Terms_Validating(object sender, CancelEventArgs e)
        {
            if (!(checkBox_Term1.Checked || checkBox_Term2.Checked))
                errorProvider_Term.SetError(groupBox_Terms, "Выберите семестр!");
            else
                errorProvider_Term.Clear();
        }

        private bool CheckEmpty_Elements()
        {
            return string.IsNullOrWhiteSpace(textBox_Discipline.Text) &&
                string.IsNullOrWhiteSpace(textBox_LectorSurname.Text) &&
                string.IsNullOrWhiteSpace(textBox_LectorName.Text) &&
                string.IsNullOrWhiteSpace(textBox_LectorThirdname.Text) &&
                string.IsNullOrWhiteSpace(textBox_LectorPhone.Text) &&
                string.IsNullOrWhiteSpace(textBox_LectorKabinet.Text) &&
                comboBox_Kafedra.SelectedIndex == -1 &&
                !(checkBox_Term1.Checked || checkBox_Term2.Checked) &&
                checkedListBox_Spec.SelectedIndex == -1;
        }

        private void button_SaveToJSON_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmpty_Elements())
                {
                    throw new Exception("В форме есть незаполненные поля!");
                }

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
                        kabinet: int.Parse(textBox_LectorKabinet.Text),
                        phone: groupBox_LectorInfo.Controls["textBox_LectorPhone"].Text
                    )
                );

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

            label_itemsCounty.Text = "Всего элементов в списке: ";
            label_itemsCounty.Text += listBox_ShowList.Items.Count;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            _disciplineList = Serializer.DeserializationList("serialize.json");
            foreach(var item in _disciplineList)
            {
                listBox_ShowList.Items.Add(item);
            }

            history = new FormHistory();
        }

        private void trackBar_HourCounty_ValueChanged(object sender, EventArgs e)
        {
            label_HoursCounty.Text = "Количество часов: " + trackBar_HourCounty.Value.ToString();
        }

        private void numericUpDown_Course_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void numericUpDown_Course_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Search_MenuItem_Click(object sender, EventArgs e)
        {
            Form searchFrom = new SearchForm();
            searchFrom.ShowDialog();
        }

        private void MenuItem_SortOnControlType_Click(object sender, EventArgs e)
        {
            ShowList(_disciplineList.OrderBy(x => x.ControlType).ToList());

            label_itemsCounty.Text = "Всего элементов в списке: ";
            label_itemsCounty.Text += listBox_ShowList.Items.Count;
        }

        private void MenuItem_SortOnHoursCounty_Click(object sender, EventArgs e)
        {
            ShowList(_disciplineList.OrderBy(x => x.HoursCounty).ToList());

            label_itemsCounty.Text = "Всего элементов в списке: ";
            label_itemsCounty.Text += listBox_ShowList.Items.Count;
        }

        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            Serializer.SerializationList(_disciplineList.OrderBy(x => x.HoursCounty).ToList(), "sortedList.json");
        }

        private void AboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\tVersion 1.0.1\t\t\n\n\t\tSlesarev Ivan", "About", MessageBoxButtons.OK);
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
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            listBox_ShowList.Items.Remove(listBox_ShowList.SelectedItem);

            label_itemsCounty.Text = "Всего элементов в списке: ";
            label_itemsCounty.Text += listBox_ShowList.Items.Count;

            SaveState();
        }

        private void toolStripButton_HideTools_Click(object sender, EventArgs e)
        {
            this.toolStrip.Hide();
        }

        private void Tools_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip.Show();
        }

        private void toolStripButton_Back_Click(object sender, EventArgs e)
        {
            RestoreState(history.History.Pop());
        }

        
    }
}
