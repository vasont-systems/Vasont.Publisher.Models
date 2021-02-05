//-----------------------------------------------------------------------
// <copyright file="RoleQueryFilterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Queries
{
    /// <summary>
    /// This class defines the administration role query filter model.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Common.PaginatedQueryRequestModel" />
    public class RoleQueryFilterModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; set; }
    }
}