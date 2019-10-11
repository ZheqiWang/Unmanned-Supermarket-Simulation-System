using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;

namespace 无人超市PC管理端
{
    public class Recommand
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            ArrayList D = GetEventsFromDB();//事务数据集  
            ArrayList I = GetItems1FromDB();//初始项目集合  
            float s = 0.5f;//支持度  

            List<ItemSet> L = new List<ItemSet>();//所有频繁项集  
            L = Apriori(D, I, s);

            for (int i = 0; i < L.Count; i++)
            {
                Console.WriteLine(L[i].Items);
                Console.WriteLine(L[i].Sup);
            }
            Console.WriteLine(DateTime.Now);
            Console.Read();
        }*/

        #region-----用Apriori算法进行迭代-----  
        /// <summary>  
        /// 用Apriori算法进行迭代  
        /// </summary>  
        /// <param name="D"></param>  
        /// <param name="I"></param>  
        /// <param name="sup"></param>  
        /// <returns></returns>  
        static List<ItemSet> Apriori(ArrayList D, ArrayList I, float sup)
        {
            List<ItemSet> L = new List<ItemSet>();//所有频繁项集  
            if (I.Count == 0) return L;
            else
            {
                int[] Icount = new int[I.Count];//初始项集计数器,初始化为0  
                ArrayList Ifrequent = new ArrayList();//初始项集中的频繁项集  

                //遍历事务数据集，对项集进行计数  
                Regex r = new Regex(",");
                for (int i = 0; i < D.Count; i++)
                {
                    string[] subD = r.Split(D[i].ToString());
                    for (int j = 0; j < I.Count; j++)
                    {
                        string[] subI = r.Split(I[j].ToString());
                        bool subIInsubD = true;
                        for (int m = 0; m < subI.Length; m++)
                        {
                            bool subImInsubD = false;
                            for (int n = 0; n < subD.Length; n++)
                                if (subI[m] == subD[n])
                                {
                                    subImInsubD = true;
                                    continue;
                                }
                            if (subImInsubD == false) subIInsubD = false;
                        }
                        if (subIInsubD == true) Icount[j]++;
                    }
                }

                //从初始项集中将支持度大于给定值的项转到L中  
                for (int i = 0; i < Icount.Length; i++)
                {
                    if (Icount[i] >= sup * D.Count)
                    {
                        Ifrequent.Add(I[i]);
                        ItemSet iSet = new ItemSet();
                        iSet.Items = I[i].ToString();
                        iSet.Sup = Icount[i];
                        L.Add(iSet);
                    }
                }

                I.Clear();
                I = AprioriGen(Ifrequent);

                L.AddRange(Apriori(D, I, sup));
                return L;
            }
        }
        #endregion-----用Apriori算法进行迭代-----  

        #region-------Apriori-gen生成候选项集---------  
        /// <summary>  
        /// Apriori-gen生成候选项集  
        /// </summary>  
        /// <param name="L"></param>  
        /// <returns></returns>  
        static ArrayList AprioriGen(ArrayList L)
        {
            ArrayList Lk = new ArrayList();
            Regex r = new Regex(",");
            for (int i = 0; i < L.Count; i++)
            {
                string[] subL1 = r.Split(L[i].ToString());
                for (int j = i + 1; j < L.Count; j++)
                {
                    string[] subL2 = r.Split(L[j].ToString());
                    //比较L中的两个项集将它们的并集暂存于temp中  
                    string temp = L[j].ToString();//存储两个项集的并集  
                    for (int m = 0; m < subL1.Length; m++)
                    {
                        bool subL1mInsubL2 = false;
                        for (int n = 0; n < subL2.Length; n++)
                        {
                            if (subL1[m] == subL2[n]) subL1mInsubL2 = true;
                        }
                        if (subL1mInsubL2 == false) temp = temp + "," + subL1[m];
                    }
                    //当temp包含的项为（L中项集的大小）+1并且所求候选项集中没有与temp一样的项集  
                    string[] subTemp = r.Split(temp);
                    if (subTemp.Length == subL1.Length + 1)
                    {
                        bool isExists = false;
                        for (int m = 0; m < Lk.Count; m++)
                        {
                            bool isContained = true;
                            for (int n = 0; n < subTemp.Length; n++)
                            {
                                if (!Lk[m].ToString().Contains(subTemp[n])) isContained = false;
                            }
                            if (isContained == true) isExists = true;
                        }
                        if (isExists == false) Lk.Add(temp);
                    }

                }
            }
            return Lk;
        }
        #endregion-------Apriori-gen生成候选项集---------  

        #region-------从数据库中得到候选一项集---------  
        /// <summary>  
        /// 从数据库中得到候选一项集  
        /// </summary>  
        /// <returns></returns>  
        static ArrayList GetItems1FromDB()
        {
            string commandString = "select distinct Model from dbo.vAssocSeqLineItems";
            DataSet ds = ExcuteDataSetByCommandString(commandString);

            int countItems1 = 0;
            countItems1 = ds.Tables[0].Rows.Count;

            ArrayList Items1 = new ArrayList();
            for (int i = 0; i < countItems1; i++)
                Items1.Add(ds.Tables[0].Rows[i]["Model"].ToString());
            return Items1;
        }
        #endregion-------从数据库中得到候选一项集---------  

        #region--------从数据库中获得事务集--------  
        /// <summary>  
        /// 从数据库中获得事务集  
        /// </summary>  
        /// <returns></returns>  
        static ArrayList GetEventsFromDB()
        {
            string commandString = "select count(OrderNumber) from vAssocSeqOrders";
            DataSet ds = ExcuteDataSetByCommandString(commandString);
            int countEvent = Convert.ToInt32(ds.Tables[0].Rows[0][0]);//获得事务的数目  


            ArrayList events = new ArrayList();
            string temp = null;

            string orderNumber = null;//暂存数据表中的OrderNumber,用来判断是否是同一个Order  
            //获得所有的事务  
            commandString = "select OrderNumber,Model from vAssocSeqLineItems";
            ds = ExcuteDataSetByCommandString(commandString);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (orderNumber == null)//第一次读数据  
                {
                    orderNumber = ds.Tables[0].Rows[i]["OrderNumber"].ToString();
                    temp = ds.Tables[0].Rows[i]["Model"].ToString();
                }
                else if (orderNumber == ds.Tables[0].Rows[i]["OrderNumber"].ToString())//读同一个Order中的数据  
                {
                    temp = temp + "," + ds.Tables[0].Rows[i]["Model"];
                }
                else//读到另一个Order中的数据  
                {
                    events.Add(temp);
                    orderNumber = ds.Tables[0].Rows[i]["OrderNumber"].ToString();
                    temp = ds.Tables[0].Rows[i]["Model"].ToString();
                }
                if (i == ds.Tables[0].Rows.Count - 1) events.Add(temp);

            }
            return events;
        }
        #endregion--------从数据库中获得事务集--------  

        #region-----由指定的commandString从数据库中获得数据------  
        /// <summary>  
        /// 由指定的commandString从数据库中获得数据  
        /// </summary>  
        /// <param name="commandString"></param>  
        /// <returns></returns>  
        static DataSet ExcuteDataSetByCommandString(string commandString)
        {
            //Data Source=DESKTOP-L2R88MH\\SQLEXPRESS.;Initial Catalog=无人超市;Integrated Security=True
            //server =.;database=AdventureWorksDW;trusted_connection=true
            string connectionString = "server =DESKTOP-L2R88MH\\SQLEXPRESS;database=无人超市;trusted_connection=true";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = commandString;

            DataSet ds = new DataSet();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
            sqlAdapter.Fill(ds);

            sqlCon.Close();
            return ds;
        }
        #endregion-----由指定的commandString从数据库中获得数据------  
    }
}
