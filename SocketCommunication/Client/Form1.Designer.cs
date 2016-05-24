namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.ShowMsgtb = new System.Windows.Forms.TextBox();
            this.InputMsg = new System.Windows.Forms.TextBox();
            this.Iplabel = new System.Windows.Forms.Label();
            this.Iptb = new System.Windows.Forms.TextBox();
            this.Portlbl = new System.Windows.Forms.Label();
            this.Porttb = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.SentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowMsgtb
            // 
            this.ShowMsgtb.Location = new System.Drawing.Point(12, 28);
            this.ShowMsgtb.Multiline = true;
            this.ShowMsgtb.Name = "ShowMsgtb";
            this.ShowMsgtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowMsgtb.Size = new System.Drawing.Size(485, 477);
            this.ShowMsgtb.TabIndex = 0;
            // 
            // InputMsg
            // 
            this.InputMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputMsg.BackColor = System.Drawing.SystemColors.Window;
            this.InputMsg.Location = new System.Drawing.Point(12, 571);
            this.InputMsg.Multiline = true;
            this.InputMsg.Name = "InputMsg";
            this.InputMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputMsg.Size = new System.Drawing.Size(575, 111);
            this.InputMsg.TabIndex = 1;
            // 
            // Iplabel
            // 
            this.Iplabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iplabel.AutoSize = true;
            this.Iplabel.BackColor = System.Drawing.Color.Transparent;
            this.Iplabel.Location = new System.Drawing.Point(504, 28);
            this.Iplabel.Name = "Iplabel";
            this.Iplabel.Size = new System.Drawing.Size(23, 12);
            this.Iplabel.TabIndex = 2;
            this.Iplabel.Text = "IP:";
            // 
            // Iptb
            // 
            this.Iptb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iptb.Location = new System.Drawing.Point(506, 43);
            this.Iptb.Name = "Iptb";
            this.Iptb.Size = new System.Drawing.Size(100, 21);
            this.Iptb.TabIndex = 3;
            this.Iptb.Text = "127.0.0.1";
            // 
            // Portlbl
            // 
            this.Portlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Portlbl.AutoSize = true;
            this.Portlbl.BackColor = System.Drawing.Color.Transparent;
            this.Portlbl.Location = new System.Drawing.Point(506, 71);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(29, 12);
            this.Portlbl.TabIndex = 4;
            this.Portlbl.Text = "Port";
            // 
            // Porttb
            // 
            this.Porttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Porttb.Location = new System.Drawing.Point(508, 87);
            this.Porttb.Name = "Porttb";
            this.Porttb.Size = new System.Drawing.Size(100, 21);
            this.Porttb.TabIndex = 5;
            this.Porttb.Text = "10000";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ConnectBtn.Location = new System.Drawing.Point(524, 128);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(82, 48);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "连接服务器";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // SentBtn
            // 
            this.SentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SentBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.SentBtn.Location = new System.Drawing.Point(512, 542);
            this.SentBtn.Name = "SentBtn";
            this.SentBtn.Size = new System.Drawing.Size(75, 23);
            this.SentBtn.TabIndex = 7;
            this.SentBtn.Text = "发送消息";
            this.SentBtn.UseVisualStyleBackColor = false;
            this.SentBtn.Click += new System.EventHandler(this.SentBtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 694);
            this.Controls.Add(this.SentBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Porttb);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.Iptb);
            this.Controls.Add(this.Iplabel);
            this.Controls.Add(this.InputMsg);
            this.Controls.Add(this.ShowMsgtb);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowMsgtb;
        private System.Windows.Forms.TextBox InputMsg;
        private System.Windows.Forms.Label Iplabel;
        private System.Windows.Forms.TextBox Iptb;
        private System.Windows.Forms.Label Portlbl;
        private System.Windows.Forms.TextBox Porttb;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button SentBtn;
    }
}

