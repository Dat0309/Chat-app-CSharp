using app_chat.Controler;
using server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace app_chat
{
    
    public partial class SignUp : Form
    {
        
        convert cvt = new convert();
        Messages ms = null;

        Socket client;

        public SignUp(Socket _client, Messages _ms)
        {
            InitializeComponent();
            client = _client;
            ms = _ms;
        }

        private bool valid()
        {
            if (txtPass.Text == "" || txtConfirmPass.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống !!");

                return false;
            }

            if (txtPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác");

                return false;
            }

            return true;

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            //new LoginForm().Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                ms.user.UserName = txtAcc.Text;
                ms.user.Password = txtPass.Text;

                client.Send(cvt.Serialize(ms));

                this.Close();
            }

        }
    }
}
