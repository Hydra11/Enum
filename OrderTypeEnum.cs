using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum OrderTypeEnum
    {
        /// <summary>
        /// 入库
        /// </summary>
        input = 1
            ,
        /// <summary>
        /// 出库
        /// </summary>
        output = 2
            ,
        /// <summary>
        /// 盘点
        /// </summary>
        check = 3
            ,
        /// <summary>
        /// 移动
        /// </summary>
        move = 4
            

        
    }
}
