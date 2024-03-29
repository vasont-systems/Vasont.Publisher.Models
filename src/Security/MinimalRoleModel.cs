﻿//-----------------------------------------------------------------------
// <copyright file="MinimalRoleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    /// <summary>
    /// This class represents a role associated with a user model. This contains the bare minimum properties for the application UI to display the associations.
    /// </summary>
    public class MinimalRoleModel
    {
        /// <summary>
        /// Gets or sets the role identity.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the role is a system role and cannot be deleted.
        /// </summary>
        public bool SystemRole { get; set; }
    }
}