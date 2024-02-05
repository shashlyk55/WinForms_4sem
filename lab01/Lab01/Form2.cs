using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "" && this.listBox1.Text == "НЕ")
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                return;
            }
            if ((this.textBox1.Text == "" || this.textBox2.Text == "") && this.listBox1.Text != "НЕ")
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                return;
            }

            this.label1.Text = "Результат: ";

            switch (this.listBox1.Text)
            {
                case "И":
                    this.label1.Text += Convert.ToInt32(this.textBox1.Text) & Convert.ToInt32(this.textBox2.Text);
                    break;
                case "ИЛИ":
                    this.label1.Text += Convert.ToInt32(this.textBox1.Text) | Convert.ToInt32(this.textBox2.Text);
                    break;
                case "НЕ":
                    this.label1.Text += -Convert.ToInt32(this.textBox1.Text);
                    break;
                case "Исключающее ИЛИ":
                    this.label1.Text += Convert.ToInt32(this.textBox1.Text) ^ Convert.ToInt32(this.textBox2.Text);
                    break;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Text == "НЕ")
            {
                this.textBox2.Visible = false;
                this.label3.Visible = false;
            }
            else
            {
                this.textBox2.Visible = true;
                this.label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = null;
            this.textBox2.Text = null;
        }
    }
}
