using System;
using System.Collections.Generic;

using System.Text;

namespace EnforceUI
{
    public interface ITableControl
    {
        /// <summary>
        /// 返回控件中的文本值
        /// </summary>
        /// <returns></returns>
        string ControlText
        {
            get;
            set;
        }
        /// <summary>
        /// 获取控件名称用于生成
        /// </summary>
        /// <returns></returns>
        string ControlName
        {
            get;
        }
    }
}
