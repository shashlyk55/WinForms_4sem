using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool CheckNumbers(string s)
        {
            foreach (var c in s)
                if (Convert.ToByte(c) > Convert.ToByte('9') || Convert.ToByte(c) < Convert.ToByte('0'))
                    return true;
            
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float min_sm = 23, min_ru = 36, min_uk = 3.5f;

            if((listBox1.SelectedItem == null || textBox1.Text == "") || CheckNumbers(textBox1.Text) ||
                (Convert.ToSingle(textBox1.Text) < 23 && Convert.ToSingle(textBox1.Text) > 33))
            {
                Form form4 = new Form4();
                form4.ShowDialog();
                return;
            }

            label3.Text = "Результат: ";
            switch (listBox1.SelectedItem)
            {
                case ("европейский"):
                        label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_ru - 1;
                    break;
                case ("русский/белорусский"):
                    label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_ru;
                    break;
                case ("американский"):
                    if (radioButton1.Checked)
                        label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_uk + 1;
                    if (radioButton2.Checked)
                        label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_uk + 3;
                    break;
                case ("британский"):
                    if (radioButton1.Checked)
                        label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_uk;
                    if (radioButton2.Checked)
                        label3.Text += Convert.ToDouble(textBox1.Text) - min_sm + min_uk - 0.5f;
                    break;
            }
            
        }
    }
}
