//-----------------------------------------------------------------------
// <copyright file="PipelineRunModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Publisher.Models.Security;

    /// <summary>
    /// Contains an enumerated list of pipeline run states.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineRunState
    {
        /// <summary>
        /// The run is in an unknown state.
        /// </summary>
        Unknown,

        /// <summary>
        /// The run is queued.
        /// </summary>
        Queued,

        /// <summary>
        /// The run is starting up
        /// </summary>
        Startup,

        /// <summary>
        /// The run is running.
        /// </summary>
        Running,

        /// <summary>
        /// The run is cleaning up
        /// </summary>
        Cleanup,

        /// <summary>
        /// The run was successful.
        /// </summary>
        Success,

        /// <summary>
        /// The run failed.
        /// </summary>
        Failed
    }

    /// <summary>
    /// This class represents a Pipeline run model.
    /// </summary>
    public class PipelineRunModel
    {
        /// <summary>
        /// Gets or sets the pipeline run identifier.
        /// </summary>
        /// <value>The pipeline run identifier.</value>
        public Guid PipelineRunId { get; set; }

        /// <summary>
        /// Gets or sets the pipeline identifier.
        /// </summary>
        /// <value>The pipeline identifier.</value>
        public Guid PipelineId { get; set; }

        /// <summary>
        /// Gets or sets the name of the pipeline.
        /// </summary>
        /// <value>The name of the pipeline.</value>
        public string PipelineName { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public PipelineRunState State { get; set; }

        /// <summary>
        /// Gets or sets the build.
        /// </summary>
        /// <value>The build.</value>
        [MaxLength(100)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or sets the metadata string and deserializes JSON formatted metadata into the Metadata dictionary.
        /// </summary>
        [JsonIgnore]
        public string MetadataModel
        {
            get
            {
                return JsonConvert.SerializeObject(this.Metadata);
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.Metadata = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
                }
            }
        }

        /// <summary>
        /// Gets or sets an optional set of metadata for the notification message.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the request date of a job.
        /// </summary>
        public DateTime RequestDateTime { get; set; }

        /// <summary>
        /// Gets or sets the completed date.
        /// </summary>
        /// <value>The completed date.</value>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the completed date.
        /// </summary>
        /// <value>The completed date.</value>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>The updated date.</value>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        public MicroUserModel User { get; set; }
    }
}