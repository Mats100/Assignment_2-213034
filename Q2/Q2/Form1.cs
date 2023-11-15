using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        private List<string> dataList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                dataList.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataList.Clear();
            listBox1.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string data = textBox1.Text.ToString();
            if (!string.IsNullOrEmpty(data))
            {
                dataList.Add(data);
                listBox1.Items.Add(data);
                textBox1.Clear();
            }
        }
    }
}