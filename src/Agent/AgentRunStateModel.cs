//-----------------------------------------------------------------------
// <copyright file="AgentRunStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Agent
{
    using System;
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Pipeline;

    /// <summary>
    /// This class defines a run state model for agent notifications.
    /// </summary>
    public class AgentRunStateModel
    {
        /// <summary>
        /// Gets or sets the agent.
        /// </summary>
        /// <value>The agent.</value>
        public string Agent { get; set; }

        /// <summary>
        /// Gets or sets the pipeline run identifier.
        /// </summary>
        /// <value>The pipeline run identifier.</value>
        public Guid PipelineRunId { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public PipelineRunState State { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        /// <value>The warnings.</value>
        public List<string> Warnings { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>The errors.</value>
        public List<string> Errors { get; set; } = new List<string>();
    }
}