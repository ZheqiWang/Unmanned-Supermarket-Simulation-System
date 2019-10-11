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
    public partial class InWarehouse : Form
    {
        public InWarehouse()
        {
            InitializeComponent();
            string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;";//设置连接字符串
            SqlConnection mycon = new SqlConnection(constr);  //实例化连接对象
            mycon.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT MAX(入库单据编号) FROM 入库单", mycon);
            int ListNum = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;
            Console.Write("{0:D3}", ListNum); //不足三位左侧补零
            ListNo.Text = (Convert.ToString(ListNum)).PadLeft(3, '0');
        }



        private void ListNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalprice = 0;
            int row = dataGridView1.Rows.Count;//获取所有行数
            for (int i = 0; i < (row-1); i++)
            {
                String Bar = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                String Name = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                String Number = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                String Unit = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                String Price = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                String Total = Convert.ToString(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value));
                totalprice = totalprice + Convert.ToDouble(Total);
                //MessageBox.Show(Bar + Name + Number + Unit + Price + Total);
                string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;"; //设置连接字符串
                SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
                mycon.Open();

                //商品基本信息放入入库单
                string s1 = "insert into 入库单(入库单据编号,商品名称,商品条码号,商品数量,单位,单价,总价,入库仓库,往来单位,入库时间,附加说明) values ('" + ListNo.Text
                    + "','" + Name + "','" + Bar + "','" + Number + "','" + Unit + "','" + Price + "','" + Total + "','" +comboBox2.Text + "','" + comboBox1.Text + "','"
                  + InWarehouseDate.Text + "','" + textBox1.Text + "')";                            //编写SQL命令
                SqlCommand mycom = new SqlCommand(s1, mycon);          //初始化命令
                mycom.ExecuteNonQuery();             //执行语句

                //查询库存中是否存在该商品
                string s2 = "select 商品名 from 库存 where 条码号='" + Bar + "'" ;        //编写SQL命令
                SqlCommand mycom1 = new SqlCommand(s2, mycon);          //初始化命令
                mycom1.ExecuteNonQuery();             //执行语句
                string result =  Convert.ToString(mycom1.ExecuteScalar());
                if (result=="")//不存在，插入新的商品
                {
                    string s3 = "insert into 库存(商品名,条码号,商品数量,单位,单价) values ('" + 
                    Name + "','" + Bar + "','" + Number + "','" + Unit + "','" + Price +"')";         //编写SQL命令
                    SqlCommand mycom2 = new SqlCommand(s3, mycon);          //初始化命令
                    mycom2.ExecuteNonQuery();             //执行语句
                }
                else//存在则更新商品数量
                {
                    string s5 = "select 商品数量 from 库存 where 条码号='" + Bar + "'";         //编写SQL命令
                    SqlCommand mycom4 = new SqlCommand(s5, mycon);          //初始化命令
                    mycom4.ExecuteNonQuery();             //执行语句
                    int comnumber = Convert.ToInt32(mycom4.ExecuteScalar());
                    comnumber = comnumber + Convert.ToInt32(Number);
                    string s4 = "UPDATE 库存 SET 商品数量='" + comnumber + "' WHERE 条码号='" + Bar + "'";        //编写SQL命令
                    SqlCommand mycom3 = new SqlCommand(s4, mycon);          //初始化命令
                    mycom3.ExecuteNonQuery();             //执行语句
                }
                mycon.Close();                       //关闭连接
                mycom = null;
                mycon.Dispose();                     //释放对象
                this.Close();
            }
            //这句显示不出来？？？
            TotalPrice.Text=Convert.ToString(totalprice);
            MessageBox.Show("入库成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int price = 0;

                bool isprice = Int32.TryParse(this.dataGridView1.CurrentRow.Cells[2].EditedFormattedValue.ToString(), out price);

                int num = 0;
                bool isnum = Int32.TryParse(this.dataGridView1.CurrentRow.Cells[4].EditedFormattedValue.ToString(), out num);

                int sum = price * num;
                this.dataGridView1.CurrentRow.Cells[5].Value = sum.ToString();
            }
        }
    }
}
