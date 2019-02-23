namespace MqttServerTest
{
    partial class FormClient
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
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.txtReceiveMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qosBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(15, 394);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(123, 35);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Text = "订阅";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_ClickAsync);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(13, 266);
            this.txtSubTopic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubTopic.Multiline = true;
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(444, 102);
            this.txtSubTopic.TabIndex = 1;
            this.txtSubTopic.TextChanged += new System.EventHandler(this.txtSubTopic_TextChanged);
            // 
            // BtnPublish
            // 
            this.BtnPublish.Location = new System.Drawing.Point(570, 394);
            this.BtnPublish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(75, 36);
            this.BtnPublish.TabIndex = 2;
            this.BtnPublish.Text = "发送";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Location = new System.Drawing.Point(467, 74);
            this.txtPubTopic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPubTopic.Multiline = true;
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(132, 42);
            this.txtPubTopic.TabIndex = 3;
            this.txtPubTopic.TextChanged += new System.EventHandler(this.txtPubTopic_TextChanged);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(467, 202);
            this.txtSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(309, 166);
            this.txtSendMessage.TabIndex = 4;
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.Location = new System.Drawing.Point(801, 84);
            this.txtReceiveMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiveMessage.Multiline = true;
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.Size = new System.Drawing.Size(284, 286);
            this.txtReceiveMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入消息";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "消息框";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 72);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(115, 32);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Text = "username001";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户名";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "密码";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(93, 129);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPsw.Multiline = true;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(115, 32);
            this.txtPsw.TabIndex = 11;
            this.txtPsw.Text = "psw001";
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(9, 204);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(121, 38);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "连接";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(283, 204);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 38);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "断开";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "发出的目标主题";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClientId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 248);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户设置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "连接地址";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(293, 20);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIp.Multiline = true;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(115, 32);
            this.txtIp.TabIndex = 18;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "端口";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(293, 72);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 32);
            this.txtPort.TabIndex = 16;
            this.txtPort.Text = "1883";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "连接ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(93, 22);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientId.Multiline = true;
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(115, 32);
            this.txtClientId.TabIndex = 14;
            this.txtClientId.Text = "client001";
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Qos等级（仅支持0-2）";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // qosBox
            // 
            this.qosBox.Location = new System.Drawing.Point(644, 74);
            this.qosBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qosBox.Multiline = true;
            this.qosBox.Name = "qosBox";
            this.qosBox.Size = new System.Drawing.Size(132, 42);
            this.qosBox.TabIndex = 20;
            this.qosBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 471);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qosBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReceiveMessage);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.txtPubTopic);
            this.Controls.Add(this.BtnPublish);
            this.Controls.Add(this.txtSubTopic);
            this.Controls.Add(this.btnSubscribe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Button BtnPublish;
        private System.Windows.Forms.TextBox txtPubTopic;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.TextBox txtReceiveMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox qosBox;
    }
}

