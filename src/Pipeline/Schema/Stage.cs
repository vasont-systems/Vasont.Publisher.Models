//-----------------------------------------------------------------------
// <copyright file="Stage.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a pipeline execution stage within the configuration.
    /// </summary>
    public class Stage
    {
        /// <summary>
        /// Gets or sets the stage identifier.
        /// </summary>
        /// <value>The stage identifier.</value>
        public Guid StageId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the name of the stage.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = SchemaDefaults.DefaultStageName;

        /// <summary>
        /// Gets or sets an optional stage description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of jobs to execute within the stage.
        /// </summary>
        [Required]
        public List<Job> Jobs { get; set; } = new List<Job>();
    }
}