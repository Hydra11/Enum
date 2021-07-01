
using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum WmsOutOrderMstrTypeEnum
    {
        /// <summary>
        /// 自建单组级
        /// </summary>
        groupByBack = 0
            ,
        /// <summary>
        /// 自建单Lpn级
        /// </summary>
        lpnByBack = 1
           ,
        /// <summary>
        /// 托盘任务
        /// </summary>
        Tary = 2
    }

    public enum WmsOutOrderMstrStatusEnum
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
