﻿using System;
using System.Collections.Generic;

namespace Thunder.Web
{
    /// <summary>
    /// Interface of view model
    /// </summary>
    [Obsolete("No use this property, it will be removed in future")]
    public interface IModel
    {
        /// <summary>
        /// Get or set status of result
        /// </summary>
        ResultStatus Status { get; set; }

        /// <summary>
        /// Get or set messages collection
        /// </summary>
        IList<Message> Messages { get; set; }
    }
}