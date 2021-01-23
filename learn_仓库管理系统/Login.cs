using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace learn_仓库管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "登录";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            userNameText.Text = "用户名";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean power = false;
            XmlDocument login = new XmlDocument();
            login.Load(@"data\user\user.xml");
            XmlElement users = login.DocumentElement;
            XmlNodeList user = users.SelectNodes("users/user");
            foreach (XmlNode node in user)
            {
                if(userName.Text== node.Attributes["name"].Value && password.Text == node.Attributes["password"].Value)
                {
                    power = true;
                    break;
                }
                if (power == true)
                {
                    //登录成功，进入主窗口
                }
                else
                {
                    welcomeText.Text = "用户名或密码错误";
                }
            }
        }
    }
}
