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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                return;
            }

            this.label2.Text = "Результат: ";
            switch (this.listBox1.Text)
            {
                case "2-cc":
                    this.label2.Text += Convert.ToString(Convert.ToInt32(this.textBox1.Text), 2);
                    break;
                case "8-cc":
                    this.label2.Text += Convert.ToString(Convert.ToInt32(this.textBox1.Text), 8);
                    break;
                case "10-cc":
                    this.label2.Text += Convert.ToString(Convert.ToInt32(this.textBox1.Text), 10);
                    break;
                case "16-cc":
                    this.label2.Text += Convert.ToString(Convert.ToInt32(this.textBox1.Text), 16);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = null;
        }
    }
}
