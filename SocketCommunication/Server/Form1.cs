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

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false; //检查非法线程调用，关闭
        }

        //服务端监听套接字
        Socket sokWatch = null;

        //监听线程
        Thread thrWatch = null;

        //设置一个字典了保存连接的客户端
        Dictionary<string, MsgConnection> dicConn = new Dictionary<string, MsgConnection>();

        private void ListenBtn_Click(object sender, EventArgs e)
        {
            sokWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress address = IPAddress.Parse(Iptb.Text);
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(Porttb.Text));

            sokWatch.Bind(endPoint);

            sokWatch.Listen(10);

            //开始监听：此方法会阻断当前线程，直到有其他程序连接过来，才执行完毕;    需重新开启线程
            //sokWatch.Accept();

            //开始监听，调用监听线程 执行 监听套接字的监听方法。
            thrWatch = new Thread(WatchConncting);
            thrWatch.IsBackground = true;
            thrWatch.Start();
            ShowMsg("服务器启动！");
        }

        //开始监听，线程调用
        bool isWatch = true;
        
        void WatchConncting()
        {
            try
            {
                //循环监听客户端的连接请求。
                while (isWatch)
                {
                    //2.4开始监听，返回了一个通信套接字
                    Socket sockMsg = sokWatch.Accept();
                    //2.5 创建通信管理类
                    MsgConnection conn = new MsgConnection(sockMsg, ShowMsg, RemoveClient);

                    //将当前连接成功的【与客户端通信的套接字】的标识保存起来，并显示到列表中
                    //将远程客户端的 ip 和 端口 字符串 存入列表
                    OnlineClient.Items.Add(sockMsg.RemoteEndPoint.ToString());
                    //将服务器端的通信套接字存入字典集合。
                    dicConn.Add(sockMsg.RemoteEndPoint.ToString(), conn);
                    ShowMsg("有客户端连接了！");
                }
            }
            catch (Exception ex)
            {
                ShowMsg("异常" + ex);
            }
        }

        public void RemoveClient(string clientIpPort)
        {
            //1.0 移除列表中的项
            OnlineClient.Items.Remove(clientIpPort);
            //2.0 关闭通信管理类
            dicConn[clientIpPort].Close();
            //3.0 从字典中移除对应的通信管理类的项
            dicConn.Remove(clientIpPort);
        }

        void ShowMsg(string strmsg)
        {
            this.ShowMsgtb.AppendText(strmsg + "\r\n");
        }

        private void SendMsgbtn_Click(object sender, EventArgs e)
        {
            string strClient = OnlineClient.Text;

            if(dicConn.ContainsKey(strClient))
            {
                string strMsg = InputMsg.Text.Trim();
                ShowMsg("发送消息" + strMsg);

                try
                {
                    dicConn[strClient].Send(strMsg);
                }
                catch(Exception ex)
                {
                    ShowMsg("发送消息异常" + ex.Message);
                }
            }
        }

        private void SendFilebtn_Click(object sender, EventArgs e)
        {
            string strClient = OnlineClient.Text;

            if(dicConn.ContainsKey(strClient))
            {
                try
                {
                    dicConn[strClient].SendFile(Filepathtb.Text.Trim());
                }
                catch(Exception ex)
                {
                    ShowMsg("传送文件异常" + ex.Message);
                }
            }
        }

        private void ChooseFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //将选中的要发送的文件路径，显示到文本框中。
                Filepathtb.Text = ofd.FileName;
            }
        }

        
    }
}
