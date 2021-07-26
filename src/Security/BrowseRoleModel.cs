//-----------------------------------------------------------------------
// <copyright file="BrowseRoleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    using System;

    /// <summary>
    /// This class represents a role in the browse API endpoint.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Security.MinimalRoleModel" />
    public class BrowseRoleModel : MinimalRoleModel
    {
        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record last updated date time.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user count.
        /// </summary>
        /// <value>The user count.</value>
        public int UserCount { get; set; }
    }
}