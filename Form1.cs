using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1301
{
   public partial class Form1 : Form
   {
        private int count = 1;

        public Form1()
      {
         InitializeComponent();
      }

      private void btnConfirm_Click(object sender, EventArgs e)
      {
         //建立一個處理文字方塊字串的陣列
         String[] temps = new String[5];
            if(textBox1.Text == "")
            {
                MessageBox.Show("請輸入學號", "錯誤");
                button3_Click(sender, e);
                label7.Text = "";
            }
            else
            {
                temps[0] = $"學號：{textBox1.Text}";
            }

            if (rabMale.Checked)
            {
                temps[1] = $"性別：{rabMale.Text}";
            }
            else if (rabFemale.Checked)
            {
                temps[1] = $"性別：{rabFemale.Text}";
            }
            else
            {
                MessageBox.Show("請選擇性別", "錯誤");
                button3_Click(sender, e);
                label7.Visible = false;
            }
            if (listBox1.SelectedIndex == 0)
            {
                temps[4] += $"專長：{listBox1.Text}";
            }
            
            if (listBox1.SelectedIndex == 1)
            {
                temps[4] += $"專長：{listBox1.Text}";
            }
            if(listBox1.SelectedIndex == 2)
            {
                temps[4]+= $"專長：{listBox1.Text}";
            }
            if (listBox1.SelectedIndex == 3)
            {
                temps[4] += $"專長：{listBox1.Text}";
            }
            if (checkBox1.Checked)
            {
                temps[3] += $"興趣：{checkBox1.Text} ";
            }
            if (checkBox2.Checked)
            {
                temps[3] += $"興趣：{checkBox2.Text} ";
            }
            if (checkBox3.Checked)
            {
                temps[3] += $"興趣：{checkBox3.Text} ";
            }
            if (checkBox4.Checked)
            {
                temps[3] += $"興趣：{checkBox4.Text} ";
            }
            if (checkBox5.Checked)
            {
                temps[3] += $"興趣：{checkBox5.Text} ";
            }
            if (comboBox2.SelectedIndex == 0)
            {
                temps[2] = $"年齡：{comboBox2.Text}";
            }
            else if(comboBox2.SelectedIndex == 1)
            {
                temps[2] = $"年齡：{comboBox2.Text}";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                temps[2] = $"年齡：{comboBox2.Text}";
            }
            else if(comboBox2.SelectedIndex == 3)
            {
                temps[2] = $"年齡：{comboBox2.Text}";
            }
            else
            {
                MessageBox.Show("請選擇年齡","錯誤");
                button3_Click(sender, e);
                label7.Visible = false;
            }


            //取得陣列內容放入文字方塊
            label7.Text = temps[0]+"\n"+ temps[1] + "\n" + temps[2] + "\n" + temps[3] + "\n" + temps[4];
            label7.Visible = true;
      }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            comboBox2.SelectedIndex = -1;
            rabMale.Checked = false;
            label7.Text = "";
            textBox1.Text = "";
        }
    }
}
