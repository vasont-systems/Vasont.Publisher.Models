//-----------------------------------------------------------------------
// <copyright file="NotificationStoreResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Notifications
{
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class represents the results of a notifications store query request.
    /// </summary>
    public class NotificationStoreResultModel : PaginatedQueryResultModel<NotificationStoreModel>
    {
        /// <summary>
        /// Gets or sets the total number of unread notification messages for the user.
        /// </summary>
        public long TotalUnreadCount { get; set; }
    }
}