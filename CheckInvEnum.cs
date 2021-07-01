using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum CheckInvMstrTypeEnum
    {
        /// <summary>
        /// 暗盘
        /// </summary>
        BlindStocktake = 0,
        /// <summary>
        /// 明盘
        /// </summary>
        InformedStocktake = 1
            ,
        /// <summary>
        /// 完成
        /// </summary>
        Finish =2
    }

    /// <summary>
    /// 盘点单状态
    /// </summary>
    public enum CheckInvMstrStatusEnum
    { 
        Created = 0
            ,
        Doing = 1
            ,
        Finish = 2
            ,
        /// <summary>
        /// 完结不是结束
        /// </summary>
        End = 3
            
    }

    /// <summary>
    /// 盘点单是否需要弹出显示的一个标志位
    /// </summary>
    public enum CheckInvMstrConfirmationStatusEnum
    {
        Created = 0
            ,
        Scan = 1
            ,
        Finish = 2
    }

    /// <summary>
    /// 每个SKU的量
    /// </summary>
    public enum CheckInvDetBySkuListStatusEnum
    {
        Created = 0
            ,
        OutBook = 1
            ,
        OutDoing = 2
            ,
        OutFinish = 3
            ,
        InDoing = 4
            ,
        Finish = 5
            ,
        End = 6
           
    }
}
