using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EnforceUI
{
    public partial class Pager : UserControl
    {
        public delegate void CurrentPageChangedHandeler(object sender,CurrentPageChangedEventArgs e);
        public class CurrentPageChangedEventArgs : EventArgs
        {
            public int CurrentPageIndex
            {
                get;
                set;
            }

            public int PageSizeCount
            {
                get;
                set;
            }
        }

        public event CurrentPageChangedHandeler CurrentPageChangedEvent;
        protected virtual void CurrentPageChanged(object sender, CurrentPageChangedEventArgs e)
        {
            lock (this)
            {
                if (CurrentPageChangedEvent != null)
                    CurrentPageChangedEvent(this, e);
            }
        }

        public Pager()
        {
            InitializeComponent();
        }

        #region 属性
        private int pageSize = 50;
        /// <summary>
        /// 每页显示的记录数
        /// </summary>
        [Browsable(true)]
        public int PageSize
        {
            get 
            { 
                return pageSize;
            }

            set
            {
                if (value > 0)
                {
                    pageSize = value;
                }
                else
                    pageSize = 50;

                CalculatePageCount();
                ChangeControlState();
            }
        }

        private int currentPage = 1;
        /// <summary>
        /// 当前页
        /// </summary>
        [Browsable(false)]
        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                if (value > 0)
                    currentPage = value;
                else
                    currentPage = 1;

                textBoxCurrentpage.Text = currentPage.ToString();
                ChangeControlState();
                if (CurrentPageChangedEvent != null)
                    CurrentPageChangedEvent(this, new CurrentPageChangedEventArgs { CurrentPageIndex = CurrentPage, PageSizeCount = PageSize });
            }
        }

        private int totalCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        [Browsable(false)]
        public int TotalCount
        {
            get
            {
                return totalCount;
            }

            set
            {
                if (value >= 0)
                    totalCount = value;
                else
                    totalCount = 0;
                CalculatePageCount();
                ChangeControlState();
            }
        }

        private int pageCount = 0;
        /// <summary>
        /// 页数
        /// </summary>
        [Browsable(false)]
        public int PageCount
        {
            get
            {
                return pageCount;
            }

            private set
            {
                if (value >= 0)
                    pageCount = value;
                else
                    pageCount = 0;
            }
        }
        #endregion

        #region 方法

        private void CalculatePageCount()
        {
            if (TotalCount > 0)
                PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
            else
                PageCount = 0;
        }

        private void ChangeControlState()
        {
            if (CurrentPage == 1)
            {
                buttonBeforePage.Enabled = false;
                buttonPageTop.Enabled = false;
            }
            else
            {
                buttonBeforePage.Enabled = true;
                buttonPageTop.Enabled = true;
            }

            if (PageCount <= 1 || CurrentPage >= PageCount)
            {
                buttonNextPage.Enabled = false;
                buttonLastPage.Enabled = false;
            }
            else
            {
                buttonNextPage.Enabled = true;
                buttonLastPage.Enabled = true;
            }

            int showPageCount = PageCount > 1 ? PageCount : 1;
            labelMessage.Text = string.Format("总计 {0} 条记录，每页 {1} 条，共 {2} 页，第 {3} 页", TotalCount, PageSize, showPageCount,CurrentPage);
        }

        #endregion

        private void Pager_Load(object sender, EventArgs e)
        {
            comboBoxPageCount.Items.Clear();
            if (PageSize > 0)
            {
                int count = PageSize / 10;
                if (PageSize % 10 > 0)
                    count += 1;

                for (int i = 5; i >= 1; i--)
                    comboBoxPageCount.Items.Add(i * 10);

                if (comboBoxPageCount.Items.Count > 0)
                    comboBoxPageCount.SelectedIndex = 3;
            }

            textBoxCurrentpage.Text = CurrentPage.ToString();
            CalculatePageCount();
        }

        private void buttonPageTop_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
        }

        private void buttonBeforePage_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
                CurrentPage -= 1;
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            CurrentPage = PageCount;
        }

        private void comboBoxPageCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageSize = Convert.ToInt32(comboBoxPageCount.Text);
            if (CurrentPageChangedEvent != null)
                CurrentPageChangedEvent(this, new CurrentPageChangedEventArgs { CurrentPageIndex = CurrentPage, PageSizeCount = PageSize });
        }
    }
}
