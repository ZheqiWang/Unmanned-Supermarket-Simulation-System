﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace 无人超市PC管理端
{
    public partial class OffSelf : Form
    {
        //数值串转化为十六进制字符串
        private byte[] StrToByetArray(string hexValues)
        {
            string[] hexValuesSplit = hexValues.Split(' ');
            byte[] retBytes = new byte[hexValuesSplit.Length];

            for (int nLoop = 0; nLoop < retBytes.Length; nLoop++)
            {
                retBytes[nLoop] = Convert.ToByte(hexValuesSplit[nLoop], 16);
            }

            return retBytes;
        }
        //字符数组转化为十六进制数组
        private byte[] StrToByetArray(string[] hexValues, int nLen)
        {
            byte[] retBytes = new byte[nLen];

            for (int nLoop = 0; nLoop < retBytes.Length; nLoop++)
            {
                retBytes[nLoop] = Convert.ToByte(hexValues[nLoop], 16);
            }

            return retBytes;
        }
        //十六进制字符串转化为数值串
        private string ByteArrayToStr(byte[] byteArray, bool bNeedFormat, int nStart, int nEnd)
        {
            //nEnd传递为0，转换到数组最后；

            string strReturn = "";

            if (bNeedFormat)
            {
                strReturn = "\r\nHEX RESULT:";
            }

            int nLoop = 0;
            nLoop += nStart;
            if (nEnd == 0)
            {
                nEnd = byteArray.GetLength(0);
            }
            else if (nEnd > byteArray.GetLength(0))
            {
                nEnd = byteArray.GetLength(0);
            }


            for (; nLoop < nEnd; nLoop++)
            {
                string strHex = "";

                if (bNeedFormat)
                {
                    if (nLoop % 16 != 0)
                    {
                        strHex = string.Format(" {0:X2}", byteArray[nLoop]);
                    }
                    else
                    {
                        strHex = string.Format("\r\n  {0:X2}...{1:X2}", nLoop / 16, byteArray[nLoop]);
                    }
                }
                else
                {
                    strHex = string.Format(" {0:X2}", byteArray[nLoop]);
                }

                strReturn += strHex;
            }

            return strReturn;
        }
        //转换错误代码
        private string FormatErrorCode(byte[] byteArray)
        {
            string strErrorCode = "";
            switch (byteArray[0])
            {
                case 0x80:
                    strErrorCode = "Success";
                    break;

                case 0x81:
                    strErrorCode = "Parameter Error";
                    break;

                case 0x82:
                    strErrorCode = "communication TimeOut";
                    break;

                case 0x83:
                    strErrorCode = "Couldn't Find Card ";
                    break;

                default:
                    strErrorCode = "Commond Error";
                    break;
            }

            return strErrorCode;
        }
        //字符截取，即不区分输入字符是否输入空格，均以两个字符处理为一个串
        private string[] strCutLength(string str, int iLength)
        {
            string[] reslut = null;
            if (!string.IsNullOrEmpty(str))
            {
                int iTemp = 0;
                string strTemp = null;
                System.Collections.ArrayList strArr = new System.Collections.ArrayList();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        iTemp++;
                        strTemp += str.Substring(i, 1);
                    }

                    //校验截取的字符是否在A~F、0~9区间
                    System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^(([A-F])*(\d)*)$");
                    if (!reg.IsMatch(strTemp))
                    {
                        return reslut;
                    }

                    if ((iTemp == iLength) || (i == str.Length - 1 && !string.IsNullOrEmpty(strTemp)))
                    {
                        strArr.Add(strTemp);
                        iTemp = 0;
                        strTemp = null;
                    }
                }
                if (strArr.Count > 0)
                {
                    reslut = new string[strArr.Count];
                    strArr.CopyTo(reslut);
                }
            }
            return reslut;
        }
        //输出日志文本
        private void WriteLog(string strText, int nRet, string strErrcode)
        {
            if (nRet != 0)
            {

                textResponse.Text += System.DateTime.Now.ToLocalTime().ToString() + " " + strText + "\r\n" + strErrcode + "\r\n";
            }
            else
            {
                textResponse.Text += System.DateTime.Now.ToLocalTime().ToString() + " " + strText + " " + "\r\n";
            }

            textResponse.Select(textResponse.TextLength, 0);//光标定位到文本最后
            textResponse.ScrollToCaret();//滚动到光标处
        }

        //转换卡号专用
        private byte[] convertSNR(string str, int keyN)
        {
            string regex = "[^a-fA-F0-9]";
            string tmpJudge = Regex.Replace(str, regex, "");

            //长度不对，直接退回错误
            if (tmpJudge.Length != 12) return null;

            string[] tmpResult = Regex.Split(str, regex);
            byte[] result = new byte[keyN];
            int i = 0;
            foreach (string tmp in tmpResult)
            {
                result[i] = Convert.ToByte(tmp, 16);
                i++;
            }
            return result;
        }

        //数据输入判断函数2个
        private string formatStr(string str, int num_blk)
        {

            string tmp = Regex.Replace(str, "[^a-fA-F0-9]", "");
            //长度不对直接报错
            //num_blk==-1指示不用检查位数
            if (num_blk == -1) return tmp;
            //num_blk==其它负数，为-1/num_blk
            if (num_blk < -1)
            {
                if (tmp.Length != -16 / num_blk * 2) return null;
                else return tmp;
            }
            if (tmp.Length != 16 * num_blk * 2) return null;
            else return tmp;
        }
        private void convertStr(byte[] after, string before, int length)
        {
            for (int i = 0; i < length; i++)
            {
                after[i] = Convert.ToByte(before.Substring(2 * i, 2), 16);
            }
        }

        //显示结果
        private void showData(string text, byte[] data, int s, int e)
        {
            //非负转换
            for (int i = 0; i < e; i++)
            {
                if (data[s + i] < 0)
                    data[s + i] = Convert.ToByte(Convert.ToInt32(data[s + i]) + 256);
            }
            textResponse.Text += text;

            //for (int i = s; i < e; i++)
            //{
            //    textResponse.Text += data[i].ToString("X2")+" ";
            //}
            //textResponse.Text += "\r\n";

            for (int i = 0; i < e; i++)
            {
                textResponse.Text += data[s + i].ToString("X2") + " ";
            }
            textResponse.Text += "\r\n\r\n";

        }
        //显示命令执行结果
        private void showStatue(int Code)
        {
            string msg = "";
            switch (Code)
            {
                case 0x00:
                    msg = "命令执行成功 .....";
                    break;
                case 0x01:
                    msg = "命令操作失败 .....";
                    break;
                case 0x02:
                    msg = "地址校验错误 .....";
                    break;
                case 0x03:
                    msg = "找不到已选择的端口 .....";
                    break;
                case 0x04:
                    msg = "读写器返回超时 .....";
                    break;
                case 0x05:
                    msg = "数据包流水号不正确 .....";
                    break;
                case 0x07:
                    msg = "接收异常 .....";
                    break;
                case 0x0A:
                    msg = "参数值超出范围 .....";
                    break;
                case 0x80:
                    msg = "参数设置成功 .....";
                    break;
                case 0x81:
                    msg = "参数设置失败 .....";
                    break;
                case 0x82:
                    msg = "通讯超时.....";
                    break;
                case 0x83:
                    msg = "卡不存在.....";
                    break;
                case 0x84:
                    msg = "接收卡数据出错.....";
                    break;
                case 0x85:
                    msg = "未知的错误.....";
                    break;
                case 0x87:
                    msg = "输入参数或者输入命令格式错误.....";
                    break;
                case 0x89:
                    msg = "输入的指令代码不存在.....";
                    break;
                case 0x8A:
                    msg = "在对于卡块初始化命令中出现错误.....";
                    break;
                case 0x8B:
                    msg = "在防冲突过程中得到错误的序列号.....";
                    break;
                case 0x8C:
                    msg = "密码认证没通过.....";
                    break;
                case 0x8F:
                    msg = "读取器接收到未知命令.....";
                    break;
                case 0x90:
                    msg = "卡不支持这个命令.....";
                    break;
                case 0x91:
                    msg = "命令格式有错误.....";
                    break;
                case 0x92:
                    msg = "在命令的FLAG参数中，不支持OPTION 模式.....";
                    break;
                case 0x93:
                    msg = "要操作的BLOCK不存在.....";
                    break;
                case 0x94:
                    msg = "要操作的对象已经别锁定，不能进行修改.....";
                    break;
                case 0x95:
                    msg = "锁定操作不成功.....";
                    break;
                case 0x96:
                    msg = "写操作不成功.....";
                    break;
                default:
                    msg = "未知错误2.....";
                    break;
            }
            textResponse.Text += msg + "\r\n";
        }

        public OffSelf()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //14443A-MF需要的读写卡功能
        private void btn_MF_Read_Click(object sender, EventArgs e)
        {
            byte mode = (byte)0x01;
            byte blk_add = Convert.ToByte(readStart.Text, 16);
            byte num_blk = Convert.ToByte(readNum.Text, 16);

            byte[] snr = new byte[6];
            snr = convertSNR(readKey.Text, 6);
            if (snr == null)
            {
                MessageBox.Show("序列号无效！", "错误");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];

            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);

            showStatue(nRet);
            if (nRet != 0)
            {
                showStatue(buffer[0]);
            }
            else
            {
                showData("卡号：", snr, 0, 4);
                textBox1.Text = "";
                for (int i = 0; i < 4; i++)
                {
                    textBox1.Text += snr[0 + i].ToString("X2") + " ";
                }
            }
            //显示商品信息
            string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;";//设置连接字符串
            SqlConnection mycon = new SqlConnection(constr);  //实例化连接对象
            mycon.Open();

            string s2 = "select 商品名称 from 上架单 where RFID号='" + textBox1.Text + "'";        //编写SQL命令
            SqlCommand mycom1 = new SqlCommand(s2, mycon);          //初始化命令
            mycom1.ExecuteNonQuery();             //执行语句
            string Name = Convert.ToString(mycom1.ExecuteScalar());
            ComName.Text = Name;

            string s1 = "select 商品条码号 from 上架单 where RFID号='" + textBox1.Text + "'";        //编写SQL命令
            SqlCommand mycom = new SqlCommand(s1, mycon);          //初始化命令
            mycom.ExecuteNonQuery();             //执行语句
            string BarNum = Convert.ToString(mycom.ExecuteScalar());
            ComBar.Text = BarNum;
        }

        //下架操作
        private void button1_Click(object sender, EventArgs e)
        {
            string rfidno = textBox1.Text;//获得rfid序号

            string constr = "Integrated Security=SSPI;Initial Catalog=无人超市;Data Source=DESKTOP-L2R88MH\\SQLEXPRESS;";//设置连接字符串
            SqlConnection mycon = new SqlConnection(constr);  //实例化连接对象
            mycon.Open();

            string s2 = "select 商品名称 from 上架单 where RFID号='" + textBox1.Text + "'";        //编写SQL命令
            SqlCommand mycom1 = new SqlCommand(s2, mycon);          //初始化命令
            mycom1.ExecuteNonQuery();             //执行语句
            string Name = Convert.ToString(mycom1.ExecuteScalar());
            ComName.Text = Name;

            string s1 = "select 商品条码号 from 上架单 where RFID号='" + textBox1.Text + "'";        //编写SQL命令
            SqlCommand mycom = new SqlCommand(s1, mycon);          //初始化命令
            mycom.ExecuteNonQuery();             //执行语句
            string BarNum = Convert.ToString(mycom.ExecuteScalar());
            ComBar.Text = BarNum;

            if (Name == "")
            {
                textResponse.Text = "这个商品没有上架呀T_T";
            }
            else
            {
                string s3 = "insert into 下架单(RFID号,商品名,条码号,下架时间,下架原因,附加说明) values ('" +
                                rfidno + "','" + ComName.Text + "','" + ComBar.Text + "','" + OffSelfdate.Text + "','" + OffReason.Text + "','" + extraMsg.Text + "')";
                SqlCommand mycom2 = new SqlCommand(s3, mycon);          //初始化命令
                mycom2.ExecuteNonQuery();             //执行语句
                  
                //回收RFID标签，将上架单RFID号改为-1；
                string ss = "UPDATE 上架单 SET RFID号='" + Convert.ToString(-1) + "' WHERE RFID号='" + rfidno+ "'";        //编写SQL命令
                SqlCommand mycom6 = new SqlCommand(ss, mycon);          //初始化命令
                mycom6.ExecuteNonQuery();
                textResponse.Text = "下架成功！";
            }
        }
    }
}
