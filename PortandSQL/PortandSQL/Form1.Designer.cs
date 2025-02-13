namespace PortandSQL
{
    partial class Form1
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
            this.comBoxTCPandPort = new System.Windows.Forms.ComboBox();
            this.panelTCP = new System.Windows.Forms.Panel();
            this.txttcpset = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnset = new System.Windows.Forms.Button();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnDis_tcp = new System.Windows.Forms.Button();
            this.txtTCPport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTCPIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPort = new System.Windows.Forms.Panel();
            this.btnReadPort = new System.Windows.Forms.Button();
            this.txtSetPort = new System.Windows.Forms.TextBox();
            this.btnsetPort = new System.Windows.Forms.Button();
            this.btnConnectport = new System.Windows.Forms.Button();
            this.btnDisport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxStopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxPraity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxDatabits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxCOMport = new System.Windows.Forms.ComboBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelcannect = new System.Windows.Forms.Label();
            this.panelTCP.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBoxTCPandPort
            // 
            this.comBoxTCPandPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTCPandPort.FormattingEnabled = true;
            this.comBoxTCPandPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comBoxTCPandPort.Items.AddRange(new object[] {
            "Port",
            "Modbus-TCP/IP"});
            this.comBoxTCPandPort.Location = new System.Drawing.Point(42, 20);
            this.comBoxTCPandPort.Name = "comBoxTCPandPort";
            this.comBoxTCPandPort.Size = new System.Drawing.Size(153, 23);
            this.comBoxTCPandPort.TabIndex = 0;
            this.comBoxTCPandPort.DropDownClosed += new System.EventHandler(this.comBoxTCPandPort_DropDownClosed);
            // 
            // panelTCP
            // 
            this.panelTCP.Controls.Add(this.txttcpset);
            this.panelTCP.Controls.Add(this.btnRead);
            this.panelTCP.Controls.Add(this.btnset);
            this.panelTCP.Controls.Add(this.txtlength);
            this.panelTCP.Controls.Add(this.label1);
            this.panelTCP.Controls.Add(this.btnconnect);
            this.panelTCP.Controls.Add(this.btnDis_tcp);
            this.panelTCP.Controls.Add(this.txtTCPport);
            this.panelTCP.Controls.Add(this.label8);
            this.panelTCP.Controls.Add(this.txtTCPIP);
            this.panelTCP.Controls.Add(this.label7);
            this.panelTCP.Location = new System.Drawing.Point(17, 61);
            this.panelTCP.Name = "panelTCP";
            this.panelTCP.Size = new System.Drawing.Size(379, 373);
            this.panelTCP.TabIndex = 2;
            // 
            // txttcpset
            // 
            this.txttcpset.Location = new System.Drawing.Point(125, 238);
            this.txttcpset.Name = "txttcpset";
            this.txttcpset.Size = new System.Drawing.Size(100, 25);
            this.txttcpset.TabIndex = 10;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(309, 213);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(44, 124);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(39, 233);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(67, 31);
            this.btnset.TabIndex = 9;
            this.btnset.Text = "写入";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(125, 124);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 25);
            this.txtlength.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "读取长度";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(309, 69);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(44, 119);
            this.btnconnect.TabIndex = 5;
            this.btnconnect.Text = "连接";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnDis_tcp
            // 
            this.btnDis_tcp.Location = new System.Drawing.Point(38, 280);
            this.btnDis_tcp.Name = "btnDis_tcp";
            this.btnDis_tcp.Size = new System.Drawing.Size(100, 35);
            this.btnDis_tcp.TabIndex = 4;
            this.btnDis_tcp.Text = "关闭";
            this.btnDis_tcp.UseVisualStyleBackColor = true;
            this.btnDis_tcp.Click += new System.EventHandler(this.btnDis_tcp_Click);
            // 
            // txtTCPport
            // 
            this.txtTCPport.Location = new System.Drawing.Point(125, 79);
            this.txtTCPport.Name = "txtTCPport";
            this.txtTCPport.Size = new System.Drawing.Size(100, 25);
            this.txtTCPport.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Port";
            // 
            // txtTCPIP
            // 
            this.txtTCPIP.Location = new System.Drawing.Point(81, 22);
            this.txtTCPIP.Name = "txtTCPIP";
            this.txtTCPIP.Size = new System.Drawing.Size(185, 25);
            this.txtTCPIP.TabIndex = 4;
            this.txtTCPIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "IP";
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.btnReadPort);
            this.panelPort.Controls.Add(this.txtSetPort);
            this.panelPort.Controls.Add(this.btnsetPort);
            this.panelPort.Controls.Add(this.btnConnectport);
            this.panelPort.Controls.Add(this.btnDisport);
            this.panelPort.Controls.Add(this.label6);
            this.panelPort.Controls.Add(this.comBoxStopbits);
            this.panelPort.Controls.Add(this.label5);
            this.panelPort.Controls.Add(this.comBoxPraity);
            this.panelPort.Controls.Add(this.label4);
            this.panelPort.Controls.Add(this.comBoxBaud);
            this.panelPort.Controls.Add(this.label3);
            this.panelPort.Controls.Add(this.comBoxDatabits);
            this.panelPort.Controls.Add(this.label2);
            this.panelPort.Controls.Add(this.comBoxCOMport);
            this.panelPort.Location = new System.Drawing.Point(20, 61);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(376, 370);
            this.panelPort.TabIndex = 0;
            // 
            // btnReadPort
            // 
            this.btnReadPort.Location = new System.Drawing.Point(306, 210);
            this.btnReadPort.Name = "btnReadPort";
            this.btnReadPort.Size = new System.Drawing.Size(44, 124);
            this.btnReadPort.TabIndex = 12;
            this.btnReadPort.Text = "读取";
            this.btnReadPort.UseVisualStyleBackColor = true;
            // 
            // txtSetPort
            // 
            this.txtSetPort.Location = new System.Drawing.Point(102, 271);
            this.txtSetPort.Name = "txtSetPort";
            this.txtSetPort.Size = new System.Drawing.Size(100, 25);
            this.txtSetPort.TabIndex = 12;
            // 
            // btnsetPort
            // 
            this.btnsetPort.Location = new System.Drawing.Point(12, 265);
            this.btnsetPort.Name = "btnsetPort";
            this.btnsetPort.Size = new System.Drawing.Size(68, 33);
            this.btnsetPort.TabIndex = 11;
            this.btnsetPort.Text = "写入";
            this.btnsetPort.UseVisualStyleBackColor = true;
            // 
            // btnConnectport
            // 
            this.btnConnectport.Location = new System.Drawing.Point(306, 66);
            this.btnConnectport.Name = "btnConnectport";
            this.btnConnectport.Size = new System.Drawing.Size(44, 119);
            this.btnConnectport.TabIndex = 11;
            this.btnConnectport.Text = "连接";
            this.btnConnectport.UseVisualStyleBackColor = true;
            // 
            // btnDisport
            // 
            this.btnDisport.Location = new System.Drawing.Point(95, 318);
            this.btnDisport.Name = "btnDisport";
            this.btnDisport.Size = new System.Drawing.Size(107, 37);
            this.btnDisport.TabIndex = 10;
            this.btnDisport.Text = "关闭连接";
            this.btnDisport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "停止位";
            // 
            // comBoxStopbits
            // 
            this.comBoxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStopbits.FormattingEnabled = true;
            this.comBoxStopbits.Items.AddRange(new object[] {
            "1 Stop bit",
            "2 Stop bits"});
            this.comBoxStopbits.Location = new System.Drawing.Point(90, 194);
            this.comBoxStopbits.Name = "comBoxStopbits";
            this.comBoxStopbits.Size = new System.Drawing.Size(153, 23);
            this.comBoxStopbits.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "校验位";
            // 
            // comBoxPraity
            // 
            this.comBoxPraity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPraity.FormattingEnabled = true;
            this.comBoxPraity.Items.AddRange(new object[] {
            "None Parity",
            "Add Parity",
            "Even Parity"});
            this.comBoxPraity.Location = new System.Drawing.Point(90, 158);
            this.comBoxPraity.Name = "comBoxPraity";
            this.comBoxPraity.Size = new System.Drawing.Size(153, 23);
            this.comBoxPraity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "波特率";
            // 
            // comBoxBaud
            // 
            this.comBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBaud.FormattingEnabled = true;
            this.comBoxBaud.Location = new System.Drawing.Point(90, 77);
            this.comBoxBaud.Name = "comBoxBaud";
            this.comBoxBaud.Size = new System.Drawing.Size(153, 23);
            this.comBoxBaud.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "数据位";
            // 
            // comBoxDatabits
            // 
            this.comBoxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDatabits.FormattingEnabled = true;
            this.comBoxDatabits.Items.AddRange(new object[] {
            "7 Data Bits",
            "8 Data Bits"});
            this.comBoxDatabits.Location = new System.Drawing.Point(90, 118);
            this.comBoxDatabits.Name = "comBoxDatabits";
            this.comBoxDatabits.Size = new System.Drawing.Size(153, 23);
            this.comBoxDatabits.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // comBoxCOMport
            // 
            this.comBoxCOMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCOMport.FormattingEnabled = true;
            this.comBoxCOMport.Location = new System.Drawing.Point(90, 35);
            this.comBoxCOMport.Name = "comBoxCOMport";
            this.comBoxCOMport.Size = new System.Drawing.Size(153, 23);
            this.comBoxCOMport.TabIndex = 0;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 15;
            this.listBoxData.Location = new System.Drawing.Point(411, 61);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.ScrollAlwaysVisible = true;
            this.listBoxData.Size = new System.Drawing.Size(367, 379);
            this.listBoxData.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBoxTCPandPort);
            this.groupBox1.Location = new System.Drawing.Point(78, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通信";
            // 
            // labelcannect
            // 
            this.labelcannect.AutoSize = true;
            this.labelcannect.Location = new System.Drawing.Point(373, 24);
            this.labelcannect.Name = "labelcannect";
            this.labelcannect.Size = new System.Drawing.Size(0, 15);
            this.labelcannect.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelcannect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelPort);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.panelTCP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTCP.ResumeLayout(false);
            this.panelTCP.PerformLayout();
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxTCPandPort;
        private System.Windows.Forms.Panel panelTCP;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Panel panelPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comBoxStopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxPraity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxDatabits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxCOMport;
        private System.Windows.Forms.TextBox txtTCPport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTCPIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label labelcannect;
        private System.Windows.Forms.Button btnDis_tcp;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttcpset;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnDisport;
        private System.Windows.Forms.Button btnReadPort;
        private System.Windows.Forms.TextBox txtSetPort;
        private System.Windows.Forms.Button btnsetPort;
        private System.Windows.Forms.Button btnConnectport;
    }
}

