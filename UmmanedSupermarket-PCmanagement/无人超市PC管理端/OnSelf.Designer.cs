namespace 无人超市PC管理端
{
    partial class OnSelf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MF_Read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.readKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readStart = new System.Windows.Forms.ComboBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bn_onself = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OnSelfDate = new System.Windows.Forms.DateTimePicker();
            this.extraMessage = new System.Windows.Forms.TextBox();
            this.ComBar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MF_Read);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.readKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.readNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.readStart);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读RFID卡";
            // 
            // btn_MF_Read
            // 
            this.btn_MF_Read.Location = new System.Drawing.Point(331, 33);
            this.btn_MF_Read.Name = "btn_MF_Read";
            this.btn_MF_Read.Size = new System.Drawing.Size(91, 64);
            this.btn_MF_Read.TabIndex = 6;
            this.btn_MF_Read.Text = "读RFID卡";
            this.btn_MF_Read.UseVisualStyleBackColor = true;
            this.btn_MF_Read.Click += new System.EventHandler(this.btn_MF_Read_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "密钥";
            // 
            // readKey
            // 
            this.readKey.FormattingEnabled = true;
            this.readKey.Items.AddRange(new object[] {
            "FF FF FF FF FF FF",
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5"});
            this.readKey.Location = new System.Drawing.Point(27, 71);
            this.readKey.Name = "readKey";
            this.readKey.Size = new System.Drawing.Size(210, 26);
            this.readKey.TabIndex = 5;
            this.readKey.Text = "FF FF FF FF FF FF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "块的数量";
            // 
            // readNum
            // 
            this.readNum.FormattingEnabled = true;
            this.readNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.readNum.Location = new System.Drawing.Point(177, 30);
            this.readNum.Name = "readNum";
            this.readNum.Size = new System.Drawing.Size(51, 26);
            this.readNum.TabIndex = 3;
            this.readNum.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始块";
            // 
            // readStart
            // 
            this.readStart.FormattingEnabled = true;
            this.readStart.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1F",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "2F",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "3F"});
            this.readStart.Location = new System.Drawing.Point(27, 30);
            this.readStart.Name = "readStart";
            this.readStart.Size = new System.Drawing.Size(57, 26);
            this.readStart.TabIndex = 1;
            this.readStart.Text = "10";
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(6, 27);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(284, 406);
            this.textResponse.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textResponse);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(481, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 439);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bn_onself);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.OnSelfDate);
            this.groupBox2.Controls.Add(this.extraMessage);
            this.groupBox2.Controls.Add(this.ComBar);
            this.groupBox2.Location = new System.Drawing.Point(29, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 176);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上架信息";
            // 
            // bn_onself
            // 
            this.bn_onself.Location = new System.Drawing.Point(331, 77);
            this.bn_onself.Name = "bn_onself";
            this.bn_onself.Size = new System.Drawing.Size(91, 75);
            this.bn_onself.TabIndex = 6;
            this.bn_onself.Text = "上架";
            this.bn_onself.UseVisualStyleBackColor = true;
            this.bn_onself.Click += new System.EventHandler(this.bn_onself_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "附加信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "上架日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品条码号";
            // 
            // OnSelfDate
            // 
            this.OnSelfDate.Location = new System.Drawing.Point(27, 70);
            this.OnSelfDate.Name = "OnSelfDate";
            this.OnSelfDate.Size = new System.Drawing.Size(200, 28);
            this.OnSelfDate.TabIndex = 2;
            // 
            // extraMessage
            // 
            this.extraMessage.Location = new System.Drawing.Point(27, 113);
            this.extraMessage.Multiline = true;
            this.extraMessage.Name = "extraMessage";
            this.extraMessage.Size = new System.Drawing.Size(201, 39);
            this.extraMessage.TabIndex = 1;
            // 
            // ComBar
            // 
            this.ComBar.Location = new System.Drawing.Point(27, 27);
            this.ComBar.Name = "ComBar";
            this.ComBar.Size = new System.Drawing.Size(201, 28);
            this.ComBar.TabIndex = 0;
            // 
            // OnSelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "OnSelf";
            this.Text = "上架";
            this.Load += new System.EventHandler(this.OnSelf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MF_Read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox readNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox readStart;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox readKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bn_onself;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker OnSelfDate;
        private System.Windows.Forms.TextBox extraMessage;
        private System.Windows.Forms.TextBox ComBar;
        private System.Windows.Forms.TextBox textBox1;
    }
}