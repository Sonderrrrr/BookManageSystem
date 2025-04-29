namespace 图书管理系统
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminRadioButton2 = new System.Windows.Forms.RadioButton();
            this.generalRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordModificationButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.logInButton);
            this.groupBox1.Controls.Add(this.passwordModificationButton);
            this.groupBox1.Controls.Add(this.adminRadioButton2);
            this.groupBox1.Controls.Add(this.generalRadioButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1291, 886);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // adminRadioButton2
            // 
            this.adminRadioButton2.AutoSize = true;
            this.adminRadioButton2.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.adminRadioButton2.Location = new System.Drawing.Point(700, 235);
            this.adminRadioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminRadioButton2.Name = "adminRadioButton2";
            this.adminRadioButton2.Size = new System.Drawing.Size(121, 33);
            this.adminRadioButton2.TabIndex = 8;
            this.adminRadioButton2.TabStop = true;
            this.adminRadioButton2.Text = "管理员";
            this.adminRadioButton2.UseVisualStyleBackColor = true;
            // 
            // generalRadioButton
            // 
            this.generalRadioButton.AutoSize = true;
            this.generalRadioButton.Checked = true;
            this.generalRadioButton.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.generalRadioButton.Location = new System.Drawing.Point(468, 235);
            this.generalRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalRadioButton.Name = "generalRadioButton";
            this.generalRadioButton.Size = new System.Drawing.Size(150, 33);
            this.generalRadioButton.TabIndex = 7;
            this.generalRadioButton.TabStop = true;
            this.generalRadioButton.Text = "普通用户";
            this.generalRadioButton.UseVisualStyleBackColor = true;
            // 
            // passwordModificationButton
            // 
            this.passwordModificationButton.AutoSize = true;
            this.passwordModificationButton.BackColor = System.Drawing.Color.Transparent;
            this.passwordModificationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.passwordModificationButton.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.passwordModificationButton.Location = new System.Drawing.Point(583, 300);
            this.passwordModificationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordModificationButton.Name = "passwordModificationButton";
            this.passwordModificationButton.Size = new System.Drawing.Size(139, 39);
            this.passwordModificationButton.TabIndex = 6;
            this.passwordModificationButton.Text = "修改密码";
            this.passwordModificationButton.UseVisualStyleBackColor = false;
            this.passwordModificationButton.Click += new System.EventHandler(this.passwordModificationButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(830, 300);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(81, 39);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = true;
            this.logInButton.BackColor = System.Drawing.Color.Transparent;
            this.logInButton.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.logInButton.Location = new System.Drawing.Point(386, 300);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(84, 39);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "登陆";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(644, 164);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(177, 25);
            this.passwordTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(644, 110);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 25);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(446, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(446, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正舒体", 36.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(500, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(276, 65);
            this.label3.TabIndex = 9;
            this.label3.Text = "登录界面";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1277, 823);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passwordModificationButton;
        private System.Windows.Forms.RadioButton adminRadioButton2;
        private System.Windows.Forms.RadioButton generalRadioButton;
        private System.Windows.Forms.Label label3;
    }
}