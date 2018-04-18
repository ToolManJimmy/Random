using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RandomNum
{
    public partial class Form1 : Form
    {
        private int randomNum;
        private string randomStr;
        private string[] randomArray;
        private bool start = false;
        private Thread t1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                t1 = new Thread(new ParameterizedThreadStart(randomRun));
                t1.Start();
                start = true;
            }
            else
            {
                if (t1 != null && t1.IsAlive)
                {
                    t1.Abort();
                }
                start = false;
            }
        }

        private void randomRun(object o)
        {
            randomArray = label2.Text.Split('\n');
            for (; ; )
            {
                Random crandom = new Random();
                randomNum = crandom.Next(0, randomArray.Count());
                randomStr = randomArray[randomNum];

                try
                {
                    MethodInvoker mi = new MethodInvoker(this.UpdateUI);
                    this.BeginInvoke(mi, null);
                }
                catch
                {
                }

                Thread.Sleep(50);
            }
        }

        private void UpdateUI()
        {
            label1.Text = randomStr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (string.IsNullOrWhiteSpace(label2.Text))
                {
                    label2.Text += textBox1.Text;
                }
                else
                {
                    label2.Text += "\n" + textBox1.Text;
                }
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            randomArray = label2.Text.Split('\n');
            if (randomArray.Count() == 1)
            {
                label2.Text = "";
            }
            else
            {
                for (int x = 0; x < randomArray.Count() - 1; x++)
                {
                    if (x == 0)
                    {
                        str += randomArray[x];
                    }
                    else
                    {
                        str += "\n" + randomArray[x];
                    }
                    label2.Text = str;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}