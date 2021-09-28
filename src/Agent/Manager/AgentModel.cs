//-----------------------------------------------------------------------
// <copyright file="AgentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Agent.Manager
{
    /// <summary>
    /// Contains an agent management model.
    /// </summary>
    /// <seealso cref="Vasont.Publisher.Models.Agent.MicroAgentModel" />
    public class AgentModel : MicroAgentModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the state of the container.
        /// </summary>
        /// <value>The state of the container.</value>
        public ContainerState ContainerState { get; set; }

        /// <summary>
        /// Gets or sets the state of the agent.
        /// </summary>
        /// <value>The state of the agent.</value>
        public AgentState AgentState { get; set; }
    }
}