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
using System.Text.RegularExpressions;

namespace RandomNum
{
    public partial class RandomProject : Form
    {
        private int randomNum;
        private string randomStr;
        private string[] randomArray;
        private bool start = false;
        private Thread t1;

        public RandomProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 執行亂數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomBtn_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 亂數動作
        /// </summary>
        /// <param name="o"></param>
        private void randomRun(object o)
        {
            randomArray = TextLable.Text.Split('\n');
            for (; ; )
            {
                Random crandom = new Random();
                randomNum = crandom.Next(0, randomArray.Count());
                randomStr = randomArray[randomNum].ToString();

                try
                {
                    //跨執行續動作
                    MethodInvoker mi = new MethodInvoker(UpdateUI);
                    BeginInvoke(mi, null);
                }
                catch
                {
                }

                Thread.Sleep(50);
            }
        }

        private void UpdateUI()
        {
            RandomLabel.Text = randomStr.Replace(randomStr.Split('.')[0] + ". ", ""); ;
        }

        /// <summary>
        /// 新增項目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBox.Text))
            {
                if (string.IsNullOrWhiteSpace(TextLable.Text))
                {
                    TextLable.Text += "1. " + TextBox.Text;
                }
                else
                {
                    TextLable.Text += "\n" + (TextLable.Text.Split('\n').Count() + 1) + ". " + TextBox.Text;
                }
                TextBox.Text = "";
            }
            this.TextBox.Focus();
        }

        /// <summary>
        /// 刪除上一個新增的項目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string str = "";
            randomArray = TextLable.Text.Split('\n');
            if (string.IsNullOrWhiteSpace(DeleteTextBox.Text))
            {
                if (randomArray.Count() == 1)
                {
                    TextLable.Text = "";
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
                        TextLable.Text = str;
                    }
                }
            }
            else if (!string.IsNullOrWhiteSpace(DeleteTextBox.Text))
            {
                string text = DeleteTextBox.Text;
                string[] delStrArray;
                delStrArray = text.Split(',');
                for (int x = 0; x < randomArray.Count(); x++)
                {
                    bool isDel = false;
                    foreach (string y in delStrArray)
                    {
                        if ((x + 1).ToString() == y)
                        {
                            isDel = true;
                        }
                    }
                    if (isDel != true)
                    {
                        if (x == 0)
                        {
                            str += randomArray[x];
                        }
                        else
                        {
                            str += "\n" + randomArray[x];
                        }
                    }
                    TextLable.Text = str;
                }
            }
        }

        /// <summary>
        /// 清除所有項目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextLable.Text = "";
        }

        /// <summary>
        /// 清除亂數結果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomBtnClear_Click(object sender, EventArgs e)
        {
            RandomLabel.Text = "";
        }

        /// <summary>
        /// 設定輸入時可用Enter代替Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                EnterBtn_Click(null, null);
            }
        }
    }
}