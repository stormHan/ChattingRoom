using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Usernametb.Text == "aaa" && Passwordtb.Text == "123")
            {
                Server sv = new Server();
                sv.Show();

            }
            else
            {
                MessageBox.Show("用户名/密码错误!");
            }
        }
    }
}
