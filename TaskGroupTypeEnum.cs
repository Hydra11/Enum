using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum TaskGroupTypeEnum
    {
        /// <summary>
        /// 入库
        /// </summary>
        InStore = 0,

        /// <summary>
        /// 出库
        /// </summary>
        OutStore = 1,

        /// <summary>
        /// 大件向小件方向出库
        /// </summary>
        OutStoreSmall = 2,

        /// <summary>
        /// 小件方向巷道入托盘
        /// </summary>
        InPalletSmall = 3,

        /// <summary>
        /// 移库
        /// </summary>
        TransferOStore = 4,

        /// <summary>
        /// 入托盘，（包括碟盘完到环穿对节点任务）
        /// </summary>
        InPallet = 5,

        /// <summary>
        /// 出托盘
        /// </summary>
        OutPallet = 6,

        /// <summary>
        /// 出库口转移托盘到入库口
        /// </summary>
        TransferPallet = 7,

        /// <summary>
        /// 拣选
        /// </summary>
        OrderPicking = 8,

        /// <summary>
        /// 扫码
        /// </summary>
        Scan = 9,

        /// <summary>
        /// 进口件通过RCS小车到达小件入口
        /// </summary>
        ImportToSmall = 10
           ,
        /// <summary>
        /// 大件库直接从入库口到出库口
        /// </summary>
        InToOutStore = 11,
        /// <summary>
        /// 机器人回库
        /// </summary>
        RobotBack = 12
           ,
        /// <summary>
        /// 大件库到小件等待位
        /// </summary>
        BigToSmallWait = 13

    }
}
