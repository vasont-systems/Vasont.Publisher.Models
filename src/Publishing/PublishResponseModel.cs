//-----------------------------------------------------------------------
// <copyright file="PublishResponseModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Publish
{
    using System;
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Pipeline;
    using Vasont.Publisher.Models.Pipeline.Schema;
    using Vasont.Publisher.Models.Security;

    /// <summary>
    /// This class returns the response for the publication request initiation.
    /// </summary>
    public class PublishResponseModel
    {
        /// <summary>
        /// Gets or sets the pipeline identifier.
        /// </summary>
        /// <value>The pipeline identifier.</value>
        public Guid PipelineId { get; set; }

        /// <summary>
        /// Gets or sets the pipeline run identifier.
        /// </summary>
        /// <value>The pipeline run identifier.</value>
        public Guid PipelineRunId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PublishResponseModel" /> is initiated.
        /// </summary>
        /// <value><c>true</c> if initiated; otherwise, <c>false</c>.</value>
        public bool Initiated { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public PipelineRunState State { get; set; }

        /// <summary>
        /// Gets or sets the initiation errors.
        /// </summary>
        /// <value>The initiation errors.</value>
        public List<string> Errors { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        /// <value>The warnings.</value>
        public List<string> Warnings { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>The source.</value>
        public PipelineSourceBase Source { get; set; }
    }
}