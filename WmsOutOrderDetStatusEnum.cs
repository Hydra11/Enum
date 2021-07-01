using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum WmsOutOrderDetStatusEnum
    {
        /// <summary>
        /// 创建
        /// </summary>
        Created = 0,
        /// <summary>
        /// 工作中
        /// </summary>
        Doing = 1,
        /// <summary>
        /// 完成
        /// </summary>
        Finish = 2,
        /// <summary>
        /// 异常
        /// </summary>
        Error = -1,
        /// <summary>
        /// 结束
        /// </summary>
        End = 4
    }
}
