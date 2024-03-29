﻿namespace 无人超市PC管理端
{
    partial class OutWarehouse
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
            this.ComBar = new System.Windows.Forms.TextBox();
            this.商品条码 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OutNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutAddress = new System.Windows.Forms.ComboBox();
            this.OutdateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBar
            // 
            this.ComBar.Location = new System.Drawing.Point(191, 57);
            this.ComBar.Name = "ComBar";
            this.ComBar.Size = new System.Drawing.Size(386, 28);
            this.ComBar.TabIndex = 0;
            // 
            // 商品条码
            // 
            this.商品条码.AutoSize = true;
            this.商品条码.Location = new System.Drawing.Point(89, 60);
            this.商品条码.Name = "商品条码";
            this.商品条码.Size = new System.Drawing.Size(80, 18);
            this.商品条码.TabIndex = 1;
            this.商品条码.Text = "商品条码";
            this.商品条码.Click += new System.EventHandler(this.商品条码_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询库存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(630, 205);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "出库数量";
            // 
            // OutNum
            // 
            this.OutNum.Location = new System.Drawing.Point(191, 337);
            this.OutNum.Name = "OutNum";
            this.OutNum.Size = new System.Drawing.Size(386, 28);
            this.OutNum.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 99);
            this.button2.TabIndex = 6;
            this.button2.Text = "确认出库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "出库地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "出库时间";
            // 
            // OutAddress
            // 
            this.OutAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "上海徐汇仓库",
            "上海奉贤仓库",
            "吉林长春仓库"});
            this.OutAddress.FormattingEnabled = true;
            this.OutAddress.Items.AddRange(new object[] {
            "上海徐汇仓库",
            "上海奉贤仓库",
            "吉林长春仓库"});
            this.OutAddress.Location = new System.Drawing.Point(191, 374);
            this.OutAddress.Name = "OutAddress";
            this.OutAddress.Size = new System.Drawing.Size(386, 26);
            this.OutAddress.TabIndex = 9;
            // 
            // OutdateTime
            // 
            this.OutdateTime.Location = new System.Drawing.Point(191, 408);
            this.OutdateTime.Name = "OutdateTime";
            this.OutdateTime.Size = new System.Drawing.Size(386, 28);
            this.OutdateTime.TabIndex = 10;
            // 
            // OutWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 525);
            this.Controls.Add(this.OutdateTime);
            this.Controls.Add(this.OutAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.商品条码);
            this.Controls.Add(this.ComBar);
            this.Name = "OutWarehouse";
            this.Text = "商品出库";
            this.Load += new System.EventHandler(this.OutWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComBar;
        private System.Windows.Forms.Label 商品条码;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OutAddress;
        private System.Windows.Forms.DateTimePicker OutdateTime;
    }
}