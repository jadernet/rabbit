﻿namespace lazebird.rabbit.rabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_interval = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.text_interval = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabs = new System.Windows.Forms.TabControl();
            this.Ping = new System.Windows.Forms.TabPage();
            this.label_addr = new System.Windows.Forms.Label();
            this.text_count = new System.Windows.Forms.TextBox();
            this.btn_ping_log = new System.Windows.Forms.Button();
            this.text_logpath = new System.Windows.Forms.TextBox();
            this.btn_ping = new System.Windows.Forms.Button();
            this.ping_output = new System.Windows.Forms.ListBox();
            this.HTTPD = new System.Windows.Forms.TabPage();
            this.label_http_port = new System.Windows.Forms.Label();
            this.text_http_port = new System.Windows.Forms.TextBox();
            this.btn_http_dir = new System.Windows.Forms.Button();
            this.text_http_dir = new System.Windows.Forms.TextBox();
            this.btn_httpd = new System.Windows.Forms.Button();
            this.httpd_output = new System.Windows.Forms.ListBox();
            this.TFTPD = new System.Windows.Forms.TabPage();
            this.tftp_dirtext1 = new System.Windows.Forms.TextBox();
            this.tftp_dirbtn1 = new System.Windows.Forms.Button();
            this.tftp_dirtext2 = new System.Windows.Forms.TextBox();
            this.tftp_dirbtn2 = new System.Windows.Forms.Button();
            this.tftp_dirtext3 = new System.Windows.Forms.TextBox();
            this.tftp_dirbtn3 = new System.Windows.Forms.Button();
            this.tftp_dirtext4 = new System.Windows.Forms.TextBox();
            this.tftp_dirbtn4 = new System.Windows.Forms.Button();
            this.tftp_dirtext5 = new System.Windows.Forms.TextBox();
            this.tftp_dirbtn5 = new System.Windows.Forms.Button();
            this.FTPD = new System.Windows.Forms.TabPage();
            this.ftp_dirtext1 = new System.Windows.Forms.TextBox();
            this.ftp_dirbtn1 = new System.Windows.Forms.Button();
            this.ftp_dirtext2 = new System.Windows.Forms.TextBox();
            this.ftp_dirbtn2 = new System.Windows.Forms.Button();
            this.ftp_dirtext3 = new System.Windows.Forms.TextBox();
            this.ftp_dirbtn3 = new System.Windows.Forms.Button();
            this.ftp_dirtext4 = new System.Windows.Forms.TextBox();
            this.ftp_dirbtn4 = new System.Windows.Forms.Button();
            this.ftp_dirtext5 = new System.Windows.Forms.TextBox();
            this.ftp_dirbtn5 = new System.Windows.Forms.Button();
            this.btn_ftp = new System.Windows.Forms.Button();
            this.DHCPD = new System.Windows.Forms.TabPage();
            this.dhcp_startlabel = new System.Windows.Forms.Label();
            this.dhcp_starttext = new System.Windows.Forms.TextBox();
            this.dhcp_endlabel = new System.Windows.Forms.Label();
            this.dhcp_endtext = new System.Windows.Forms.TextBox();
            this.dhcp_gatewaylabel = new System.Windows.Forms.Label();
            this.dhcp_gatewaytext = new System.Windows.Forms.TextBox();
            this.dhcp_logbtn = new System.Windows.Forms.Button();
            this.dhcp_logtext = new System.Windows.Forms.TextBox();
            this.dhcp_btn = new System.Windows.Forms.Button();
            this.dhcp_logmsg = new System.Windows.Forms.ListBox();
            this.Setting = new System.Windows.Forms.TabPage();
            this.lang = new System.Windows.Forms.Label();
            this.lang_opt = new System.Windows.Forms.ComboBox();
            this.tftpd_output = new System.Windows.Forms.ListBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.Ping.SuspendLayout();
            this.HTTPD.SuspendLayout();
            this.TFTPD.SuspendLayout();
            this.FTPD.SuspendLayout();
            this.DHCPD.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.BackColor = System.Drawing.Color.Transparent;
            this.label_interval.Location = new System.Drawing.Point(5, 60);
            this.label_interval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(66, 20);
            this.label_interval.TabIndex = 0;
            this.label_interval.Text = "间隔(ms)";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.BackColor = System.Drawing.Color.Transparent;
            this.label_count.Location = new System.Drawing.Point(5, 101);
            this.label_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(37, 20);
            this.label_count.TabIndex = 1;
            this.label_count.Text = "次数";
            // 
            // text_addr
            // 
            this.text_addr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_addr.Location = new System.Drawing.Point(72, 14);
            this.text_addr.Margin = new System.Windows.Forms.Padding(2);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(679, 25);
            this.text_addr.TabIndex = 1;
            // 
            // text_interval
            // 
            this.text_interval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_interval.Location = new System.Drawing.Point(72, 55);
            this.text_interval.Margin = new System.Windows.Forms.Padding(2);
            this.text_interval.Name = "text_interval";
            this.text_interval.Size = new System.Drawing.Size(679, 25);
            this.text_interval.TabIndex = 2;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabs);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(767, 477);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(767, 477);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Ping);
            this.tabs.Controls.Add(this.HTTPD);
            this.tabs.Controls.Add(this.TFTPD);
            this.tabs.Controls.Add(this.FTPD);
            this.tabs.Controls.Add(this.DHCPD);
            this.tabs.Controls.Add(this.Setting);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(767, 477);
            this.tabs.TabIndex = 13;
            // 
            // Ping
            // 
            this.Ping.Controls.Add(this.label_addr);
            this.Ping.Controls.Add(this.text_addr);
            this.Ping.Controls.Add(this.label_interval);
            this.Ping.Controls.Add(this.text_interval);
            this.Ping.Controls.Add(this.label_count);
            this.Ping.Controls.Add(this.text_count);
            this.Ping.Controls.Add(this.btn_ping_log);
            this.Ping.Controls.Add(this.text_logpath);
            this.Ping.Controls.Add(this.btn_ping);
            this.Ping.Controls.Add(this.ping_output);
            this.Ping.Location = new System.Drawing.Point(4, 29);
            this.Ping.Name = "Ping";
            this.Ping.Padding = new System.Windows.Forms.Padding(3);
            this.Ping.Size = new System.Drawing.Size(759, 444);
            this.Ping.TabIndex = 0;
            this.Ping.Text = "Ping";
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.BackColor = System.Drawing.Color.Transparent;
            this.label_addr.Location = new System.Drawing.Point(5, 19);
            this.label_addr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(37, 20);
            this.label_addr.TabIndex = 12;
            this.label_addr.Text = "地址";
            // 
            // text_count
            // 
            this.text_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_count.Location = new System.Drawing.Point(72, 96);
            this.text_count.Margin = new System.Windows.Forms.Padding(2);
            this.text_count.Name = "text_count";
            this.text_count.Size = new System.Drawing.Size(679, 25);
            this.text_count.TabIndex = 3;
            // 
            // btn_ping_log
            // 
            this.btn_ping_log.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ping_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ping_log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ping_log.FlatAppearance.BorderSize = 0;
            this.btn_ping_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ping_log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ping_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ping_log.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ping_log.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ping_log.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ping_log.Location = new System.Drawing.Point(9, 133);
            this.btn_ping_log.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ping_log.Name = "btn_ping_log";
            this.btn_ping_log.Size = new System.Drawing.Size(52, 32);
            this.btn_ping_log.TabIndex = 4;
            this.btn_ping_log.Text = "日志";
            this.btn_ping_log.UseVisualStyleBackColor = false;
            // 
            // text_logpath
            // 
            this.text_logpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_logpath.Location = new System.Drawing.Point(72, 140);
            this.text_logpath.Margin = new System.Windows.Forms.Padding(2);
            this.text_logpath.Name = "text_logpath";
            this.text_logpath.Size = new System.Drawing.Size(679, 25);
            this.text_logpath.TabIndex = 5;
            // 
            // btn_ping
            // 
            this.btn_ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ping.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ping.FlatAppearance.BorderSize = 0;
            this.btn_ping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ping.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ping.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ping.Location = new System.Drawing.Point(678, 190);
            this.btn_ping.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(73, 37);
            this.btn_ping.TabIndex = 6;
            this.btn_ping.Text = "开始";
            this.btn_ping.UseVisualStyleBackColor = false;
            // 
            // ping_output
            // 
            this.ping_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ping_output.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping_output.FormattingEnabled = true;
            this.ping_output.ItemHeight = 19;
            this.ping_output.Location = new System.Drawing.Point(9, 253);
            this.ping_output.Margin = new System.Windows.Forms.Padding(2);
            this.ping_output.Name = "ping_output";
            this.ping_output.Size = new System.Drawing.Size(742, 175);
            this.ping_output.TabIndex = 7;
            // 
            // HTTPD
            // 
            this.HTTPD.Controls.Add(this.label_http_port);
            this.HTTPD.Controls.Add(this.text_http_port);
            this.HTTPD.Controls.Add(this.btn_http_dir);
            this.HTTPD.Controls.Add(this.text_http_dir);
            this.HTTPD.Controls.Add(this.btn_httpd);
            this.HTTPD.Controls.Add(this.httpd_output);
            this.HTTPD.Location = new System.Drawing.Point(4, 25);
            this.HTTPD.Name = "HTTPD";
            this.HTTPD.Padding = new System.Windows.Forms.Padding(3);
            this.HTTPD.Size = new System.Drawing.Size(759, 448);
            this.HTTPD.TabIndex = 1;
            this.HTTPD.Text = "HTTPD";
            this.HTTPD.UseVisualStyleBackColor = true;
            // 
            // label_http_port
            // 
            this.label_http_port.AutoSize = true;
            this.label_http_port.Location = new System.Drawing.Point(32, 35);
            this.label_http_port.Name = "label_http_port";
            this.label_http_port.Size = new System.Drawing.Size(37, 20);
            this.label_http_port.TabIndex = 0;
            this.label_http_port.Text = "Port";
            // 
            // text_http_port
            // 
            this.text_http_port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_http_port.Location = new System.Drawing.Point(114, 30);
            this.text_http_port.Name = "text_http_port";
            this.text_http_port.Size = new System.Drawing.Size(596, 25);
            this.text_http_port.TabIndex = 1;
            // 
            // btn_http_dir
            // 
            this.btn_http_dir.Location = new System.Drawing.Point(33, 82);
            this.btn_http_dir.Name = "btn_http_dir";
            this.btn_http_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_http_dir.TabIndex = 6;
            this.btn_http_dir.Text = "Directory";
            this.btn_http_dir.UseVisualStyleBackColor = true;
            // 
            // text_http_dir
            // 
            this.text_http_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_http_dir.Location = new System.Drawing.Point(114, 80);
            this.text_http_dir.Name = "text_http_dir";
            this.text_http_dir.Size = new System.Drawing.Size(596, 25);
            this.text_http_dir.TabIndex = 3;
            // 
            // btn_httpd
            // 
            this.btn_httpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_httpd.Location = new System.Drawing.Point(635, 133);
            this.btn_httpd.Name = "btn_httpd";
            this.btn_httpd.Size = new System.Drawing.Size(75, 27);
            this.btn_httpd.TabIndex = 4;
            this.btn_httpd.Text = "开始";
            this.btn_httpd.UseVisualStyleBackColor = true;
            // 
            // httpd_output
            // 
            this.httpd_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.httpd_output.FormattingEnabled = true;
            this.httpd_output.ItemHeight = 20;
            this.httpd_output.Location = new System.Drawing.Point(36, 198);
            this.httpd_output.Name = "httpd_output";
            this.httpd_output.Size = new System.Drawing.Size(674, 184);
            this.httpd_output.TabIndex = 5;
            // 
            // TFTPD
            // 
            this.TFTPD.Controls.Add(this.tftp_dirtext1);
            this.TFTPD.Controls.Add(this.tftp_dirbtn1);
            this.TFTPD.Controls.Add(this.tftp_dirtext2);
            this.TFTPD.Controls.Add(this.tftp_dirbtn2);
            this.TFTPD.Controls.Add(this.tftp_dirtext3);
            this.TFTPD.Controls.Add(this.tftp_dirbtn3);
            this.TFTPD.Controls.Add(this.tftp_dirtext4);
            this.TFTPD.Controls.Add(this.tftp_dirbtn4);
            this.TFTPD.Controls.Add(this.tftp_dirtext5);
            this.TFTPD.Controls.Add(this.tftp_dirbtn5);
            this.TFTPD.Controls.Add(this.tftpd_output);
            this.TFTPD.Location = new System.Drawing.Point(4, 29);
            this.TFTPD.Name = "TFTPD";
            this.TFTPD.Padding = new System.Windows.Forms.Padding(3);
            this.TFTPD.Size = new System.Drawing.Size(759, 444);
            this.TFTPD.TabIndex = 5;
            this.TFTPD.Text = "TFTPD";
            this.TFTPD.UseVisualStyleBackColor = true;
            // 
            // tftp_dirtext1
            // 
            this.tftp_dirtext1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftp_dirtext1.Location = new System.Drawing.Point(135, 19);
            this.tftp_dirtext1.Name = "tftp_dirtext1";
            this.tftp_dirtext1.Size = new System.Drawing.Size(576, 25);
            this.tftp_dirtext1.TabIndex = 10;
            // 
            // tftp_dirbtn1
            // 
            this.tftp_dirbtn1.Location = new System.Drawing.Point(31, 21);
            this.tftp_dirbtn1.Name = "tftp_dirbtn1";
            this.tftp_dirbtn1.Size = new System.Drawing.Size(75, 23);
            this.tftp_dirbtn1.TabIndex = 9;
            this.tftp_dirbtn1.Text = "Directory 1";
            this.tftp_dirbtn1.UseVisualStyleBackColor = true;
            // 
            // tftp_dirtext2
            // 
            this.tftp_dirtext2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftp_dirtext2.Location = new System.Drawing.Point(135, 65);
            this.tftp_dirtext2.Name = "tftp_dirtext2";
            this.tftp_dirtext2.Size = new System.Drawing.Size(576, 25);
            this.tftp_dirtext2.TabIndex = 8;
            // 
            // tftp_dirbtn2
            // 
            this.tftp_dirbtn2.Location = new System.Drawing.Point(31, 67);
            this.tftp_dirbtn2.Name = "tftp_dirbtn2";
            this.tftp_dirbtn2.Size = new System.Drawing.Size(75, 23);
            this.tftp_dirbtn2.TabIndex = 7;
            this.tftp_dirbtn2.Text = "Directory 2";
            this.tftp_dirbtn2.UseVisualStyleBackColor = true;
            // 
            // tftp_dirtext3
            // 
            this.tftp_dirtext3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftp_dirtext3.Location = new System.Drawing.Point(135, 110);
            this.tftp_dirtext3.Name = "tftp_dirtext3";
            this.tftp_dirtext3.Size = new System.Drawing.Size(576, 25);
            this.tftp_dirtext3.TabIndex = 6;
            // 
            // tftp_dirbtn3
            // 
            this.tftp_dirbtn3.Location = new System.Drawing.Point(31, 112);
            this.tftp_dirbtn3.Name = "tftp_dirbtn3";
            this.tftp_dirbtn3.Size = new System.Drawing.Size(75, 23);
            this.tftp_dirbtn3.TabIndex = 5;
            this.tftp_dirbtn3.Text = "Directory 3";
            this.tftp_dirbtn3.UseVisualStyleBackColor = true;
            // 
            // tftp_dirtext4
            // 
            this.tftp_dirtext4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftp_dirtext4.Location = new System.Drawing.Point(135, 155);
            this.tftp_dirtext4.Name = "tftp_dirtext4";
            this.tftp_dirtext4.Size = new System.Drawing.Size(576, 25);
            this.tftp_dirtext4.TabIndex = 4;
            // 
            // tftp_dirbtn4
            // 
            this.tftp_dirbtn4.Location = new System.Drawing.Point(31, 157);
            this.tftp_dirbtn4.Name = "tftp_dirbtn4";
            this.tftp_dirbtn4.Size = new System.Drawing.Size(75, 23);
            this.tftp_dirbtn4.TabIndex = 3;
            this.tftp_dirbtn4.Text = "Directory 4";
            this.tftp_dirbtn4.UseVisualStyleBackColor = true;
            // 
            // tftp_dirtext5
            // 
            this.tftp_dirtext5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftp_dirtext5.Location = new System.Drawing.Point(135, 199);
            this.tftp_dirtext5.Name = "tftp_dirtext5";
            this.tftp_dirtext5.Size = new System.Drawing.Size(576, 25);
            this.tftp_dirtext5.TabIndex = 2;
            // 
            // tftp_dirbtn5
            // 
            this.tftp_dirbtn5.Location = new System.Drawing.Point(31, 201);
            this.tftp_dirbtn5.Name = "tftp_dirbtn5";
            this.tftp_dirbtn5.Size = new System.Drawing.Size(75, 23);
            this.tftp_dirbtn5.TabIndex = 1;
            this.tftp_dirbtn5.Text = "Directory 5";
            this.tftp_dirbtn5.UseVisualStyleBackColor = true;
            // 
            // FTPD
            // 
            this.FTPD.Controls.Add(this.ftp_dirtext1);
            this.FTPD.Controls.Add(this.ftp_dirbtn1);
            this.FTPD.Controls.Add(this.ftp_dirtext2);
            this.FTPD.Controls.Add(this.ftp_dirbtn2);
            this.FTPD.Controls.Add(this.ftp_dirtext3);
            this.FTPD.Controls.Add(this.ftp_dirbtn3);
            this.FTPD.Controls.Add(this.ftp_dirtext4);
            this.FTPD.Controls.Add(this.ftp_dirbtn4);
            this.FTPD.Controls.Add(this.ftp_dirtext5);
            this.FTPD.Controls.Add(this.ftp_dirbtn5);
            this.FTPD.Controls.Add(this.btn_ftp);
            this.FTPD.Location = new System.Drawing.Point(4, 25);
            this.FTPD.Name = "FTPD";
            this.FTPD.Padding = new System.Windows.Forms.Padding(3);
            this.FTPD.Size = new System.Drawing.Size(759, 448);
            this.FTPD.TabIndex = 3;
            this.FTPD.Text = "FTPD";
            this.FTPD.UseVisualStyleBackColor = true;
            // 
            // ftp_dirtext1
            // 
            this.ftp_dirtext1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftp_dirtext1.Location = new System.Drawing.Point(135, 19);
            this.ftp_dirtext1.Name = "ftp_dirtext1";
            this.ftp_dirtext1.Size = new System.Drawing.Size(576, 25);
            this.ftp_dirtext1.TabIndex = 10;
            // 
            // ftp_dirbtn1
            // 
            this.ftp_dirbtn1.Location = new System.Drawing.Point(31, 21);
            this.ftp_dirbtn1.Name = "ftp_dirbtn1";
            this.ftp_dirbtn1.Size = new System.Drawing.Size(75, 23);
            this.ftp_dirbtn1.TabIndex = 9;
            this.ftp_dirbtn1.Text = "Directory 1";
            this.ftp_dirbtn1.UseVisualStyleBackColor = true;
            // 
            // ftp_dirtext2
            // 
            this.ftp_dirtext2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftp_dirtext2.Location = new System.Drawing.Point(135, 65);
            this.ftp_dirtext2.Name = "ftp_dirtext2";
            this.ftp_dirtext2.Size = new System.Drawing.Size(576, 25);
            this.ftp_dirtext2.TabIndex = 8;
            // 
            // ftp_dirbtn2
            // 
            this.ftp_dirbtn2.Location = new System.Drawing.Point(31, 67);
            this.ftp_dirbtn2.Name = "ftp_dirbtn2";
            this.ftp_dirbtn2.Size = new System.Drawing.Size(75, 23);
            this.ftp_dirbtn2.TabIndex = 7;
            this.ftp_dirbtn2.Text = "Directory 2";
            this.ftp_dirbtn2.UseVisualStyleBackColor = true;
            // 
            // ftp_dirtext3
            // 
            this.ftp_dirtext3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftp_dirtext3.Location = new System.Drawing.Point(135, 110);
            this.ftp_dirtext3.Name = "ftp_dirtext3";
            this.ftp_dirtext3.Size = new System.Drawing.Size(576, 25);
            this.ftp_dirtext3.TabIndex = 6;
            // 
            // ftp_dirbtn3
            // 
            this.ftp_dirbtn3.Location = new System.Drawing.Point(31, 112);
            this.ftp_dirbtn3.Name = "ftp_dirbtn3";
            this.ftp_dirbtn3.Size = new System.Drawing.Size(75, 23);
            this.ftp_dirbtn3.TabIndex = 5;
            this.ftp_dirbtn3.Text = "Directory 3";
            this.ftp_dirbtn3.UseVisualStyleBackColor = true;
            // 
            // ftp_dirtext4
            // 
            this.ftp_dirtext4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftp_dirtext4.Location = new System.Drawing.Point(135, 155);
            this.ftp_dirtext4.Name = "ftp_dirtext4";
            this.ftp_dirtext4.Size = new System.Drawing.Size(576, 25);
            this.ftp_dirtext4.TabIndex = 4;
            // 
            // ftp_dirbtn4
            // 
            this.ftp_dirbtn4.Location = new System.Drawing.Point(31, 157);
            this.ftp_dirbtn4.Name = "ftp_dirbtn4";
            this.ftp_dirbtn4.Size = new System.Drawing.Size(75, 23);
            this.ftp_dirbtn4.TabIndex = 3;
            this.ftp_dirbtn4.Text = "Directory 4";
            this.ftp_dirbtn4.UseVisualStyleBackColor = true;
            // 
            // ftp_dirtext5
            // 
            this.ftp_dirtext5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftp_dirtext5.Location = new System.Drawing.Point(135, 199);
            this.ftp_dirtext5.Name = "ftp_dirtext5";
            this.ftp_dirtext5.Size = new System.Drawing.Size(576, 25);
            this.ftp_dirtext5.TabIndex = 2;
            // 
            // ftp_dirbtn5
            // 
            this.ftp_dirbtn5.Location = new System.Drawing.Point(31, 201);
            this.ftp_dirbtn5.Name = "ftp_dirbtn5";
            this.ftp_dirbtn5.Size = new System.Drawing.Size(75, 23);
            this.ftp_dirbtn5.TabIndex = 1;
            this.ftp_dirbtn5.Text = "Directory 5";
            this.ftp_dirbtn5.UseVisualStyleBackColor = true;
            // 
            // btn_ftp
            // 
            this.btn_ftp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ftp.Location = new System.Drawing.Point(636, 260);
            this.btn_ftp.Name = "btn_ftp";
            this.btn_ftp.Size = new System.Drawing.Size(75, 23);
            this.btn_ftp.TabIndex = 0;
            this.btn_ftp.Text = "Start";
            this.btn_ftp.UseVisualStyleBackColor = true;
            // 
            // DHCPD
            // 
            this.DHCPD.Controls.Add(this.dhcp_startlabel);
            this.DHCPD.Controls.Add(this.dhcp_starttext);
            this.DHCPD.Controls.Add(this.dhcp_endlabel);
            this.DHCPD.Controls.Add(this.dhcp_endtext);
            this.DHCPD.Controls.Add(this.dhcp_gatewaylabel);
            this.DHCPD.Controls.Add(this.dhcp_gatewaytext);
            this.DHCPD.Controls.Add(this.dhcp_logbtn);
            this.DHCPD.Controls.Add(this.dhcp_logtext);
            this.DHCPD.Controls.Add(this.dhcp_btn);
            this.DHCPD.Controls.Add(this.dhcp_logmsg);
            this.DHCPD.Location = new System.Drawing.Point(4, 25);
            this.DHCPD.Name = "DHCPD";
            this.DHCPD.Padding = new System.Windows.Forms.Padding(3);
            this.DHCPD.Size = new System.Drawing.Size(759, 448);
            this.DHCPD.TabIndex = 5;
            this.DHCPD.Text = "DHCPD";
            // 
            // dhcp_startlabel
            // 
            this.dhcp_startlabel.AutoSize = true;
            this.dhcp_startlabel.BackColor = System.Drawing.Color.Transparent;
            this.dhcp_startlabel.Location = new System.Drawing.Point(5, 19);
            this.dhcp_startlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dhcp_startlabel.Name = "dhcp_startlabel";
            this.dhcp_startlabel.Size = new System.Drawing.Size(65, 20);
            this.dhcp_startlabel.TabIndex = 12;
            this.dhcp_startlabel.Text = "起始地址";
            // 
            // dhcp_starttext
            // 
            this.dhcp_starttext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_starttext.Location = new System.Drawing.Point(72, 14);
            this.dhcp_starttext.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_starttext.Name = "dhcp_starttext";
            this.dhcp_starttext.Size = new System.Drawing.Size(679, 25);
            this.dhcp_starttext.TabIndex = 1;
            // 
            // dhcp_endlabel
            // 
            this.dhcp_endlabel.AutoSize = true;
            this.dhcp_endlabel.BackColor = System.Drawing.Color.Transparent;
            this.dhcp_endlabel.Location = new System.Drawing.Point(5, 60);
            this.dhcp_endlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dhcp_endlabel.Name = "dhcp_endlabel";
            this.dhcp_endlabel.Size = new System.Drawing.Size(65, 20);
            this.dhcp_endlabel.TabIndex = 0;
            this.dhcp_endlabel.Text = "结束地址";
            // 
            // dhcp_endtext
            // 
            this.dhcp_endtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_endtext.Location = new System.Drawing.Point(72, 55);
            this.dhcp_endtext.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_endtext.Name = "dhcp_endtext";
            this.dhcp_endtext.Size = new System.Drawing.Size(679, 25);
            this.dhcp_endtext.TabIndex = 2;
            // 
            // dhcp_gatewaylabel
            // 
            this.dhcp_gatewaylabel.AutoSize = true;
            this.dhcp_gatewaylabel.BackColor = System.Drawing.Color.Transparent;
            this.dhcp_gatewaylabel.Location = new System.Drawing.Point(5, 101);
            this.dhcp_gatewaylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dhcp_gatewaylabel.Name = "dhcp_gatewaylabel";
            this.dhcp_gatewaylabel.Size = new System.Drawing.Size(37, 20);
            this.dhcp_gatewaylabel.TabIndex = 1;
            this.dhcp_gatewaylabel.Text = "网关";
            // 
            // dhcp_gatewaytext
            // 
            this.dhcp_gatewaytext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_gatewaytext.Location = new System.Drawing.Point(72, 96);
            this.dhcp_gatewaytext.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_gatewaytext.Name = "dhcp_gatewaytext";
            this.dhcp_gatewaytext.Size = new System.Drawing.Size(679, 25);
            this.dhcp_gatewaytext.TabIndex = 3;
            // 
            // dhcp_logbtn
            // 
            this.dhcp_logbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.dhcp_logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dhcp_logbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dhcp_logbtn.FlatAppearance.BorderSize = 0;
            this.dhcp_logbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dhcp_logbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dhcp_logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dhcp_logbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhcp_logbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dhcp_logbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dhcp_logbtn.Location = new System.Drawing.Point(9, 133);
            this.dhcp_logbtn.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_logbtn.Name = "dhcp_logbtn";
            this.dhcp_logbtn.Size = new System.Drawing.Size(52, 32);
            this.dhcp_logbtn.TabIndex = 4;
            this.dhcp_logbtn.Text = "日志";
            this.dhcp_logbtn.UseVisualStyleBackColor = false;
            // 
            // dhcp_logtext
            // 
            this.dhcp_logtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_logtext.Location = new System.Drawing.Point(72, 140);
            this.dhcp_logtext.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_logtext.Name = "dhcp_logtext";
            this.dhcp_logtext.Size = new System.Drawing.Size(679, 25);
            this.dhcp_logtext.TabIndex = 5;
            // 
            // dhcp_btn
            // 
            this.dhcp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.dhcp_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dhcp_btn.FlatAppearance.BorderSize = 0;
            this.dhcp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dhcp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dhcp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dhcp_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhcp_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dhcp_btn.Location = new System.Drawing.Point(678, 190);
            this.dhcp_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_btn.Name = "dhcp_btn";
            this.dhcp_btn.Size = new System.Drawing.Size(73, 37);
            this.dhcp_btn.TabIndex = 6;
            this.dhcp_btn.Text = "开始";
            this.dhcp_btn.UseVisualStyleBackColor = false;
            // 
            // dhcp_logmsg
            // 
            this.dhcp_logmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhcp_logmsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhcp_logmsg.FormattingEnabled = true;
            this.dhcp_logmsg.ItemHeight = 19;
            this.dhcp_logmsg.Location = new System.Drawing.Point(9, 253);
            this.dhcp_logmsg.Margin = new System.Windows.Forms.Padding(2);
            this.dhcp_logmsg.Name = "dhcp_logmsg";
            this.dhcp_logmsg.Size = new System.Drawing.Size(742, 118);
            this.dhcp_logmsg.TabIndex = 7;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.lang);
            this.Setting.Controls.Add(this.lang_opt);
            this.Setting.Location = new System.Drawing.Point(4, 25);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(759, 448);
            this.Setting.TabIndex = 6;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // lang
            // 
            this.lang.AutoSize = true;
            this.lang.Location = new System.Drawing.Point(35, 31);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(76, 20);
            this.lang.TabIndex = 0;
            this.lang.Text = "Language";
            // 
            // lang_opt
            // 
            this.lang_opt.FormattingEnabled = true;
            this.lang_opt.Location = new System.Drawing.Point(129, 27);
            this.lang_opt.Name = "lang_opt";
            this.lang_opt.Size = new System.Drawing.Size(121, 28);
            this.lang_opt.TabIndex = 1;
            // 
            // tftpd_output
            // 
            this.tftpd_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tftpd_output.FormattingEnabled = true;
            this.tftpd_output.ItemHeight = 20;
            this.tftpd_output.Location = new System.Drawing.Point(31, 254);
            this.tftpd_output.Name = "tftpd_output";
            this.tftpd_output.Size = new System.Drawing.Size(680, 184);
            this.tftpd_output.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(767, 477);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rabbit";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.Ping.ResumeLayout(false);
            this.Ping.PerformLayout();
            this.HTTPD.ResumeLayout(false);
            this.HTTPD.PerformLayout();
            this.TFTPD.ResumeLayout(false);
            this.TFTPD.PerformLayout();
            this.FTPD.ResumeLayout(false);
            this.FTPD.PerformLayout();
            this.DHCPD.ResumeLayout(false);
            this.DHCPD.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox text_addr;
        private System.Windows.Forms.TextBox text_interval;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.Button btn_ping_log;
        private System.Windows.Forms.TextBox text_count;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox text_logpath;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage Ping;
        private System.Windows.Forms.TabPage HTTPD;
        private System.Windows.Forms.ListBox ping_output;
        private System.Windows.Forms.TabPage FTPD;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.Label label_http_port;
        private System.Windows.Forms.TextBox text_http_port;
        private System.Windows.Forms.TextBox text_http_dir;
        private System.Windows.Forms.Button btn_httpd;
        private System.Windows.Forms.TextBox ftp_dirtext1;
        private System.Windows.Forms.Button ftp_dirbtn1;
        private System.Windows.Forms.TextBox ftp_dirtext2;
        private System.Windows.Forms.Button ftp_dirbtn2;
        private System.Windows.Forms.TextBox ftp_dirtext3;
        private System.Windows.Forms.Button ftp_dirbtn3;
        private System.Windows.Forms.TextBox ftp_dirtext4;
        private System.Windows.Forms.Button ftp_dirbtn4;
        private System.Windows.Forms.TextBox ftp_dirtext5;
        private System.Windows.Forms.Button ftp_dirbtn5;
        private System.Windows.Forms.Button btn_ftp;
        private System.Windows.Forms.TabPage TFTPD;
        private System.Windows.Forms.TextBox tftp_dirtext1;
        private System.Windows.Forms.Button tftp_dirbtn1;
        private System.Windows.Forms.TextBox tftp_dirtext2;
        private System.Windows.Forms.Button tftp_dirbtn2;
        private System.Windows.Forms.TextBox tftp_dirtext3;
        private System.Windows.Forms.Button tftp_dirbtn3;
        private System.Windows.Forms.TextBox tftp_dirtext4;
        private System.Windows.Forms.Button tftp_dirbtn4;
        private System.Windows.Forms.TextBox tftp_dirtext5;
        private System.Windows.Forms.Button tftp_dirbtn5;
        private System.Windows.Forms.Label lang;
        private System.Windows.Forms.ComboBox lang_opt;
        private System.Windows.Forms.ListBox httpd_output;
        private System.Windows.Forms.TabPage DHCPD;
        private System.Windows.Forms.Label dhcp_startlabel;
        private System.Windows.Forms.TextBox dhcp_starttext;
        private System.Windows.Forms.Label dhcp_endlabel;
        private System.Windows.Forms.TextBox dhcp_endtext;
        private System.Windows.Forms.Label dhcp_gatewaylabel;
        private System.Windows.Forms.TextBox dhcp_gatewaytext;
        private System.Windows.Forms.Button dhcp_logbtn;
        private System.Windows.Forms.TextBox dhcp_logtext;
        private System.Windows.Forms.Button dhcp_btn;
        private System.Windows.Forms.ListBox dhcp_logmsg;
        private System.Windows.Forms.Button btn_http_dir;
        private System.Windows.Forms.ListBox tftpd_output;
    }
}

