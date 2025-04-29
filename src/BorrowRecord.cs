using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowRecord : Form
    {
        Form form;
        User User;
        
        public BorrowRecord(Form form, string name)
        {
            InitializeComponent();
            this.form = form;
            User = new User(name);
            showRecord();
            
            
        }

        public BorrowRecord(BooksManage booksManage)
        {
            this.booksManage = booksManage;
        }

        DataBaseConection DataBaseConection = new DataBaseConection();
        private BooksManage booksManage;

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showRecord();
        }

        public void showRecord()
        {
            
            libraryRecordDGV.DataSource=DataBaseConection.loanRecord(User.Name);
        }

        private void returnBookButtom_Click(object sender, EventArgs e)
        {
            if (libraryRecordDGV.Rows.Count!=0)
            {
                string returnTime = DateTime.Now.ToString();
                string borrowtime = libraryRecordDGV.CurrentRow.Cells[3].Value.ToString();
                string Username = User.Name;
                bool[] flag = new bool[2];
                flag = DataBaseConection.returnBook(returnTime, borrowtime,Username);
                if (flag[0])
                    MessageBox.Show("本书已经归还，不需要归还", "归还提示");
                else if(flag[1]) 
                    MessageBox.Show("本书已归还！！", "归还提示");
                else
                    MessageBox.Show("已成功归还", "归还提示");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中要还的书或没有借书记录");
            
        }
    }
}
