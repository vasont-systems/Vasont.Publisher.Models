//-----------------------------------------------------------------------
// <copyright file="AuditLogQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Logging
{
    using System;
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class contains parameters passed to the query for filtering.
    /// </summary>
    public class AuditLogQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text of the paged query.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>The events.</value>
        public List<AuditEvent> Events { get; set; } = new List<AuditEvent>();

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>The results.</value>
        public List<AuditResult> Results { get; set; } = new List<AuditResult>();

        /// <summary>
        /// Gets or sets the start date of the paged query.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the paged query.
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}