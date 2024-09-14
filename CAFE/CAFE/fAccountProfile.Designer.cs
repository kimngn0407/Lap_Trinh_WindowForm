namespace CAFE
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
            panel2 = new Panel();
            textBox1 = new TextBox();
            lbLogin = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbLogin);
            panel2.Location = new Point(3, 3);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 71);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 20);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(13, 23);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(159, 24);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 82);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 71);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(204, 20);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(334, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 161);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(553, 71);
            panel3.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(204, 20);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(334, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 240);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(553, 71);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(204, 20);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(334, 27);
            txbNewPassword.TabIndex = 1;
            txbNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 23);
            label3.Name = "label3";
            label3.Size = new Size(146, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 319);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(553, 71);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(204, 20);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(334, 27);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 23);
            label4.Name = "label4";
            label4.Size = new Size(186, 24);
            label4.TabIndex = 0;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(346, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(446, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(559, 455);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
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

        private Panel panel2;
        private TextBox textBox1;
        private Label lbLogin;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label1;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label2;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label3;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label4;
        private Button btnUpdate;
        private Button btnExit;
    }
}