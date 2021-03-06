﻿using System;
using KeJian.Core.Library.EntityFrameworkCore;

namespace KeJian.Core.Domain.Models
{
    public class Study : Entity
    {
        /// <summary>
        ///     学习标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     学习内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     添加时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}