using System;
using System.Collections.Generic;
using System.Text;

namespace SOA.ORM
{
    public class EList<T>
    {
        public int TotalCount
        {
            get;
            set;
        }

        private List<T> items = new List<T>();
        /// <summary>
        /// 每页显示的记录集
        /// </summary>
        public List<T> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
    }
}
