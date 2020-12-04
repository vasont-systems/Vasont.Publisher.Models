//-----------------------------------------------------------------------
// <copyright file="Stage.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a pipeline execution stage within the configuration.
    /// </summary>
    public class Stage
    {
        /// <summary>
        /// Gets or sets the name of the stage.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "Stage";

        /// <summary>
        /// Gets or sets the display name of the stage.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string DisplayName { get; set; } = "Default";

        /// <summary>
        /// Gets or sets an optional stage description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of jobs to execute within the stage.
        /// </summary>
        public List<Job> Jobs { get; set; } = new List<Job>();
    }
}