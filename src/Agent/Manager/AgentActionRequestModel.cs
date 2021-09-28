//-----------------------------------------------------------------------
// <copyright file="AgentActionRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Agent.Manager
{
    using System;

    /// <summary>
    /// Contains an enumerated list of agent request action types.
    /// </summary>
    public enum AgentRequestAction
    {
        /// <summary>
        /// The stop the current container run.
        /// </summary>
        Stop,

        /// <summary>
        /// The start the container with existing container.
        /// </summary>
        Start,

        /// <summary>
        /// The start the container with latest container version.
        /// </summary>
        StartWithLatest,

        /// <summary>
        /// The restart the agent process within the current container.
        /// </summary>
        RestartAgent
    }

    /// <summary>
    /// This class contains the model for an agent action request.
    /// </summary>
    public class AgentActionRequestModel
    {
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        /// <value>The agent identifier.</value>
        public Guid AgentId { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public AgentRequestAction Action { get; set; }
    }
}