using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Строки_2_Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string[] text = richTextBox1.Text.Split(' ', '.', ',', ':', ';', '!', '?','\n'); ;
            string[] result = new string[text.Length];
            string res = "";
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > max)
                {
                    max = text[i].Length;
                    result[i] = text[i];
                    res = text[i];
                }
                if (text[i].Length == max)
                {
                    result[i] = text[i];
                }
            }
            richTextBox1.Text+="\nСамое длинное слово: ";
            for (int i = 0; i < result.Length; i++)
            {
                if (res.Length >= result[i].Length)
                {
                    flag = true;
                    break;
                }
                else
                {
                    richTextBox1.Text += result[i] + " ";
                }
            }
            if (flag) richTextBox1.Text += res;
        }
    }
}
