using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum ShelfStatusEnum
    {
        /// <summary>
        /// 空货架
        /// </summary>
        empty = 0,
        /// <summary>
        /// 锁定货架
        /// 有任务在执行的货架
        /// </summary>
        locked = 1,
        /// <summary>
        /// 不可用货架
        /// </summary>
        enable = 2,
        /// <summary>
        /// 缓存货架
        /// </summary>
        cache = 3,
        /// <summary>
        /// 满货架
        /// </summary>
        full = 4,
        /// <summary>
        /// 没满货架
        /// </summary>
        unFull = 5,
        /// <summary>
        /// 不正常货架
        /// </summary>
        abnormal = 6



    }
}
