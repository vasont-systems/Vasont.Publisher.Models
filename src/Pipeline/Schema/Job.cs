//-----------------------------------------------------------------------
// <copyright file="Job.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a job in the pipeline configuration.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// Gets or sets the unique job identifier.
        /// </summary>
        /// <value>The job identifier.</value>
        public Guid JobId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the job name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = SchemaDefaults.DefaultJobName;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of dependency names required for this job.
        /// </summary>
        public List<string> Dependencies { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the job strategy configuration.
        /// </summary>
        [Required]
        public JobStrategy Strategy { get; set; } = new JobStrategy();

        /// <summary>
        /// Gets or sets a value indicating whether the job will continue if one or more tasks return an error result.
        /// </summary>
        public bool ContinueOnError { get; set; } = true;

        /// <summary>
        /// Gets or sets the timeout in minutes that the job will wait before the task runner stops the job for failing to complete.
        /// </summary>
        public uint JobTimeoutInMinutes { get; set; } = SchemaDefaults.DefaultJobTimeoutMinutes;

        /// <summary>
        /// Gets or sets the job pool configuration.
        /// </summary>
        [Required]
        public JobPoolConfiguration Pool { get; set; } = new JobPoolConfiguration();

        /// <summary>
        /// Gets or sets the job workspace configuration.
        /// </summary>
        public JobWorkspaceConfiguration Workspace { get; set; } = new JobWorkspaceConfiguration();

        /// <summary>
        /// Gets or sets a list of job tasks to execute within the configuration.
        /// </summary>
        [Required]
        public List<JobTask> Tasks { get; set; } = new List<JobTask>();

        /// <summary>
        /// Gets or sets a value indicating whether the job is enabled within the configuration.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}