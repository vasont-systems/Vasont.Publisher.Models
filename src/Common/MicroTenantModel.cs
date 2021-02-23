//-----------------------------------------------------------------------
// <copyright file="MicroTenantModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Common
{
    /// <summary>
    /// This class contains the absolute minimum information for the application tenant details.
    /// </summary>
    public class MicroTenantModel
    {
        /// <summary>
        /// Gets or sets the tenant key.
        /// </summary>
        public string Key { get; set; }

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
    }
}