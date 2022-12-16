using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Строки_1_Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder(richTextBox1.Text);
            string subst1 = textBox1.Text;
            string subst2 = textBox2.Text;
            text.Replace(subst1, subst2);
            richTextBox1.Text+="\nИзменённая строка: " + text.ToString();
        }
    }
}
