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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //检查是否已经存在
            string userID = userId.Text.Trim();  //取出账号

            /**
             * 连接数据库
             */
            string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;"; //设置连接字符串
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            //检查填写错误
            if (userId.Text == "" || userPw.TextLength < 6 || nickName.Text == "" || ensurePw.Text == "" || staffId.Text == "" || PhoneNo.Text == "" || PhoneNo.TextLength != 11)
            {
                MessageBox.Show("请将信息填完整");
            }
            else
            {
                //查询新注册的用户是否存在
                SqlCommand checkCmd = mycon.CreateCommand();       //创建SQL命令执行对象
                string s = "select 登录名 from 员工表 where 登录名='" + userID + "'";
                checkCmd.CommandText = s;
                SqlDataAdapter check = new SqlDataAdapter();       //实例化数据适配器
                check.SelectCommand = checkCmd;                    //让适配器执行SELECT命令
                DataSet checkData = new DataSet();                 //实例化结果数据集
                int n = check.Fill(checkData, "员工表");         //将结果放入数据适配器，返回元祖个数
                if (n != 0)
                {
                    MessageBox.Show("登录名已存在");
                    userId.Text = ""; userPw.Text = "";
                    nickName.Text = "";
                }

                //确认密码
                if (ensurePw.Text != userPw.Text)
                {
                    ensurePw.Text = "";
                }

                //插入数据SQL  逻辑
                string s1 = "insert into 员工表(员工工号,登录密码,登录名,员工姓名,手机号,家庭住址) values ('" + staffId.Text + "','" + userPw.Text + "','" + userId.Text + "','"
                    + nickName.Text + "','" + PhoneNo.Text + "','" + address.Text + "')";                            //编写SQL命令
                SqlCommand mycom = new SqlCommand(s1, mycon);          //初始化命令
                mycom.ExecuteNonQuery();             //执行语句
                MessageBox.Show("注册成功");
                mycon.Close();                       //关闭连接
                mycom = null;
                mycon.Dispose();                     //释放对象
                this.Close();
            }

        }
    }
}
