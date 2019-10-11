using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 无人超市PC管理端
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InWarehouse_Click(object sender, EventArgs e)
        {
            InWarehouse inwarehouse = new InWarehouse();
            inwarehouse.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutWarehouse outwarehouse = new OutWarehouse();
            outwarehouse.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnSelf onself = new OnSelf();
            onself.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OffSelf offself = new OffSelf();
            offself.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 商品入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InWarehouse f5 = new InWarehouse();
            //窗体最大化
            f5.WindowState = FormWindowState.Maximized;
            //去掉边框
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.MdiParent = this;
            //设置新窗体的Parent
            f5.Parent = panel1;
            f5.Show();
        }

        private void 商品出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutWarehouse f5 = new OutWarehouse();
            //窗体最大化
            f5.WindowState = FormWindowState.Maximized;
            //去掉边框
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.MdiParent = this;
            //设置新窗体的Parent
            f5.Parent = panel1;
            f5.Show();
        }

        private void 商品上架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSelf f5 = new OnSelf();
            //窗体最大化
            f5.WindowState = FormWindowState.Maximized;
            //去掉边框
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.MdiParent = this;
            //设置新窗体的Parent
            f5.Parent = panel1;
            f5.Show();
        }

        private void 商品下架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OffSelf f5 = new OffSelf();
            //窗体最大化
            f5.WindowState = FormWindowState.Maximized;
            //去掉边框
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.MdiParent = this;
            //设置新窗体的Parent
            f5.Parent = panel1;
            f5.Show();
        }

       
    }
}
