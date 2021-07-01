using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum TaryTaskStatusEnum
    {
        created = 0
            ,
        /// <summary>
        /// 等待
        /// </summary>
        wait = 1
            ,
            doing = 2
            ,
            finish = 3
            ,
            end = 4
    }
}
