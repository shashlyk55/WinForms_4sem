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

namespace Lab02
{
    public partial class Main_Form : Form
    {
        public List<Discipline> list;
        public Main_Form()
        {
            InitializeComponent();
        }


        private void TextBoxLectorPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_LectorPhone.SelectionStart = textBox_LectorPhone.TextLength;

            if(textBox_LectorPhone.Text.Length > 16) 
                    return;
        
            if (char.IsDigit(e.KeyChar))
            {
                
                if (textBox_LectorPhone.Text.Length == 0)
                    textBox_LectorPhone.Text += '+';
                if (textBox_LectorPhone.Text.Length == 4)
                    textBox_LectorPhone.Text += '(';
                if (textBox_LectorPhone.Text.Length == 7)
                    textBox_LectorPhone.Text += ')';
                if (textBox_LectorPhone.Text.Length == 10 || textBox_LectorPhone.Text.Length == 13)
                    textBox_LectorPhone.Text += '-';

                textBox_LectorPhone.Text += e.KeyChar;
                e.Handled = true;
            }
            else if(e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void CheckRussianText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex.IsMatch(e.KeyChar.ToString(), @"[а-яёА-ЯЁ]") && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void textBox_Discipline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '\b' && !Regex.IsMatch(e.KeyChar.ToString(), @"[а-яёА-ЯЁ \.]"))
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

        private void textBox_LectorPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LectorPhone.Text))
                errorProvider_LectorPhone.SetError(textBox_LectorPhone, "Поле не должно быть пустым!");
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
                    this.textBox_Discipline.Text,
                    GetCheckedValues_Terms(),
                    (int)this.numericUpDown_Course.Value,
                    GetCheckedValues_Spec(),
                    (this.radioButton_Exam.Checked ? "Экзамен" : "Зачет"),
                    this.trackBar_HourCounty.Value,
                    new Lector(
                        this.groupBox_LectorInfo.Controls["textBox_LectorSurname"].Text,
                        this.groupBox_LectorInfo.Controls["textBox_LectorName"].Text,
                        this.groupBox_LectorInfo.Controls["textBox_LectorThirdname"].Text,
                        this.comboBox_Kafedra.SelectedItem as string,
                        int.Parse(this.textBox_LectorKabinet.Text),
                        this.groupBox_LectorInfo.Controls["textBox_LectorPhone"].Text
                        )
                );

                list.Add(discipline);
                listBox_ShowList.Items.Clear();
                foreach (var item in list)
                {
                    listBox_ShowList.Items.Add(item.ToString());
                }

                Serializer.SerializationList(list, "serialize.json");

                this.textBox_Discipline.Text = "";
                this.textBox_LectorSurname.Text = "";
                this.textBox_LectorName.Text = "";
                this.textBox_LectorThirdname.Text = "";
                this.textBox_LectorPhone.Text = "";
                this.textBox_LectorKabinet.Text = "";
                this.comboBox_Kafedra.SelectedIndex = -1;
                this.checkBox_Term1.Checked = false;
                this.checkBox_Term2.Checked = false;
                for(int i = 0; i < checkedListBox_Spec.Items.Count; i++)
                {
                    checkedListBox_Spec.SetItemChecked(i, false);
                }
                this.trackBar_HourCounty.Value = 1;
            }
            catch(Exception ex)
            {
                Form error = new Error_Form(ex.Message);
                error.ShowDialog();
            }
        }

        private void button_LoadFromJSON_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.AddRange(Serializer.DeserializationList("serialize.json"));

            listBox_ShowList.Items.Clear();
            foreach(Discipline item in list)
            {
                listBox_ShowList.Items.Add(item.ToString());
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            list = new List<Discipline>();
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
    }
}
