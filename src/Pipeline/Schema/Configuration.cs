//-----------------------------------------------------------------------
// <copyright file="Configuration.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json.Schema;
    using Newtonsoft.Json.Schema.Generation;

    /// <summary>
    /// This class defines the publisher pipeline configuration to be executed.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Gets or sets the unique configuration identifier.
        /// </summary>
        /// <value>The unique configuration identifier.</value>
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the name/title of the configuration.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description details of the configuration.
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the output build and revision number template string.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string BuildNumberFormat { get; set; } = "$(date:yyMMdd)$(rev:.r)";

        /// <summary>
        /// Gets or sets a value indicating whether the status badges of the server are enabled for this configuration.
        /// </summary>
        public bool StatusBadgesEnabled { get; set; }

        /// <summary>
        /// Gets or sets a list of demands for the configuration.
        /// </summary>
        public List<Demand> Demands { get; set; } = new List<Demand>();

        /// <summary>
        /// Gets or sets the pipeline content source model.
        /// </summary>
        public PipelineSourceBase Source { get; set; } = new PipelineSourceBase();

        /// <summary>
        /// Gets or sets a list of pipeline configuration variables.
        /// </summary>
        public List<PipelineVariable> Variables { get; set; } = new List<PipelineVariable>();

        /// <summary>
        /// Gets or sets a list of stages to execute.
        /// </summary>
        public List<Stage> Stages { get; set; } = new List<Stage>();

        /// <summary>
        /// Gets or sets a list of triggers.
        /// </summary>
        public List<Trigger> Triggers { get; set; } = new List<Trigger>();

        /// <summary>
        /// Gets or sets a list of revision audit records to this configuration.
        /// </summary>
        public List<Revision> Revisions { get; set; } = new List<Revision>();

        /// <summary>
        /// This method is used to generate the JSON schema object dynamically for the configuration models.
        /// </summary>
        /// <returns>Returns a new <see cref="JSchema" /> object for the Configuration model.</returns>
        public JSchema Schema()
        {
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema schema = generator.Generate(typeof(Configuration));
            System.Console.WriteLine(schema.ToString());
            return schema;
        }
    }
}