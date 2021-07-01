using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.DBModel.Enum
{
    public enum ApplyListStatusEnum
    {
        /// <summary>
        /// 创建
        /// </summary>
        created = 1
            ,
        /// <summary>
        /// 执行中
        /// </summary>
        doing = 2
            ,
        /// <summary>
        /// 下发了
        /// </summary>
        send = 3
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

    /// <summary>
    /// 需要添加盘点出库和盘点入库
    /// 
    /// </summary>
    public enum ApplyListTypeEnum
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
        /// 移动请求
        /// </summary>
        move = 4
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
        /// <summary>
        ///             库前申请库位
        /// </summary>
        applyBinUpTOSRM = 90
            ,
        /// <summary>
        /// 响应库位前申请
        /// </summary>
        binUpTOSRMTask = 91
            ,
        /// <summary>
        /// 环线出库任务完成标记（此时出库的任务不是完成，托盘出库完成是真的完成）
        /// </summary>
        taskGroupLoopFinish = 20
            ,
        /// <summary>
        /// 从系统离开
        /// </summary>
        taskGroupPickUp = 21
            ,
        /// <summary>
        /// 申请取消
        /// </summary>
        applyCancelTask = 22
            ,
        /// <summary>
        /// 盘点下架任务执行和搜索
        /// </summary>
        checkListOutTask = 23
            ,
        /// <summary>
        /// 盘点下架任务执行和搜索
        /// </summary>
        checkListInTask = 24
            ,
        /// <summary>
        /// 盘点手动修改任务状态
        /// </summary>
        checkListChangeStatus = 25
            ,
        /// <summary>
        /// part修改info
        /// </summary>
        partChangeInfo=30
            ,
        /// <summary>
        /// 清空内存重新从表中加载对象
        /// </summary>
        clearMemory = 99
            ,
        /// <summary>
        /// 移库操作申请
        /// </summary>
        operMoveTask = 98
            ,
        /// <summary>
        /// 关闭巷道涉及到托盘的操作
        /// </summary>
        closeAreaForTaries = 97
            ,
        /// <summary>
        /// 库存同步
        /// </summary>
        inventorySynchronization = 80


    }

    public enum ApplyListLevelEnum
    {
        /// <summary>
        /// 优先的
        /// 入库前任务
        /// getnewbin业务
        /// </summary>
        prior = 25
            ,
        /// <summary>
        /// 正常等级
        /// 入库申请
        /// 出库申请
        /// 盘点申请等
        /// </summary>
        normal = 50
            ,
        /// <summary>
        /// 滞后的
        /// </summary>
        lag = 75
    }

    public enum ApplyListRepeatEnum
    { 
    
    }

}
