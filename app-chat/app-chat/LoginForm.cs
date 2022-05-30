using app_chat.Controler;
using server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chat
{
    public partial class LoginForm : Form
    {
        convert cvt = new convert();
        Messages ms = new Messages();

        IPEndPoint IP;
        Socket client;
        public LoginForm()
        {
            InitializeComponent();
            Connect();
        }
        
        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text.Trim();
            string password = txtPass.Text.Trim();

            Send("login");
            ChatForm chatFrm = new ChatForm();
            chatFrm.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            //new SignUp().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Connect();
        }

        #region

        bool Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32("9999"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
                MessageBox.Show("Connect thành công");
            }
            catch
            {
                MessageBox.Show("Không kết nối được server");
                return false;
            }

            //tạo cái luồng để lắng nghe
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            return true;
        }

        void Send(string action)
        {
            ms.action = action;

            //add data
            ms.user.UserName = txtAccount.Text;
            ms.user.Password = txtPass.Text;

            client.Send(cvt.Serialize(ms));
        }

        void Close()
        {
            client.Close();
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    client.Receive(data);

                    Messages _ms = new Messages();


                    _ms = (Messages)cvt.Deserialize(data);

                    switch (_ms.action)
                    {
                        case "login":
                            if (_ms.text == "success")
                            {
                                ms.user = _ms.user;
                            }
                            else if (_ms.text == "logged in")
                                MessageBox.Show("Bạn đã đăng nhập vào hệ thống rồi, vui lòng không đăng nhập lại !!!");
                            else
                                MessageBox.Show("Đăng nhập thất bại! Tài khoản " + _ms.user.UserName + " không tồn tại! ");

                            break;

                        //case "register":
                        //    if (_ms.text == "success")
                        //        MessageBox.Show("Đăng ký tài khoản thành công!");
                        //    else if (_ms.text == "exited")
                        //        MessageBox.Show("Tài khoản đã tồn tại !");
                        //    else
                        //        MessageBox.Show("Đăng ký tài khoản thất bại !");
                        //    break;

                        //case "change password":
                        //    if (_ms.text == "success")
                        //    {
                        //        grbUpload.Enabled = false;
                        //        grbChat.Enabled = false;
                        //        btnSend.Enabled = false;

                        //        MessageBox.Show("Đổi mật khẩu thành công!");
                        //        btnLogin.Text = "Đăng nhập";
                        //        btnJoin.Text = "Tham gia";
                        //    }
                        //    else if (_ms.text == "not existed")
                        //        MessageBox.Show("Tài khoản không tồn tại !");
                        //    else
                        //        MessageBox.Show("Đổi mật khẩu thất bại !");
                        //    break;

                        //case "logout":
                        //    if (_ms.text == "success")
                        //    {
                        //        grbUpload.Enabled = false;
                        //        grbChat.Enabled = false;
                        //        btnLogin.Text = "Đăng nhập";
                        //    }
                        //    else
                        //        MessageBox.Show("Đã xảy ra lỗi, kiểm tra lại code trên server");
                        //    break;

                        //case "join chat":
                        //    if (_ms.text == "success")
                        //    {
                        //        MessageBox.Show("Bạn đã tham gia chat all!");
                        //        btnSend.Enabled = true;

                        //        ms.user = new User();
                        //    }
                        //    else
                        //        MessageBox.Show("Tham gia chat all không thành công!");
                        //    break;

                        //case "out chat":
                        //    if (_ms.text == "success")
                        //    {
                        //        MessageBox.Show("Bạn đã rời khỏi nhóm chat!");
                        //        btnSend.Enabled = false;
                        //    }
                        //    else
                        //        MessageBox.Show("Lỗi, xem lại code ở server!");
                        //    break;

                        //case "chat":
                        //    string msg = _ms.Uname + ": " + _ms.text;
                        //    ShowMessage(msg, false);
                        //    break;

                        //case "upload":
                        //    if (_ms.text == "success")
                        //        MessageBox.Show("file " + _ms.fileName + " upload thành công !");
                        //    else
                        //        MessageBox.Show("Kích thước file quá lớn !!!");
                        //    break;

                        //case "download":
                        //    if (_ms.text == "success")
                        //    {

                        //        File.WriteAllBytes(_ms.fileName, _ms.data);
                        //        MessageBox.Show("file " + _ms.fileName + " download thành công !");
                        //    }
                        //    else
                        //        MessageBox.Show("file không có trên server !");
                        //    break;

                        //case "update info":
                        //    if (_ms.text == "success")
                        //    {
                        //        ms.user = _ms.user;
                        //        MessageBox.Show("Cập nhật thông tin thành công");
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Cập nhật thông tin thất bại");
                        //    }
                        //    break;

                        default:
                            break;

                    }
                }
            }
            catch
            {
                Close();
            }
        }
        #endregion
    }
}
