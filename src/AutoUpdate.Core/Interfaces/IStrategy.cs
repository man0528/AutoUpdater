﻿using AutoUpdate.Core.Events;
using System;

namespace AutoUpdate.Core.Interfaces
{
    /// <summary>
    /// 更新策略
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// 执行策略
        /// </summary>
        void Excute();

        /// <summary>
        /// 创建策略
        /// </summary>
        /// <param name="file">策略需要根据文件进行处理</param>
        void Create(IFile file,Action<object,UpdateStatusEventArgs> eventAction);

    }
}
