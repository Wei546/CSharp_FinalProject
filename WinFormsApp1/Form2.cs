using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool check;
            check = checkedListBox1.GetItemChecked(0) || checkedListBox1.GetItemChecked(1);
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1))
                {
                    MessageBox.Show("符合資格");
                }
                else if (check == true)
                {
                    MessageBox.Show("不符合資格");
                }
                else
                {
                    MessageBox.Show("尚未勾選，請勾選"); 
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                bool check2;
                check2 = checkedListBox1.GetItemChecked(0) ||
                    checkedListBox1.GetItemChecked(1) ||
                    checkedListBox1.GetItemChecked(2) ||
                    checkedListBox1.GetItemChecked(3);
                if (checkedListBox1.GetItemChecked(0) &&
                    checkedListBox1.GetItemChecked(1) &&
                    checkedListBox1.GetItemChecked(2) &&
                    checkedListBox1.GetItemChecked(3))
                {
                    MessageBox.Show("符合資格");
                }
                else if (check2 == true)
                {
                    MessageBox.Show("不符合資格");
                }
                else
                {
                    MessageBox.Show("尚未勾選，請勾選"); 
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Enabled = true;
                string[] CheckItems = { "年齡>65", "低收入戶" };
                foreach (string item in CheckItems)
                {   
                    checkedListBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                button1.Enabled = true;
                string[] CheckItems = { "年齡>65", "中低收入戶", "身心障礙", "在地居民" };
                foreach (string item in CheckItems)
                {
                    checkedListBox1.Items.Add(item);
                }
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            string[] ElderChoice = { "屏東縣中低收入老人醫療補助", "屏東縣老人健保補助" };
            int ArrayLength = ElderChoice.Length;
            for (int i = 0; i < ArrayLength; i++)
            {
                comboBox1.Items.Add(ElderChoice[i]);
            }

            string[] DisabledChoice = { "身心障礙者生活補助", "屏東縣政府身心障礙者輔具費用補助" };
            int DisabledLength = ElderChoice.Length;
            for (int i = 0; i < ArrayLength; i++)
            {
                comboBox2.Items.Add(DisabledChoice[i]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkedListBox2.Items.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                button2.Enabled = true;
                string[] CheckItems = { "設籍並實際居住於屏東", "依法領有身心障礙手冊或身心障礙證明" };
                foreach (string item in CheckItems)
                {
                    checkedListBox2.Items.Add(item);
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                button2.Enabled = true;
                string[] CheckItems = { "設籍屏東縣，且最近一年居住國內超過一百八十三日以上", 
                    "領有身心障礙手冊或身心障礙證明", 
                    "符合輔具補助基準表補助對象"};
                foreach (string item in CheckItems)
                {
                    checkedListBox2.Items.Add(item);
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool checkDisabled;
            checkDisabled = checkedListBox2.GetItemChecked(0) || checkedListBox2.GetItemChecked(1);
            if (comboBox2.SelectedIndex == 0)
            {
                
                if (checkedListBox2.GetItemChecked(0) && checkedListBox2.GetItemChecked(1))
                {
                    MessageBox.Show("符合資格");
                }
                else if (checkDisabled == false)
                {
                    MessageBox.Show("尚未勾選，請勾選");
                }
                else
                {
                    MessageBox.Show("不符合資格");
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                button2.Enabled = true;
                bool checkDisabled2;
                checkDisabled2 = checkedListBox2.GetItemChecked(0) ||
                    checkedListBox2.GetItemChecked(1) ||
                    checkedListBox2.GetItemChecked(2);
                if (checkedListBox2.GetItemChecked(0) &&
                    checkedListBox2.GetItemChecked(1) &&
                    checkedListBox2.GetItemChecked(2))
                {
                    MessageBox.Show("符合資格");
                }
                else if (checkDisabled2 == false)
                {
                    MessageBox.Show("尚未勾選，請勾選");
                }
                else
                {
                    MessageBox.Show("不符合資格");
                }
            }
        }
    }
}
