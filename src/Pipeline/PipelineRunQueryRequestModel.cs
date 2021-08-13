//-----------------------------------------------------------------------
// <copyright file="PipelineRunQueryRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System;
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class contains query request parameters for browsing pipeline configurations.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Pipeline.PipelineQueryRequestModel" />
    public class PipelineRunQueryRequestModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>The states.</value>
        public List<PipelineRunState> States { get; set; } = new List<PipelineRunState>();

        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the pipeline identifier.
        /// </summary>
        /// <value>The pipeline identifier.</value>
        public Guid PipelineId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the requested date.
        /// </summary>
        /// <value>The requested date.</value>
        public DateTime RequestDate { get; set; }
    }
}