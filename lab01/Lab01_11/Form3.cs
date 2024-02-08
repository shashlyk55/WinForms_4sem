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
    public partial class Form3 : Form
    {
        public Form3()
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
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                CheckNumbers(textBox1.Text) || CheckNumbers(textBox2.Text) || CheckNumbers(textBox3.Text))
            {
                Form errorForm = new Form4();
                errorForm.ShowDialog();
                return;
            }
            

            float a = Convert.ToSingle(textBox1.Text);
            float b = Convert.ToSingle(textBox2.Text);
            float c = Convert.ToSingle(textBox3.Text);

            if(a < 0 || c < 0 || b < 0)
            {
                Form errorForm = new Form4();
                errorForm.ShowDialog();
                return;
            }

            if (radioButton1.Checked)
            {
                if (a < 170 && b < 92 && c < 80)
                    label3.Text += "S";
                else if (a >= 170 && a < 176 && b >= 92 && b < 96 && c >= 80 && c < 84)
                    label3.Text += "M";
                else if (a >= 176 && a < 182 && b >= 96 && b < 100 && c >= 84 && c < 88)
                    label3.Text += "L";
                else if (a >= 182 && a < 188 && b >= 100 && b < 104 && c >= 88 && c < 92)
                    label3.Text += "XL";
                else if (a >= 188 && a < 194 && b >= 104 && b < 108 && c >= 92 && c < 96)
                    label3.Text += "XXL";
                else if (a > 194 && b > 104 && c > 96)
                    label3.Text += "XXXL";
            }
            if (radioButton2.Checked)
            {
                if (a < 164 && b < 88 && c < 96)
                    label3.Text += "S";
                else if (a >= 164 && a < 170 && b >= 92 && b < 96 && c >= 96 && c < 104)
                    label3.Text += "M";
                else if (a >= 176 && a < 182 && b >= 96 && b < 104 && c >= 104 && c < 112)
                    label3.Text += "L";
                else if (a >= 182 && a < 188 && b >= 104 && b < 112 && c >= 112 && c < 120)
                    label3.Text += "XL";
                else if (a >= 188 && a < 194 && b >= 112 && b < 116 && c >= 120 && c < 124)
                    label3.Text += "XXL";
                else if (a > 194 && b > 116 && c > 124)
                    label3.Text += "XXXL";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Обхват бедер(см): ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Обхват талии(см): ";
        }
    }
}
