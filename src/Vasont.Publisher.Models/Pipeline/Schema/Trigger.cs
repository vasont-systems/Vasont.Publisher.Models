//-----------------------------------------------------------------------
// <copyright file="Trigger.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a pipeline configuration execution trigger.
    /// </summary>
    public class Trigger
    {
        /// <summary>
        /// Gets or sets a value indicating whether the trigger is automated.
        /// </summary>
        public bool Automated { get; set; }

        /// <summary>
        /// Gets or sets a list of other publish jobs that will trigger this configuration in a chained execution event.
        /// </summary>
        /// <remarks>
        /// The system will allow one publisher pipeline job to execute and then execute another pipeline configuration automatically if defined by name.
        /// </remarks>
        public List<string> Completions { get; set; } = new List<string>();

        /// <summary>
        /// The trigger job will execute only if the content has changed from the source.
        /// </summary>
        public bool ContinueJobOnlyOnDiff { get; set; } = true;
    }
}