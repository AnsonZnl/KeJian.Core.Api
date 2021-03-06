﻿using System;
using KeJian.Core.Library.EntityFrameworkCore;

namespace KeJian.Core.Domain.Models
{
    public class Message : Entity
    {
        /// <summary>
        ///     true 留言板 false 需求投递
        /// </summary>
        public bool IsMess { get; set; }

        /// <summary>
        ///     姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        ///     邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     留言内容/需求内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     留言时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}