using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    /// <summary>
    /// 承载类型
    /// 0，空
    /// 1，单lpn
    /// 2，多lpn
    /// 3，托盘垛
    /// </summary>
    public enum TaryCarriedTypeEnum
    {
        empty = 0
            ,
        singleLpn = 1
            ,
        compound = 2
            ,
        tary = 3

    }
}
