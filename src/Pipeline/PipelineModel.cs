//-----------------------------------------------------------------------
// <copyright file="PipelineModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Vasont.Publisher.Models.Security;

    /// <summary>
    /// This class represents a pipeline configuration model within the application.
    /// </summary>
    public class PipelineModel
    {
        /// <summary>
        /// Gets or sets the pipeline identifier.
        /// </summary>
        /// <value>The pipeline identifier.</value>
        public Guid PipelineId { get; set; }

        /// <summary>
        /// Gets or sets the name/title of the configuration.
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description details of the configuration.
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the status badges of the server are enabled for this configuration.
        /// </summary>
        public bool StatusBadgesEnabled { get; set; }

        /// <summary>
        /// Gets or sets the pipeline source.
        /// </summary>
        /// <value>The pipeline source.</value>
        [MaxLength(200)]
        public string PipelineSource { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PipelineModel" /> is default.
        /// </summary>
        /// <value><c>true</c> if default; otherwise, <c>false</c>.</value>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [system locked].
        /// </summary>
        /// <value><c>true</c> if [system locked]; otherwise, <c>false</c>.</value>
        public bool SystemLocked { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by user identifier.
        /// </summary>
        /// <value>The created by user identifier.</value>
        [StringLength(450)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>The updated date.</value>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated by user identifier.
        /// </summary>
        /// <value>The updated by user identifier.</value>
        [StringLength(450)]
        public string UpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the updated by user.
        /// </summary>
        /// <value>The updated by user.</value>
        public MicroUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created by user.
        /// </summary>
        /// <value>The created by user.</value>
        public MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pipeline" /> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}