//-----------------------------------------------------------------------
// <copyright file="PaginatedQueryResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Queries
{
    using System.Collections.Generic;

    /// <summary>
    /// This class defines the basic query result model for the paginated query.
    /// </summary>
    /// <typeparam name="TQueryModel">The type of the query result.</typeparam>
    public class PaginatedQueryResultModel<TQueryModel>
        where TQueryModel : class
    {
        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        /// <value>The total records.</value>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the results of the model query.
        /// </summary>
        /// <value>The results.</value>
        public List<TQueryModel> Results { get; set; }
    }
}