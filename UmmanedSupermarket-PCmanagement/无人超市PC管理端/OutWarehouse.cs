using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 无人超市PC管理端
{
    public partial class OutWarehouse : Form
    {
        public OutWarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComBar.Text == null)
            {
                MessageBox.Show("请输入商品条码号~");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;Initial Catalog=无人超市;Integrated Security=SSPI;");
                conn.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from 库存 where 条码号 = '" + ComBar.Text + "'", conn);
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2, "DA2");
                dataGridView1.DataSource = ds2;
                dataGridView1.DataSource = ds2.Tables["DA2"];
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;";//设置连接字符串
            SqlConnection mycon = new SqlConnection(constr);  //实例化连接对象
            mycon.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT 商品数量 FROM 库存 WHERE 条码号='" + ComBar.Text + "'", mycon);
            int comNum = Convert.ToInt32(cmd1.ExecuteScalar());
            //MessageBox.Show(Convert.ToString(comNum));

            if (comNum < Convert.ToInt32(OutNum.Text))
            {
                MessageBox.Show("仓库里没有那么多东西哟~");
            }
            else
            {
                SqlCommand cmd3 = new SqlCommand(" SELECT 商品名 FROM 库存 WHERE 条码号='" + ComBar.Text + "'", mycon);
                string cName = Convert.ToString(cmd3.ExecuteScalar());
                SqlCommand cmd4 = new SqlCommand(" SELECT 单位 FROM 库存 WHERE 条码号='" + ComBar.Text + "'", mycon);
                string cUnit = Convert.ToString(cmd4.ExecuteScalar());
                SqlCommand cmd5 = new SqlCommand(" SELECT 单价 FROM 库存 WHERE 条码号='" + ComBar.Text + "'", mycon);
                string cPrice = Convert.ToString(cmd5.ExecuteScalar());
                string wheretogo = "退货";

                string s1 = "insert into 出库单(商品名称,条码号,数量,单位,单价,出库地址,出库去向,出库时间) values ('" + cName
                   + "','" + ComBar.Text + "','" + OutNum.Text + "','" + cUnit + "','" + cPrice + "','" + OutAddress.Text + "','" 
                 + wheretogo + "','" + OutdateTime.Text + "')";                            //编写SQL命令
                SqlCommand mycom = new SqlCommand(s1, mycon);          //初始化命令
                mycom.ExecuteNonQuery();             //执行语句

                int temp = comNum - Convert.ToInt32(OutNum.Text);
                SqlCommand cmd2 = new SqlCommand("UPDATE 库存 SET 商品数量='" + temp + "' WHERE 条码号='" + ComBar.Text + "'", mycon);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                MessageBox.Show("出库成功！");
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 商品条码_Click(object sender, EventArgs e)
        {

        }

        private void OutWarehouse_Load(object sender, EventArgs e)
        {

        }
    }
}
