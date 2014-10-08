﻿/**
* author:xishuai
* address:https://www.github.com/yuezhongxin/MessageManager
**/


namespace CNBlogsMsg.Domain
{
    /// <summary>
    /// 表示继承于该接口的类型是领域实体类。
    /// </summary>
    public interface IEntity
    {
        #region Properties
        /// <summary>
        /// 获取当前领域实体类的全局唯一标识。
        /// </summary>
        int ID { get; }
        #endregion
    }
}