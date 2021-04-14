//-----------------------------------------------------------------------
// <copyright file="PipelineRunExecutionDetailsModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Pipeline.Schema;

    /// <summary>
    /// This class contains detail information for a pipeline run.
    /// </summary>
    public class PipelineRunExecutionDetailsModel
    {
        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>The runtime.</value>
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets the demands.
        /// </summary>
        /// <value>Contains a list of demands for the run, in "{key}{operand}{value}" format.</value>
        public List<string> Demands { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the type of the source.
        /// </summary>
        /// <value>The type of the source.</value>
        public PipelineSourceTypes SourceType { get; set; }

        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        /// <value>The name of the source.</value>
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or sets the variables.
        /// </summary>
        /// <value>Contains a list of variables for the run, in "{name}={value}" format.</value>
        public List<string> Variables { get; set; } = new List<string>();
    }
}