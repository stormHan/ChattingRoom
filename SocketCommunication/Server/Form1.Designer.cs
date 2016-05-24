namespace Server
{
    partial class Server
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IPlbl = new System.Windows.Forms.Label();
            this.Iptb = new System.Windows.Forms.TextBox();
            this.Portlbl = new System.Windows.Forms.Label();
            this.Porttb = new System.Windows.Forms.TextBox();
            this.ShowMsgtb = new System.Windows.Forms.TextBox();
            this.InputMsg = new System.Windows.Forms.TextBox();
            this.Filepathtb = new System.Windows.Forms.TextBox();
            this.ChooseFilebtn = new System.Windows.Forms.Button();
            this.SendFilebtn = new System.Windows.Forms.Button();
            this.SendMsgbtn = new System.Windows.Forms.Button();
            this.OnlineClient = new System.Windows.Forms.ListBox();
            this.ListenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(28, 9);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(23, 12);
            this.IPlbl.TabIndex = 0;
            this.IPlbl.Text = "IP:";
            // 
            // Iptb
            // 
            this.Iptb.Location = new System.Drawing.Point(57, 9);
            this.Iptb.Name = "Iptb";
            this.Iptb.Size = new System.Drawing.Size(100, 21);
            this.Iptb.TabIndex = 1;
            this.Iptb.Text = "127.0.0.1";
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(179, 9);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(35, 12);
            this.Portlbl.TabIndex = 2;
            this.Portlbl.Text = "Port:";
            // 
            // Porttb
            // 
            this.Porttb.Location = new System.Drawing.Point(220, 9);
            this.Porttb.Name = "Porttb";
            this.Porttb.Size = new System.Drawing.Size(100, 21);
            this.Porttb.TabIndex = 3;
            this.Porttb.Text = "10000";
            // 
            // ShowMsgtb
            // 
            this.ShowMsgtb.Location = new System.Drawing.Point(30, 54);
            this.ShowMsgtb.Multiline = true;
            this.ShowMsgtb.Name = "ShowMsgtb";
            this.ShowMsgtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowMsgtb.Size = new System.Drawing.Size(612, 276);
            this.ShowMsgtb.TabIndex = 4;
            // 
            // InputMsg
            // 
            this.InputMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputMsg.BackColor = System.Drawing.SystemColors.Window;
            this.InputMsg.Location = new System.Drawing.Point(30, 404);
            this.InputMsg.Multiline = true;
            this.InputMsg.Name = "InputMsg";
            this.InputMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputMsg.Size = new System.Drawing.Size(612, 111);
            this.InputMsg.TabIndex = 5;
            // 
            // Filepathtb
            // 
            this.Filepathtb.Location = new System.Drawing.Point(30, 336);
            this.Filepathtb.Name = "Filepathtb";
            this.Filepathtb.Size = new System.Drawing.Size(269, 21);
            this.Filepathtb.TabIndex = 6;
            // 
            // ChooseFilebtn
            // 
            this.ChooseFilebtn.Location = new System.Drawing.Point(30, 375);
            this.ChooseFilebtn.Name = "ChooseFilebtn";
            this.ChooseFilebtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseFilebtn.TabIndex = 7;
            this.ChooseFilebtn.Text = "选择文件";
            this.ChooseFilebtn.UseVisualStyleBackColor = true;
            this.ChooseFilebtn.Click += new System.EventHandler(this.ChooseFilebtn_Click);
            // 
            // SendFilebtn
            // 
            this.SendFilebtn.Location = new System.Drawing.Point(224, 375);
            this.SendFilebtn.Name = "SendFilebtn";
            this.SendFilebtn.Size = new System.Drawing.Size(75, 23);
            this.SendFilebtn.TabIndex = 8;
            this.SendFilebtn.Text = "发送文件";
            this.SendFilebtn.UseVisualStyleBackColor = true;
            this.SendFilebtn.Click += new System.EventHandler(this.SendFilebtn_Click);
            // 
            // SendMsgbtn
            // 
            this.SendMsgbtn.Location = new System.Drawing.Point(567, 375);
            this.SendMsgbtn.Name = "SendMsgbtn";
            this.SendMsgbtn.Size = new System.Drawing.Size(75, 23);
            this.SendMsgbtn.TabIndex = 9;
            this.SendMsgbtn.Text = "发送消息";
            this.SendMsgbtn.UseVisualStyleBackColor = true;
            this.SendMsgbtn.Click += new System.EventHandler(this.SendMsgbtn_Click);
            // 
            // OnlineClient
            // 
            this.OnlineClient.FormattingEnabled = true;
            this.OnlineClient.ItemHeight = 12;
            this.OnlineClient.Location = new System.Drawing.Point(660, 54);
            this.OnlineClient.Name = "OnlineClient";
            this.OnlineClient.Size = new System.Drawing.Size(325, 460);
            this.OnlineClient.TabIndex = 10;
            // 
            // ListenBtn
            // 
            this.ListenBtn.Location = new System.Drawing.Point(406, 1);
            this.ListenBtn.Name = "ListenBtn";
            this.ListenBtn.Size = new System.Drawing.Size(64, 35);
            this.ListenBtn.TabIndex = 11;
            this.ListenBtn.Text = "监听";
            this.ListenBtn.UseVisualStyleBackColor = true;
            this.ListenBtn.Click += new System.EventHandler(this.ListenBtn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 527);
            this.Controls.Add(this.ListenBtn);
            this.Controls.Add(this.OnlineClient);
            this.Controls.Add(this.SendMsgbtn);
            this.Controls.Add(this.SendFilebtn);
            this.Controls.Add(this.ChooseFilebtn);
            this.Controls.Add(this.Filepathtb);
            this.Controls.Add(this.InputMsg);
            this.Controls.Add(this.ShowMsgtb);
            this.Controls.Add(this.Porttb);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.Iptb);
            this.Controls.Add(this.IPlbl);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPlbl;
        private System.Windows.Forms.TextBox Iptb;
        private System.Windows.Forms.Label Portlbl;
        private System.Windows.Forms.TextBox Porttb;
        private System.Windows.Forms.TextBox ShowMsgtb;
        private System.Windows.Forms.TextBox InputMsg;
        private System.Windows.Forms.TextBox Filepathtb;
        private System.Windows.Forms.Button ChooseFilebtn;
        private System.Windows.Forms.Button SendFilebtn;
        private System.Windows.Forms.Button SendMsgbtn;
        private System.Windows.Forms.ListBox OnlineClient;
        private System.Windows.Forms.Button ListenBtn;
    }
}

