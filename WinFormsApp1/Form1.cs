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
            label1.Font = new Font("�з���", 12, FontStyle.Bold);
            label1.Text = "" +
                "����J�إi��J�G\r\n" +
                "1.�ӽиɧU\r\n" + 
                "2.�d�߮ץD\r\n" + 
                "3.���׵���\r\n"+ 
                "���u����v���O�i�J���P����";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string input = Convert.ToString(textBox1.Text);
                if (input == "�ӽиɧU")
                {
                    Subsidy = true;
                    if (Subsidy == true)
                    {
                        Form2 Subsidy_Form;
                        Subsidy_Form = new Form2();
                        Subsidy_Form.Show();
                    }
                }
                else if (input == "�d�߮ץD")
                {
                    TakeCase = true;
                    if (TakeCase == true)
                    {
                        Form4 TakeCase_Form;
                        TakeCase_Form = new Form4();
                        TakeCase_Form.Show();
                    }
                }
                else if (input == "���׵���")
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
                MessageBox.Show("�п�J�G\r\n" + "�ӽиɧU\r\n" + "�d�߮ץD\r\n" + "���׵���");
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