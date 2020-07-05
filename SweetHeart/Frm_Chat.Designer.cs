namespace MyQQ
{
    partial class Frm_Chat
    {
        ///<summary>
        ///必需的设计器变量。
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        ///<summary>
        ///清理所有正在使用的资源。
        ///</summary>
        ///<param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        ///<summary>
        ///设计器支持所需的方法 - 不要
        ///使用代码编辑器修改此方法的内容。
        ///</summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.lblFriend = new System.Windows.Forms.Label();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.rtxtChat = new System.Windows.Forms.RichTextBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.tmShowMessage = new System.Windows.Forms.Timer(this.components);
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFriend
            // 
            this.lblFriend.BackColor = System.Drawing.Color.Transparent;
            this.lblFriend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriend.Location = new System.Drawing.Point(76, 0);
            this.lblFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(381, 52);
            this.lblFriend.TabIndex = 0;
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxHead
            // 
            this.pboxHead.BackColor = System.Drawing.SystemColors.Control;
            this.pboxHead.Location = new System.Drawing.Point(-5, 0);
            this.pboxHead.Margin = new System.Windows.Forms.Padding(4);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(59, 52);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxHead.TabIndex = 1;
            this.pboxHead.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.MistyRose;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSend.Location = new System.Drawing.Point(432, 619);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 36);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(313, 619);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Empty;
            this.imglistHead.Images.SetKeyName(0, "1");
            this.imglistHead.Images.SetKeyName(1, "2");
            this.imglistHead.Images.SetKeyName(2, "3");
            this.imglistHead.Images.SetKeyName(3, "4");
            this.imglistHead.Images.SetKeyName(4, "5");
            this.imglistHead.Images.SetKeyName(5, "6");
            this.imglistHead.Images.SetKeyName(6, "7");
            this.imglistHead.Images.SetKeyName(7, "8");
            this.imglistHead.Images.SetKeyName(8, "9");
            this.imglistHead.Images.SetKeyName(9, "10");
            this.imglistHead.Images.SetKeyName(10, "11");
            this.imglistHead.Images.SetKeyName(11, "12");
            this.imglistHead.Images.SetKeyName(12, "13");
            this.imglistHead.Images.SetKeyName(13, "14");
            this.imglistHead.Images.SetKeyName(14, "15");
            this.imglistHead.Images.SetKeyName(15, "16");
            this.imglistHead.Images.SetKeyName(16, "17");
            this.imglistHead.Images.SetKeyName(17, "18");
            this.imglistHead.Images.SetKeyName(18, "19");
            this.imglistHead.Images.SetKeyName(19, "20");
            this.imglistHead.Images.SetKeyName(20, "21");
            this.imglistHead.Images.SetKeyName(21, "22");
            this.imglistHead.Images.SetKeyName(22, "23");
            this.imglistHead.Images.SetKeyName(23, "24");
            this.imglistHead.Images.SetKeyName(24, "25");
            this.imglistHead.Images.SetKeyName(25, "26");
            this.imglistHead.Images.SetKeyName(26, "27");
            this.imglistHead.Images.SetKeyName(27, "28");
            this.imglistHead.Images.SetKeyName(28, "29");
            this.imglistHead.Images.SetKeyName(29, "30");
            this.imglistHead.Images.SetKeyName(30, "31");
            this.imglistHead.Images.SetKeyName(31, "32");
            this.imglistHead.Images.SetKeyName(32, "33");
            this.imglistHead.Images.SetKeyName(33, "34");
            this.imglistHead.Images.SetKeyName(34, "35");
            this.imglistHead.Images.SetKeyName(35, "36");
            this.imglistHead.Images.SetKeyName(36, "37");
            this.imglistHead.Images.SetKeyName(37, "38");
            this.imglistHead.Images.SetKeyName(38, "39");
            this.imglistHead.Images.SetKeyName(39, "40");
            this.imglistHead.Images.SetKeyName(40, "41");
            this.imglistHead.Images.SetKeyName(41, "42");
            this.imglistHead.Images.SetKeyName(42, "43");
            this.imglistHead.Images.SetKeyName(43, "44");
            this.imglistHead.Images.SetKeyName(44, "45");
            this.imglistHead.Images.SetKeyName(45, "46");
            this.imglistHead.Images.SetKeyName(46, "47");
            this.imglistHead.Images.SetKeyName(47, "48");
            this.imglistHead.Images.SetKeyName(48, "49");
            this.imglistHead.Images.SetKeyName(49, "50");
            this.imglistHead.Images.SetKeyName(50, "51");
            this.imglistHead.Images.SetKeyName(51, "52");
            this.imglistHead.Images.SetKeyName(52, "53");
            this.imglistHead.Images.SetKeyName(53, "54");
            this.imglistHead.Images.SetKeyName(54, "55");
            this.imglistHead.Images.SetKeyName(55, "56");
            this.imglistHead.Images.SetKeyName(56, "57");
            this.imglistHead.Images.SetKeyName(57, "58");
            this.imglistHead.Images.SetKeyName(58, "59");
            this.imglistHead.Images.SetKeyName(59, "60");
            this.imglistHead.Images.SetKeyName(60, "61");
            this.imglistHead.Images.SetKeyName(61, "62");
            this.imglistHead.Images.SetKeyName(62, "63");
            this.imglistHead.Images.SetKeyName(63, "64");
            this.imglistHead.Images.SetKeyName(64, "65");
            this.imglistHead.Images.SetKeyName(65, "66");
            this.imglistHead.Images.SetKeyName(66, "67");
            this.imglistHead.Images.SetKeyName(67, "68");
            this.imglistHead.Images.SetKeyName(68, "69");
            this.imglistHead.Images.SetKeyName(69, "70");
            this.imglistHead.Images.SetKeyName(70, "71");
            this.imglistHead.Images.SetKeyName(71, "72");
            this.imglistHead.Images.SetKeyName(72, "73");
            this.imglistHead.Images.SetKeyName(73, "74");
            this.imglistHead.Images.SetKeyName(74, "75");
            this.imglistHead.Images.SetKeyName(75, "76");
            this.imglistHead.Images.SetKeyName(76, "77");
            this.imglistHead.Images.SetKeyName(77, "78");
            this.imglistHead.Images.SetKeyName(78, "79");
            this.imglistHead.Images.SetKeyName(79, "80");
            this.imglistHead.Images.SetKeyName(80, "81");
            this.imglistHead.Images.SetKeyName(81, "82");
            this.imglistHead.Images.SetKeyName(82, "83");
            this.imglistHead.Images.SetKeyName(83, "84");
            this.imglistHead.Images.SetKeyName(84, "85");
            this.imglistHead.Images.SetKeyName(85, "86");
            this.imglistHead.Images.SetKeyName(86, "87");
            this.imglistHead.Images.SetKeyName(87, "88");
            this.imglistHead.Images.SetKeyName(88, "89");
            this.imglistHead.Images.SetKeyName(89, "90");
            this.imglistHead.Images.SetKeyName(90, "91");
            this.imglistHead.Images.SetKeyName(91, "92");
            this.imglistHead.Images.SetKeyName(92, "93");
            this.imglistHead.Images.SetKeyName(93, "94");
            this.imglistHead.Images.SetKeyName(94, "95");
            this.imglistHead.Images.SetKeyName(95, "96");
            this.imglistHead.Images.SetKeyName(96, "97");
            this.imglistHead.Images.SetKeyName(97, "98");
            this.imglistHead.Images.SetKeyName(98, "99");
            this.imglistHead.Images.SetKeyName(99, "100");
            this.imglistHead.Images.SetKeyName(100, "back.bmp");
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BackColor = System.Drawing.Color.White;
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMessage.Location = new System.Drawing.Point(-5, 56);
            this.rtxtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.ReadOnly = true;
            this.rtxtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtMessage.Size = new System.Drawing.Size(563, 421);
            this.rtxtMessage.TabIndex = 6;
            this.rtxtMessage.Text = "";
            this.rtxtMessage.TextChanged += new System.EventHandler(this.RtxtMessage_TextChanged);
            // 
            // rtxtChat
            // 
            this.rtxtChat.BackColor = System.Drawing.Color.White;
            this.rtxtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtChat.Location = new System.Drawing.Point(-1, 518);
            this.rtxtChat.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtChat.Name = "rtxtChat";
            this.rtxtChat.Size = new System.Drawing.Size(559, 87);
            this.rtxtChat.TabIndex = 7;
            this.rtxtChat.Text = "";
            this.rtxtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtChat_KeyDown);
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxClose.BackgroundImage")));
            this.pboxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxClose.Location = new System.Drawing.Point(507, 0);
            this.pboxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(36, 35);
            this.pboxClose.TabIndex = 9;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxMin.BackgroundImage")));
            this.pboxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxMin.Location = new System.Drawing.Point(463, 0);
            this.pboxMin.Margin = new System.Windows.Forms.Padding(4);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(36, 35);
            this.pboxMin.TabIndex = 8;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // tmShowMessage
            // 
            this.tmShowMessage.Enabled = true;
            this.tmShowMessage.Interval = 2000;
            this.tmShowMessage.Tick += new System.EventHandler(this.tmShowMessage_Tick);
            // 
            // pboxInfo
            // 
            this.pboxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pboxInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxInfo.BackgroundImage")));
            this.pboxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxInfo.Location = new System.Drawing.Point(507, 475);
            this.pboxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pboxInfo.Name = "pboxInfo";
            this.pboxInfo.Size = new System.Drawing.Size(51, 44);
            this.pboxInfo.TabIndex = 10;
            this.pboxInfo.TabStop = false;
            this.pboxInfo.Click += new System.EventHandler(this.pboxInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 44);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(79, 484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 668);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboxInfo);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.rtxtChat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pboxHead);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblFriend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Chat_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imglistHead;
        private System.Windows.Forms.RichTextBox rtxtChat;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.Timer tmShowMessage;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.PictureBox pboxInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}