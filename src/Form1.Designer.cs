namespace 图书管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogInlinkLabel = new System.Windows.Forms.LinkLabel();
            this.SignInlinkLabel = new System.Windows.Forms.LinkLabel();
            this.UnsubscribelinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInlinkLabel
            // 
            this.LogInlinkLabel.AutoSize = true;
            this.LogInlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogInlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInlinkLabel.Font = new System.Drawing.Font("方正舒体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogInlinkLabel.LinkColor = System.Drawing.Color.Snow;
            this.LogInlinkLabel.Location = new System.Drawing.Point(401, 471);
            this.LogInlinkLabel.Name = "LogInlinkLabel";
            this.LogInlinkLabel.Size = new System.Drawing.Size(106, 45);
            this.LogInlinkLabel.TabIndex = 2;
            this.LogInlinkLabel.TabStop = true;
            this.LogInlinkLabel.Text = "登陆";
            this.LogInlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignInlinkLabel
            // 
            this.SignInlinkLabel.AutoSize = true;
            this.SignInlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignInlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInlinkLabel.Font = new System.Drawing.Font("方正舒体", 25.8F);
            this.SignInlinkLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.SignInlinkLabel.LinkColor = System.Drawing.Color.Snow;
            this.SignInlinkLabel.Location = new System.Drawing.Point(89, 471);
            this.SignInlinkLabel.Name = "SignInlinkLabel";
            this.SignInlinkLabel.Size = new System.Drawing.Size(192, 45);
            this.SignInlinkLabel.TabIndex = 3;
            this.SignInlinkLabel.TabStop = true;
            this.SignInlinkLabel.Text = "用户注册";
            this.SignInlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInlinkLabel_LinkClicked);
            // 
            // UnsubscribelinkLabel
            // 
            this.UnsubscribelinkLabel.AutoSize = true;
            this.UnsubscribelinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnsubscribelinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnsubscribelinkLabel.Font = new System.Drawing.Font("方正舒体", 25.8F);
            this.UnsubscribelinkLabel.LinkColor = System.Drawing.Color.Snow;
            this.UnsubscribelinkLabel.Location = new System.Drawing.Point(613, 471);
            this.UnsubscribelinkLabel.Name = "UnsubscribelinkLabel";
            this.UnsubscribelinkLabel.Size = new System.Drawing.Size(192, 45);
            this.UnsubscribelinkLabel.TabIndex = 4;
            this.UnsubscribelinkLabel.TabStop = true;
            this.UnsubscribelinkLabel.Text = "账号注销";
            this.UnsubscribelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UnsubscribelinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("方正姚体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(150, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 90);
            this.label2.TabIndex = 6;
            this.label2.Text = "中山大学图书馆";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(348, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 597);
            this.Controls.Add(this.UnsubscribelinkLabel);
            this.Controls.Add(this.SignInlinkLabel);
            this.Controls.Add(this.LogInlinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LogInlinkLabel;
        private System.Windows.Forms.LinkLabel SignInlinkLabel;
        private System.Windows.Forms.LinkLabel UnsubscribelinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

