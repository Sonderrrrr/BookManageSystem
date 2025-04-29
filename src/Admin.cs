using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Admin : Form
    {
        Form form;

        public Admin(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void UsersManageButton_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(this);
            this.Hide();
            userManagement.Show();
        }

        private void BookManageButton_Click(object sender, EventArgs e)
        {
            BooksManage booksManage = new BooksManage(this);
            this.Hide();
            booksManage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(this);
            this.Hide();
            userManagement.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BooksManage booksManage = new BooksManage(this);
            this.Hide();
            booksManage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

