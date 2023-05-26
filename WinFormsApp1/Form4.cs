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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] caseNum = new string[] { "A1100102", "A1100203", "A1111221" };
        string[] name = new string[] { "May", "Ellen", "Paul" };
        int[] age = new int[] { 65, 58, 66 };
        string[] income = new string[] { "低收", "中低收", "小康" };
        bool found;
        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Text = "查詢";
            label1.Text = "請輸入欲查詢案號：\r\n" + "如：A1100102";
            label1.Font = new Font("標楷體", 12, FontStyle.Bold);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 3;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "年齡";
            dataGridView1.Columns[3].Name = "經濟";
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].Width = 90;
            }


            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    dataGridView1.Rows[i].Cells[k].ReadOnly = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            found = false;
            string input = Convert.ToString(textBox1.Text);
            for (int k = 0; k < 3; k++)
            {
                if (input == caseNum[k])
                {
                    dataGridView1.Rows[k].Cells[0].Value = caseNum[k];
                    dataGridView1.Rows[k].Cells[1].Value = name[k];
                    dataGridView1.Rows[k].Cells[2].Value = age[k];
                    dataGridView1.Rows[k].Cells[3].Value = income[k];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("未找到相對應的案主");
                return;
            }
        }
    }
}
