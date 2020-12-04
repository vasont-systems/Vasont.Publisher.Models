//-----------------------------------------------------------------------
// <copyright file="JobWorkspaceConfiguration.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vasont.Publisher.Models.Pipeline.Schema
{
    /// <summary>
    /// Contains an enumerated list of workspace cleanup actions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkspaceActionCleanup
    {
        /// <summary>
        /// Clean-up both source and output directories before attempting to execute job.
        /// </summary>
        All,

        /// <summary>
        /// Clean-up only the source directories before attempting to execute job.
        /// </summary>
        SourceOnly,

        /// <summary>
        /// Do not clean-up source or output directories before attempting to execute job.
        /// </summary>
        None
    }

    /// <summary>
    /// This class represents the workspace configuration for a job.
    /// </summary>
    public class JobWorkspaceConfiguration
    {
        /// <summary>
        /// Gets or sets the workspace configuration for the job execution.
        /// </summary>
        public WorkspaceActionCleanup Clean { get; set; } = WorkspaceActionCleanup.All;
    }
}