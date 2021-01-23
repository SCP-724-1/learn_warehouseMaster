
namespace learn_仓库管理系统
{
    partial class Login
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
            this.userNameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.AutoSize = true;
            this.userNameText.Font = new System.Drawing.Font("宋体", 19F);
            this.userNameText.Location = new System.Drawing.Point(66, 93);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(116, 26);
            this.userNameText.TabIndex = 0;
            this.userNameText.Text = "用户名：";
            this.userNameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("宋体", 19F);
            this.passwordText.Location = new System.Drawing.Point(66, 145);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(90, 26);
            this.passwordText.TabIndex = 1;
            this.passwordText.Text = "密码：";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(164, 98);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(159, 21);
            this.userName.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(164, 150);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(159, 21);
            this.password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("宋体", 19F);
            this.welcomeText.Location = new System.Drawing.Point(36, 36);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(376, 26);
            this.welcomeText.TabIndex = 5;
            this.welcomeText.Text = "欢迎进入仓库管理系统，请登录";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 300);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcomeText;
    }
}

