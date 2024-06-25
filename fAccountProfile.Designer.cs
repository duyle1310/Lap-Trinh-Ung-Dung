
using System;

namespace QuanLyQuanCafe
{
    partial class fAccountProfile
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
            panel2 = new System.Windows.Forms.Panel();
            txbUserName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            txbDisplayName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txbPassWord = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            txbNewPass = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            txbReEnterPass = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnExti = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(6, 25);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(461, 58);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txbUserName.Location = new System.Drawing.Point(195, 9);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new System.Drawing.Size(246, 27);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(6, 108);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(461, 61);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txbDisplayName.Location = new System.Drawing.Point(195, 9);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new System.Drawing.Size(246, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new System.Drawing.Point(9, 192);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(461, 62);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txbPassWord.Location = new System.Drawing.Point(195, 9);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new System.Drawing.Size(246, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new System.Drawing.Point(6, 281);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(461, 62);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txbNewPass.Location = new System.Drawing.Point(195, 9);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new System.Drawing.Size(246, 27);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 24);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new System.Drawing.Point(6, 361);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(461, 62);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txbReEnterPass.Location = new System.Drawing.Point(195, 9);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new System.Drawing.Size(246, 27);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(13, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 24);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(276, 446);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExti
            // 
            btnExti.Location = new System.Drawing.Point(376, 446);
            btnExti.Name = "btnExti";
            btnExti.Size = new System.Drawing.Size(94, 29);
            btnExti.TabIndex = 7;
            btnExti.Text = "Thoát ";
            btnExti.UseVisualStyleBackColor = true;
            btnExti.Click += btnExti_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExti;
            ClientSize = new System.Drawing.Size(479, 493);
            Controls.Add(btnExti);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân ";
            Load += fAccountProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExti;
        private EventHandler fAccountProfile_Load;
    }
}