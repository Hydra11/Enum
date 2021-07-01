using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum TaryTaskTypeEnum
    {
        /// <summary>
        /// 按扫码后屏幕上的按钮触发 lpn的信息放到托盘表中
        /// 上架
        /// </summary>
        input = 0
            ,
        /// <summary>
        /// 下架
        /// </summary>
        output = 1
            ,
        /// <summary>
        /// 入托盘
        /// </summary>
        inTray = 5
            ,
        /// <summary>
        /// 出托盘
        /// </summary>
        outTray = 6
            ,
        //    ,
        /// <summary>
        /// 移动请求
        /// </summary>
        move = 4

    }
}
