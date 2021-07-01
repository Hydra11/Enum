using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum BinStatusEnum
    {
        /// <summary>
        /// 空库位
        /// </summary>
        empty = 1
            ,
        /// <summary>
        /// 锁定
        /// </summary>
        locking = 2
            ,
        /// <summary>
        /// 占用
        /// </summary>
        occupy = 3
            ,
        /// <summary>
        /// 不可用
        /// </summary>
        enable = 4
            ,
        /// <summary>
        /// 不正常
        /// </summary>
        abnormal = 5
            ,

        /// <summary>
        /// 缓存位
        /// </summary>
        cache = 6

    }
}
