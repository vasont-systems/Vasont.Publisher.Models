//-----------------------------------------------------------------------
// <copyright file="JobHistoryModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Server
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Vasont.Publisher.Models.Common;

    /// <summary>
    /// Contains a model of a job history record.
    /// </summary>
    public class JobHistoryModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the job history.
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// Gets or sets the unique domain key used for subscription lookup.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets the organization identity.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the requested Publish Configuration.
        /// </summary>
        [StringLength(50)]
        public string RequestName { get; set; }

        /// <summary>
        /// Gets or sets the type of the requested job.
        /// </summary>
        [StringLength(50)]
        public string RequestType { get; set; }

        /// <summary>
        /// Gets or sets the requested Dita-ot toolkit version.
        /// </summary>
        [StringLength(10)]
        public string ToolkitVersion { get; set; }

        /// <summary>
        /// Gets or sets the request date of a job.
        /// </summary>
        [Required]
        public DateTime RequestDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the name of the package to be processed.
        /// </summary>
        [StringLength(255)]
        [Required]
        public string Package { get; set; }

        /// <summary>
        /// Gets or sets the name of the deliverable file.
        /// </summary>
        [StringLength(255)]
        [Required]
        public string Deliverable { get; set; }

        /// <summary>
        /// Gets or sets the user navigation property.
        /// </summary>
        public UserModel User { get; set; }

        /// <summary>
        /// Gets or sets the organization navigation property.
        /// </summary>
        public OrganizationModel Organization { get; set; }
    }
}