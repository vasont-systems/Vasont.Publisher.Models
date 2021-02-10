//-----------------------------------------------------------------------
// <copyright file="PipelineQueryRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class contains query request parameters for browsing pipeline configurations.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Pipeline.PipelineQueryRequestModel" />
    public class PipelineQueryRequestModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; set; }
    }
}