namespace 无人超市PC管理端
{
    partial class OffSelf
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
            this.label1 = new System.Windows.Forms.Label();
            this.readNum = new System.Windows.Forms.ComboBox();
            this.readStart = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.extraMsg = new System.Windows.Forms.TextBox();
            this.下架原因 = new System.Windows.Forms.Label();
            this.OffReason = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OffSelfdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComName = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MF_Read);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.readKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.readNum);
            this.groupBox1.Controls.Add(this.readStart);
            this.groupBox1.Location = new System.Drawing.Point(40, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读RFID标签";
            // 
            // btn_MF_Read
            // 
            this.btn_MF_Read.Location = new System.Drawing.Point(337, 39);
            this.btn_MF_Read.Name = "btn_MF_Read";
            this.btn_MF_Read.Size = new System.Drawing.Size(88, 69);
            this.btn_MF_Read.TabIndex = 6;
            this.btn_MF_Read.Text = "读RFID卡";
            this.btn_MF_Read.UseVisualStyleBackColor = true;
            this.btn_MF_Read.Click += new System.EventHandler(this.btn_MF_Read_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "密钥";
            // 
            // readKey
            // 
            this.readKey.FormattingEnabled = true;
            this.readKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.readKey.Location = new System.Drawing.Point(28, 82);
            this.readKey.Name = "readKey";
            this.readKey.Size = new System.Drawing.Size(206, 26);
            this.readKey.TabIndex = 4;
            this.readKey.Text = "FF FF FF FF FF FF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "块的数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始块";
            // 
            // readNum
            // 
            this.readNum.FormattingEnabled = true;
            this.readNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.readNum.Location = new System.Drawing.Point(179, 39);
            this.readNum.Name = "readNum";
            this.readNum.Size = new System.Drawing.Size(55, 26);
            this.readNum.TabIndex = 1;
            this.readNum.Text = "01";
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
            "1E",
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
            this.readStart.Location = new System.Drawing.Point(28, 39);
            this.readStart.Name = "readStart";
            this.readStart.Size = new System.Drawing.Size(58, 26);
            this.readStart.TabIndex = 0;
            this.readStart.Text = "10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.extraMsg);
            this.groupBox2.Controls.Add(this.下架原因);
            this.groupBox2.Controls.Add(this.OffReason);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.OffSelfdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ComName);
            this.groupBox2.Location = new System.Drawing.Point(40, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下架信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 87);
            this.button1.TabIndex = 10;
            this.button1.Text = "下架";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "附加说明";
            // 
            // extraMsg
            // 
            this.extraMsg.Location = new System.Drawing.Point(28, 161);
            this.extraMsg.Name = "extraMsg";
            this.extraMsg.Size = new System.Drawing.Size(300, 28);
            this.extraMsg.TabIndex = 8;
            // 
            // 下架原因
            // 
            this.下架原因.AutoSize = true;
            this.下架原因.Location = new System.Drawing.Point(240, 132);
            this.下架原因.Name = "下架原因";
            this.下架原因.Size = new System.Drawing.Size(80, 18);
            this.下架原因.TabIndex = 7;
            this.下架原因.Text = "下架原因";
            // 
            // OffReason
            // 
            this.OffReason.FormattingEnabled = true;
            this.OffReason.Items.AddRange(new object[] {
            "商品过期",
            "长时间无人购买",
            "商品损坏"});
            this.OffReason.Location = new System.Drawing.Point(28, 129);
            this.OffReason.Name = "OffReason";
            this.OffReason.Size = new System.Drawing.Size(200, 26);
            this.OffReason.TabIndex = 6;
            this.OffReason.Text = "商品过期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "下架时间";
            // 
            // OffSelfdate
            // 
            this.OffSelfdate.Location = new System.Drawing.Point(28, 95);
            this.OffSelfdate.Name = "OffSelfdate";
            this.OffSelfdate.Size = new System.Drawing.Size(200, 28);
            this.OffSelfdate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "条码号";
            // 
            // ComBar
            // 
            this.ComBar.Location = new System.Drawing.Point(28, 61);
            this.ComBar.Name = "ComBar";
            this.ComBar.Size = new System.Drawing.Size(200, 28);
            this.ComBar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "商品名";
            // 
            // ComName
            // 
            this.ComName.Location = new System.Drawing.Point(28, 27);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(200, 28);
            this.ComName.TabIndex = 0;
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(6, 27);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(281, 416);
            this.textResponse.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textResponse);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(491, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 449);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OffSelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "OffSelf";
            this.Text = "商品下架";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox readNum;
        private System.Windows.Forms.ComboBox readStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox readKey;
        private System.Windows.Forms.Button btn_MF_Read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox extraMsg;
        private System.Windows.Forms.Label 下架原因;
        private System.Windows.Forms.ComboBox OffReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker OffSelfdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ComBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ComName;
        private System.Windows.Forms.TextBox textBox1;
    }
}