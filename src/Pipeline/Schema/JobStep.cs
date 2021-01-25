//-----------------------------------------------------------------------
// <copyright file="JobStep.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of job step types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobStepType
    {
        /// <summary>
        /// Step is used for input compilation.
        /// </summary>
        Build,

        /// <summary>
        /// Step is used for input transformation.
        /// </summary>
        Transform,

        /// <summary>
        /// Step is used for output publishing.
        /// </summary>
        Publish
    }

    /// <summary>
    /// Gets or sets the job step configuration for a pipeline job execution.
    /// </summary>
    public class JobStep
    {
        public Guid JobStepId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the job step internal name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = SchemaDefaults.DefaultJobStepName;

        /// <summary>
        /// Gets or sets the job step description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the job step type.
        /// </summary>
        public JobStepType Type { get; set; } = JobStepType.Build;

        /// <summary>
        /// Gets or sets the job step plugin command to execute within the job.
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the step is enabled.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the job step output variables used within the overall job execution.
        /// </summary>
        public List<JobStepOutputVariable> OutputVariables { get; set; } = new List<JobStepOutputVariable>();

        /// <summary>
        /// Gets or sets the custom configuration parameters for the selected step plugin.
        /// </summary>
        public Dictionary<string, string> Configuration { get; set; } = new Dictionary<string, string>();
    }
}