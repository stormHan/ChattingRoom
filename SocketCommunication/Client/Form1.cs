using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;


namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false; //检查非法线程调用，关闭
        }

        Socket sokMsg = null;
        Thread thrMsg = null;

        #region 

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建连接套接字，使用ip4协议，流式传输，tcp链接
                sokMsg = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 获取服务端的地址，获取网络节点对象
                IPAddress address = IPAddress.Parse(Iptb.Text);
                IPEndPoint endPoint = new IPEndPoint(address, int.Parse(Porttb.Text));
 
                //链接
                sokMsg.Connect(endPoint);
                ShowMsg("成功连接服务器!");

                thrMsg = new Thread(ReceiveMsg);
                thrMsg.IsBackground = true;

                //win7, win8需要设置客户端通信同步设置，才能在接收文件时打开文件选择框
                thrMsg.SetApartmentState(ApartmentState.STA);
                thrMsg.Start();
            }
            catch(Exception ex)
            {
                ShowMsg("连接服务器失败!" + ex.Message);
            }
        }

        #endregion

        bool isReceive = true;
        #region 2.0 接收服务端消息
        void ReceiveMsg()
        {
            //准备一个消息缓冲区域
            byte[] arrMsg = new byte[1024 * 1024 * 1];
            try
            {
                while (isReceive)
                {
                    //接收 服务器发来的数据，因为包含了一个标示符，所以内容的真实长度应该-1
                    int realLength = sokMsg.Receive(arrMsg) - 1;
                    switch (arrMsg[0])
                    {
                        //文本
                        case 0:
                            GetMsg(arrMsg, realLength);
                            break;
                        //文件
                        case 1:
                            GetFile(arrMsg, realLength);
                            break;
                        default:
                            //ShakeWindow();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                sokMsg.Close();
                sokMsg = null;
                ShowMsg("服务器断开连接！");
            }
        }
        #endregion

        public void GetMsg(byte[] arrContent, int realLength)
        {
            //获取接收的内容，去掉第一个标示符。
            string strMsg = System.Text.Encoding.UTF8.GetString(arrContent, 1, realLength);
            ShowMsg("服务器说：" + strMsg);
        }

        public void GetFile(byte[] arrContent, int realLength)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string savaPath = sfd.FileName;
                //使用文件流，保存文件
                using (System.IO.FileStream fs = new System.IO.FileStream(savaPath, System.IO.FileMode.OpenOrCreate))
                {
                    //将收到的文件数据数组，写入硬盘。
                    fs.Write(arrContent, 1, realLength);
                }
                ShowMsg("保存文件到 【" + savaPath + "】成功！");
            }
        } 

        void ShowMsg(string strmsg)
        {
            this.ShowMsgtb.AppendText(strmsg + "\r\n");
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            string sendstr = InputMsg.Text.Trim();

            if(sendstr != "")
            {
                //将string进行转码成byte以便交给send函数处理
                byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(sendstr);
                try
                {
                    sokMsg.Send(arrMsg);
                }
                catch (Exception ex)
                {
                    ShowMsg("发送消息失败!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("发送消息不能为空!");
            }
        } 
    }
}
