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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] classFirst = new int[5];
        int[] classSecond = new int[5];
        int[] classThird = new int[5];
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isDataIncomplete = false;
            bool isInvalidValue = false;

            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                for (int col = 1; col < dataGridView1.ColumnCount - 1; col++)
                {
                    if (string.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        isDataIncomplete = true;
                        break;
                    }

                    int value;
                    if (int.TryParse(dataGridView1.Rows[row].Cells[col].Value?.ToString(), out value))
                    {
                        if (value > 5)
                        {
                            isInvalidValue = true;
                            break;
                        }
                    }
                    else
                    {
                        isInvalidValue = true;
                        break;
                    }
                }

                if (isDataIncomplete || isInvalidValue)
                    break;
            }

            if (isDataIncomplete)
            {
                MessageBox.Show("請輸入所有平均值");
                return;
            }

            if (isInvalidValue)
            {
                MessageBox.Show("請輸入小於6的數值");
                return;
            }
            

            try
            {
                float avgFirst = 0.0f;
                float avgSecond = 0.0f;
                float avgThird = 0.0f;

    
                for (int i = 1; i < 6; i++) 
                {
                    classFirst[i - 1] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                    classSecond[i - 1] = Convert.ToInt32(dataGridView1.Rows[1].Cells[i].Value);
                    classThird[i - 1] = Convert.ToInt32(dataGridView1.Rows[2].Cells[i].Value);

                    avgFirst += classFirst[i - 1];
                    avgSecond += classSecond[i - 1];
                    avgThird += classThird[i - 1];
                }

                avgFirst /= 5.0f; 
                avgSecond /= 5.0f;
                avgThird /= 5.0f;

                
                dataGridView1.Rows[0].Cells[6].Value = avgFirst.ToString();
                dataGridView1.Rows[1].Cells[6].Value = avgSecond.ToString();
                dataGridView1.Rows[2].Cells[6].Value = avgThird.ToString();
                if (avgFirst  > 2)
                {
                    MessageBox.Show("案主1未達結案標準");
                }
                if (avgSecond > 2)
                {
                    MessageBox.Show("案主2未達結案標準");
                }
                if (avgThird > 2)
                {
                    MessageBox.Show("案主3未達結案標準");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "開始計算";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 3;

            

            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].Width = 90;
            }

           

            for (int i = 1; i < 6; i++)
            {
                dataGridView1.Columns[i].Name = "條件" + i.ToString();

            }
            dataGridView1.Columns[6].Name = "平均分數";

            for (int i = 0; i < 3; i++) 
            {
                dataGridView1.Rows[i].Cells[0].Value = "案主" + (i + 1).ToString();
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
            dataGridView1.Rows[0].Cells[6].ReadOnly = true;
            dataGridView1.Rows[1].Cells[6].ReadOnly = true;
            dataGridView1.Rows[2].Cells[6].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
