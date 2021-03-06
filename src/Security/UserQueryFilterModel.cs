﻿//-----------------------------------------------------------------------
// <copyright file="UserQueryFilterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    using Vasont.Publisher.Models.Queries;

    /// <summary>
    /// This class defines the administration user query filter model.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Queries.PaginatedQueryRequestModel" />
    public class UserQueryFilterModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; set; }
    }
}