using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum StationTypeEnum
    {
        /// <summary>
        /// 入库点
        /// </summary>
        input = 1
            ,
        /// <summary>
        /// 出库点
        /// </summary>
        output = 2
            ,
        /// <summary>
        /// 碟盘机
        /// </summary>
        trayStacking = 3
            ,
        /// <summary>
        /// 拆盘机
        /// </summary>
        traySplit = 4
            ,
        /// <summary>
        /// 盘点口
        /// </summary>
        check = 5
            ,
        /// <summary>
        /// 异常口和盘点口
        /// </summary>
        errorAndCheck = 6
            ,
        /// <summary>
        /// 环线检测点
        /// </summary>
        loopCheck = 7
            ,
        /// <summary>
        /// 堆垛机取货点
        /// </summary>
        SRMPick = 8
            ,
        /// <summary>
        /// 堆垛机放货点
        /// </summary>
        SRMPut = 9
    }
}
