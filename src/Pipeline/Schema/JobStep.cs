//-----------------------------------------------------------------------
// <copyright file="JobStep.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
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
    /// Contains an enumerated list of job step plugins used for step execution.
    /// </summary>
    public enum JobStepPlugin
    {
        /// <summary>
        /// The job step will execute a command line call.
        /// </summary>
        Command
    }

    /// <summary>
    /// Gets or sets the job step configuration for a pipeline job execution.
    /// </summary>
    public class JobStep
    {
        /// <summary>
        /// Gets or sets the job step internal name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job step display name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string DisplayName { get; set; }

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
        /// Gets or sets the job step plugin to execute within the job.
        /// </summary>
        public JobStepPlugin Plugin { get; set; } = JobStepPlugin.Command;

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