using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    /// <summary>
    /// 托盘的状态
    /// 0，创建
    /// 1，入库预定中
    /// 2，入库中
    /// 3，在位
    /// 4，出库预定
    /// 5，出库任务中
    /// 6，出库任务完成
    /// 7,   释放
    /// </summary>
    public enum TaryStatusEnum
    {
        /// <summary>
        /// 创建
        /// </summary>
        created = 0
            ,
        /// <summary>
        /// 入库预定
        /// </summary>
        inBooking = 1
            ,
        /// <summary>
        /// 入库中
        /// </summary>
        input = 2
            ,
        /// <summary>
        /// 在库位
        /// </summary>
        Retain = 3
            ,
        /// <summary>
        /// 移动任务状态处于这个状态的是移库状态，一定不会出库的状态
        /// </summary>
        Move = 4
            ,
        /// <summary>
        /// 出库预定
        /// </summary>
        outBooking = 5
            ,
        /// <summary>
        /// 出库中
        /// </summary>
        output = 6
            ,
        /// <summary>
        /// 出库任务完成
        /// </summary>
        end = 7
            ,
        /// <summary>
        /// 释放
        /// </summary>
        release = 8
    }


}
