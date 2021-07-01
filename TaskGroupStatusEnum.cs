using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum TaskGroupStatusEnum
    {
        /// <summary>
        /// 创建
        /// </summary>
        created = 1
            ,
        /// <summary>
        /// 等待
        /// </summary>
        wait = 2
            ,
        /// <summary>
        /// 工作中
        /// </summary>
        doing = 3
            ,
        /// <summary>
        /// 完成
        /// </summary>
        finish = 4
            ,
        /// <summary>
        /// 结束
        /// </summary>
        end = 5
            
    }
}
