﻿//-----------------------------------------------------------------------
// <copyright file="MinimalUserModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    using System;

    /// <summary>
    /// This class represents a user that is assigned to a role. It is a stripped down version of the user and returns only essential information related to the
    /// user for role associations.
    /// </summary>
    public class MinimalUserModel : MicroUserModel
    {
        /// <summary>
        /// Gets or sets the user's desired language.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the user's time zone.
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets a value indicating whether the user is locked.
        /// </summary>
        public bool Locked => this.LockExpirationDate.HasValue;

        /// <summary>
        /// Gets or sets the lock expiration date.
        /// </summary>
        public DateTime? LockExpirationDate { get; set; }
    }
}