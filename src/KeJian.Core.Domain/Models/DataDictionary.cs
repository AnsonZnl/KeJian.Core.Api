﻿using KeJian.Core.Library.EntityFrameworkCore;

namespace KeJian.Core.Domain.Models
{
    public class DataDictionary : Entity
    {
        /// <summary>
        ///     Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        ///     值
        /// </summary>
        public string Content { get; set; }
    }
}