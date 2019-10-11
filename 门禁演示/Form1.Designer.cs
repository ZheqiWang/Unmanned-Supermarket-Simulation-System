namespace 门禁演示
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MF_Read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.readKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readStart = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 118);
            this.groupBox1.TabIndex = 5;
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
            this.btn_MF_Read.Click += new System.EventHandler(this.btn_MF_Read_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textResponse);
            this.groupBox3.Location = new System.Drawing.Point(493, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 439);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(6, 27);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(284, 406);
            this.textResponse.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 28);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "门禁演示";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_MF_Read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox readKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox readNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox readStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

