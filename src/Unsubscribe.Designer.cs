﻿namespace 图书管理系统
{
    partial class Unsubscribe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unsubscribe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButtom = new System.Windows.Forms.Button();
            this.confirmButtom = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.hintLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cancelButtom);
            this.groupBox1.Controls.Add(this.confirmButtom);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1286, 795);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账户注销";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hintLabel.Location = new System.Drawing.Point(544, 174);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(18, 26);
            this.hintLabel.TabIndex = 26;
            this.hintLabel.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(466, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "提示：注销后账号的记录全部消失";
            // 
            // cancelButtom
            // 
            this.cancelButtom.AutoSize = true;
            this.cancelButtom.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButtom.Location = new System.Drawing.Point(694, 220);
            this.cancelButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButtom.Name = "cancelButtom";
            this.cancelButtom.Size = new System.Drawing.Size(100, 36);
            this.cancelButtom.TabIndex = 24;
            this.cancelButtom.Text = "取消";
            this.cancelButtom.UseVisualStyleBackColor = true;
            this.cancelButtom.Click += new System.EventHandler(this.cancelButtom_Click);
            // 
            // confirmButtom
            // 
            this.confirmButtom.AutoSize = true;
            this.confirmButtom.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmButtom.Location = new System.Drawing.Point(483, 220);
            this.confirmButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButtom.Name = "confirmButtom";
            this.confirmButtom.Size = new System.Drawing.Size(100, 36);
            this.confirmButtom.TabIndex = 23;
            this.confirmButtom.Text = "确认";
            this.confirmButtom.UseVisualStyleBackColor = true;
            this.confirmButtom.Click += new System.EventHandler(this.confirmButtom_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(477, 108);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(64, 26);
            this.lblPwd.TabIndex = 22;
            this.lblPwd.Text = "密码:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(477, 51);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 26);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "用户名:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextBox.Location = new System.Drawing.Point(623, 108);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(171, 34);
            this.passwordTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("方正姚体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.Location = new System.Drawing.Point(623, 51);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 34);
            this.nameTextBox.TabIndex = 19;
            // 
            // Unsubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 795);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unsubscribe";
            this.Text = "账户注销系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button cancelButtom;
        private System.Windows.Forms.Button confirmButtom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hintLabel;
    }
}