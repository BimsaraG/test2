using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            string s = myString;
            var x = myString.Split(' ');
            listBox1.Items.AddRange(x);

            myString = string.Format("First letter of your text is {0} and the last is {1}", myString[0], myString[myString.Length - 1]);

            for (int i = 0;i <= s.Length;i++)
            {
                richTextBox1.Text += s.Substring(0, i) + "\n";
            }
            MessageBox.Show(s.Replace("p", "b"));
            MessageBox.Show(s.PadRight(20, '#'));
            s = "computer is an electronic information processing machine";
            MessageBox.Show(s.IndexOf("is").ToString());
            MessageBox.Show(s.IndexOf("is",15).ToString());
        }
    }
}
