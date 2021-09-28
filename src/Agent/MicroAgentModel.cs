//-----------------------------------------------------------------------
// <copyright file="MicroAgentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Agent
{
    using System;

    /// <summary>
    /// Contains the minimal sized agent model properties.
    /// </summary>
    public class MicroAgentModel
    {
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        /// <value>The agent identifier.</value>
        public Guid AgentId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}