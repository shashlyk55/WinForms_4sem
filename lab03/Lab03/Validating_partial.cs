using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class MainForm
    {
        /*private void CheckRussianText_KeyPress(object sender, KeyPressEventArgs e)
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
        }*/



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

        /*private bool CheckEmpty_Elements()
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
        }*/


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
