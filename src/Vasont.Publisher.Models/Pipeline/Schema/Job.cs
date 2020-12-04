//-----------------------------------------------------------------------
// <copyright file="Job.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a job in the pipeline configuration.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// Gets or sets the job name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string DisplayName { get; set; }

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
        /// Gets or sets a condition to be met in order for the job to execute.
        /// </summary>
        [MaxLength(100)]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the job strategy configuration.
        /// </summary>
        public JobStrategy Strategy = new JobStrategy();

        /// <summary>
        /// Gets or sets a value indicating whether the job will continue if one or more tasks return an error result.
        /// </summary>
        public bool ContinueOnError { get; set; } = true;

        /// <summary>
        /// Gets or sets the timeout in minutes that the job will wait before the task runner stops the job for failing to complete.
        /// </summary>
        public uint TimeoutInMinutes { get; set; } = 10;

        /// <summary>
        /// Gets or sets the timeout in minutes that the job will wait before cancelling the job.
        /// </summary>
        public uint CancelTimeoutInMinutes { get; set; } = 15;

        /// <summary>
        /// Gets or sets the job pool configuration.
        /// </summary>
        public JobPoolConfiguration Pool { get; set; } = new JobPoolConfiguration();

        /// <summary>
        /// Gets or sets the job workspace configuration.
        /// </summary>
        public JobWorkspaceConfiguration Workspace = new JobWorkspaceConfiguration();

        /// <summary>
        /// Gets or sets a list of job steps to execute within the configuration.
        /// </summary>
        public List<JobStep> Steps { get; set; } = new List<JobStep>();

        /// <summary>
        /// Gets or sets a value indicating whether the job is enabled within the configuration.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}