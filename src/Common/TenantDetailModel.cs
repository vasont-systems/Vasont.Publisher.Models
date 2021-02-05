//-----------------------------------------------------------------------
// <copyright file="TenantDetailModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Common
{
    /// <summary>
    /// This class represents the basic tenant information needed for the web application.
    /// </summary>
    public class TenantDetailModel
    {
        /// <summary>
        /// Gets or sets the domain key.
        /// </summary>
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the support information about the Tenant.
        /// </summary>
        public string SupportInfo { get; set; }

        /// <summary>
        /// Gets or sets the support contact e-mail address for the Tenant.
        /// </summary>
        public string SupportEmail { get; set; }

        /// <summary>
        /// Gets or sets the default language to use for the tenant application.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or sets the server's session timeout in minutes.
        /// </summary>
        public int SessionTimeout { get; set; }

        /// <summary>
        /// Gets or sets the copyright of the tenant application.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the version of the tenant application.
        /// </summary>
        public string Version { get; set; }
    }
}