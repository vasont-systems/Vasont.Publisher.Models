//-----------------------------------------------------------------------
// <copyright file="AgentState.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Agent
{
    /// <summary>
    /// Contains an enumerated list of agent process states.
    /// </summary>
    public enum AgentState
    {
        /// <summary>
        /// Agent is in an unknown state.
        /// </summary>
        Unknown,

        /// <summary>
        /// The agent is starting.
        /// </summary>
        Starting,

        /// <summary>
        /// The agent is running.
        /// </summary>
        Running,

        /// <summary>
        /// The agent is stopping.
        /// </summary>
        Stopping,

        /// <summary>
        /// The agent is stopped.
        /// </summary>
        Stopped
    }

    /// <summary>
    /// Contains an enumerated list of container states.
    /// </summary>
    public enum ContainerState
    {
        /// <summary>
        /// Container is in an unknown state.
        /// </summary>
        Unknown,

        /// <summary>
        /// The container is starting.
        /// </summary>
        Starting,

        /// <summary>
        /// The container is running.
        /// </summary>
        Running,

        /// <summary>
        /// The container is stopping
        /// </summary>
        Stopping,

        /// <summary>
        /// The container is stopped.
        /// </summary>
        Stopped
    }
}