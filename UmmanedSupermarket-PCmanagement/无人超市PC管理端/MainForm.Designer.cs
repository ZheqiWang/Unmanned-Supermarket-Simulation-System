namespace 无人超市PC管理端
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品上架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品下架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品推荐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品入库ToolStripMenuItem,
            this.商品出库ToolStripMenuItem,
            this.商品上架ToolStripMenuItem,
            this.商品下架ToolStripMenuItem,
            this.商品推荐ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品入库ToolStripMenuItem
            // 
            this.商品入库ToolStripMenuItem.Name = "商品入库ToolStripMenuItem";
            this.商品入库ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品入库ToolStripMenuItem.Text = "商品入库";
            this.商品入库ToolStripMenuItem.Click += new System.EventHandler(this.商品入库ToolStripMenuItem_Click);
            // 
            // 商品出库ToolStripMenuItem
            // 
            this.商品出库ToolStripMenuItem.Name = "商品出库ToolStripMenuItem";
            this.商品出库ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品出库ToolStripMenuItem.Text = "商品出库";
            this.商品出库ToolStripMenuItem.Click += new System.EventHandler(this.商品出库ToolStripMenuItem_Click);
            // 
            // 商品上架ToolStripMenuItem
            // 
            this.商品上架ToolStripMenuItem.Name = "商品上架ToolStripMenuItem";
            this.商品上架ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品上架ToolStripMenuItem.Text = "商品上架";
            this.商品上架ToolStripMenuItem.Click += new System.EventHandler(this.商品上架ToolStripMenuItem_Click);
            // 
            // 商品下架ToolStripMenuItem
            // 
            this.商品下架ToolStripMenuItem.Name = "商品下架ToolStripMenuItem";
            this.商品下架ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品下架ToolStripMenuItem.Text = "商品下架";
            this.商品下架ToolStripMenuItem.Click += new System.EventHandler(this.商品下架ToolStripMenuItem_Click);
            // 
            // 商品推荐ToolStripMenuItem
            // 
            this.商品推荐ToolStripMenuItem.Name = "商品推荐ToolStripMenuItem";
            this.商品推荐ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.商品推荐ToolStripMenuItem.Text = "商品推荐";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::无人超市PC管理端.Properties.Resources.timg53JB9C56;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 531);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 556);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "无人超市";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品上架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品下架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品推荐ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}