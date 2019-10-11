using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 无人超市PC管理端
{
    class ItemSet
    {

        private string items;
        private int sup;
        public string Items
        {
            get { return items; }
            set { items = value; }
        }
        public int Sup
        {
            get { return sup; }
            set { sup = value; }
        }
        public ItemSet()//对象初始化  
        {
            items = null;
            sup = 0;
        }
    }
}
