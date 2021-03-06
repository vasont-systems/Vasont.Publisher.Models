﻿//-----------------------------------------------------------------------
// <copyright file="NotificationStoreQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Notifications
{
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class represents a notification store query model used in paging interfaces for notification messages.
    /// </summary>
    public class NotificationStoreQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a string used for filtering notification results.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a list of states to filter by. An empty list will not filter by state.
        /// </summary>
        public List<NotificationState> State { get; set; } = new List<NotificationState>();

        /// <summary>
        /// Gets or sets a list of alerts to filter by. An empty list will not filter by alert.
        /// </summary>
        public List<NotificationMessageAlertStatus> Alert { get; set; } = new List<NotificationMessageAlertStatus>();
    }
}