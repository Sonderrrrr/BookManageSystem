using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace 图书管理系统
{
    public partial class BorrowList : Form
    {
        DataBaseConection dataBaseConection = new DataBaseConection();
        Form form;
        public BorrowList(Form form)
        {
            InitializeComponent();
            this.form = form;
            showborrow();
        }

        //图书查找
        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookByName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBookByName_borrow(bookName);
                    dataGridView1.BackgroundColor = Color.White;
            }
        }

        //按用户名查找
        private void button1_Click(object sender, EventArgs e)
        {
            string bookName = textBox1.Text;
            if (textBox1.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookByUserName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBookByUserName_borrow(bookName);
                    dataGridView1.BackgroundColor = Color.White;
            }

        }
        public void showborrow()
        {

            dataGridView1.DataSource = dataBaseConection.showborrow();

        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string borrowtime = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string returned = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            bool isbrk =radioButton1.Checked;
            bool islost = radioButton2.Checked; 
            if (returned == "是")
            {
                MessageBox.Show("已经归还过了", "提示");
            }
            else
            {
                if (isbrk)
                {
                    MessageBox.Show("确保借阅人已经交罚款50元", "提示");
                }
                else if (islost)
                {
                    MessageBox.Show("确保借阅人已经交罚款100元", "提示");
                }
                string returnCommandText = "update loaninfo set returned='是',return_time='" + DateTime.Now.ToString("F") + "' where borrow_time='" + borrowtime + "'" + " and borrower='" + name + "'";
                if (isbrk)
                {
                    returnCommandText = "update loaninfo set returned='是',fine = 50,isbroken=true,return_time='" + DateTime.Now.ToString("F") + "' where borrow_time='" + borrowtime + "'" + " and borrower='" + name + "'";
                }
                if (islost)
                {
                    returnCommandText = "update loaninfo set returned='是',fine=100,islost=true,return_time='" + DateTime.Now.ToString("F") + "' where borrow_time='" + borrowtime + "'" + " and borrower='" + name + "'";
                }

                bool isBorrow = false;
                bool[] flag = new bool[2];

                string IsReturnCommandText = "select * from loaninfo where borrow_time='" + borrowtime + "'" + " and returned='否'";
                bool IsReturn = false;
                string connectionString = "server=localhost;port=3306;user=root;password=123456;database=library;";
                using (MySqlConnection returnBookConnection = new MySqlConnection(connectionString))
                {
                    returnBookConnection.Open();
                    MySqlCommand returnCommand = new MySqlCommand(returnCommandText, returnBookConnection);
                    MySqlCommand IsReturnCommand = new MySqlCommand(IsReturnCommandText, returnBookConnection);
                    using (MySqlDataReader IsReturnRead = IsReturnCommand.ExecuteReader())
                    {
                        if (IsReturnRead.Read())
                        {
                            if (IsReturnRead["returned"].ToString() == "是")
                            {
                                IsReturn = true;

                            }
                            else
                            {
                                IsReturn = false;

                            }

                            isBorrow = false;//选择的是你已经还了
                        }
                        else
                        {
                            isBorrow = true;
                        }
                    }
                    if (!IsReturn && !isBorrow)
                        returnCommand.ExecuteNonQuery();
                }
                flag[0] = IsReturn;
                flag[1] = isBorrow;

                MessageBox.Show("归还成功", "提示");
                showborrow();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
