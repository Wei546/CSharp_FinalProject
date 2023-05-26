namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Subsidy;
        bool TakeCase;
        bool EndCase;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("標楷體", 12, FontStyle.Bold);
            label1.Text = "" +
                "本輸入框可輸入：\r\n" +
                "1.申請補助\r\n" + 
                "2.查詢案主\r\n" + 
                "3.結案評估\r\n"+ 
                "按「提交」分別進入不同視窗";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string input = Convert.ToString(textBox1.Text);
                if (input == "申請補助")
                {
                    Subsidy = true;
                    if (Subsidy == true)
                    {
                        Form2 Subsidy_Form;
                        Subsidy_Form = new Form2();
                        Subsidy_Form.Show();
                    }
                }
                else if (input == "查詢案主")
                {
                    TakeCase = true;
                    if (TakeCase == true)
                    {
                        Form4 TakeCase_Form;
                        TakeCase_Form = new Form4();
                        TakeCase_Form.Show();
                    }
                }
                else if (input == "結案評估")
                {
                    EndCase = true;
                    if (EndCase == true)
                    {
                        Form3 TakeCase_Form;
                        TakeCase_Form = new Form3();
                        TakeCase_Form.Show();
                    }
                }
                else
                {
                    throw new Exception("Exclude the service");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("請輸入：\r\n" + "申請補助\r\n" + "查詢案主\r\n" + "結案評估");
                return;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}