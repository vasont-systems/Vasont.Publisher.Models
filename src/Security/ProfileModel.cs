//-----------------------------------------------------------------------
// <copyright file="ProfileModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Common;

    /// <summary>
    /// This class loads the initial profile details for the user and returns available tenants.
    /// </summary>
    public class ProfileModel
    {
        /// <summary>
        /// Gets or sets the copyright of the tenant application.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the version of the tenant application.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the default language to use for the tenant application.
        /// </summary>
        public string DefaultLanguage { get; set; } = "en-US";

        /// <summary>
        /// Gets or sets the server's session timeout in minutes.
        /// </summary>
        public int SessionTimeout { get; set; } = 20;

        /// <summary>
        /// Gets or sets the tenants.
        /// </summary>
        /// <value>The tenants.</value>
        public List<MicroTenantModel> Tenants { get; set; } = new List<MicroTenantModel>();
    }
}