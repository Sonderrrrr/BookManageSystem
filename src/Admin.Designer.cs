using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    partial class Admin
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.UsersManageButton = new System.Windows.Forms.Button();
            this.BookManageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersManageButton
            // 
            this.UsersManageButton.BackColor = System.Drawing.Color.Transparent;
            this.UsersManageButton.Font = new System.Drawing.Font("方正姚体", 13.8F);
            this.UsersManageButton.Location = new System.Drawing.Point(505, 55);
            this.UsersManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersManageButton.Name = "UsersManageButton";
            this.UsersManageButton.Size = new System.Drawing.Size(126, 69);
            this.UsersManageButton.TabIndex = 0;
            this.UsersManageButton.Text = "用户管理";
            this.UsersManageButton.UseVisualStyleBackColor = false;
            // 
            // BookManageButton
            // 
            this.BookManageButton.BackColor = System.Drawing.Color.Transparent;
            this.BookManageButton.Font = new System.Drawing.Font("方正姚体", 13.8F);
            this.BookManageButton.Location = new System.Drawing.Point(698, 55);
            this.BookManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookManageButton.Name = "BookManageButton";
            this.BookManageButton.Size = new System.Drawing.Size(126, 69);
            this.BookManageButton.TabIndex = 1;
            this.BookManageButton.Text = "图书管理";
            this.BookManageButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("方正姚体", 13.8F);
            this.exitButton.Location = new System.Drawing.Point(505, 184);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 69);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "退出登陆";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("方正姚体", 13.8F);
            this.button1.Location = new System.Drawing.Point(698, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "登陆记录";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("方正姚体", 23.8F);
            this.button2.Location = new System.Drawing.Point(807, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("方正姚体", 23.8F);
            this.button3.Location = new System.Drawing.Point(558, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "用户管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("方正姚体", 23.8F);
            this.button4.Location = new System.Drawing.Point(327, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 56);
            this.button4.TabIndex = 4;
            this.button4.Text = "图书管理";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 719);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button UsersManageButton;
        private System.Windows.Forms.Button BookManageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private LogIn logIn;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}