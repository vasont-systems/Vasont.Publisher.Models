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
    /// <para>This class represents the main entry of a Publisher Pipeline Configuration within the GlobalLink Publisher application.</para>
    /// <para>It is an object representation of a configuration script to be executed by the Publisher Agent.</para>
    /// <para>
    /// It consists of a basic definition one or more stages, that consist of one or more jobs, each containing one or more Job steps to execute by the agent.
    /// </para>
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Gets or sets the unique configuration identifier.
        /// </summary>
        /// <value>The unique configuration identifier.</value>
        public Guid ConfigurationId { get; set; } = Guid.NewGuid();

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
        /// Gets or sets a list of demands necessary for the configuration to execute.
        /// </summary>
        public List<Demand> Demands { get; set; } = new List<Demand>();

        /// <summary>
        /// Gets or sets the timeout in minutes that the agent run will wait before cancelling the job.
        /// </summary>
        public uint CancelTimeoutInMinutes { get; set; } = SchemaDefaults.DefaultAgentCancelTimeoutMinutes;

        /// <summary>
        /// Gets or sets the pipeline content source configuration. This is where the configuration source content will be received.
        /// </summary>
        [Required]
        public PipelineSourceBase Source { get; set; } = new PipelineSourceBase();

        /// <summary>
        /// Gets or sets a list of optional pipeline configuration variables used within the job steps of the configuration.
        /// </summary>
        public List<PipelineVariable> Variables { get; set; } = new List<PipelineVariable>();

        /// <summary>
        /// Gets or sets a list of jobs for the agent to process and execute through. Jobs are an organizational concept within the configuration to process a
        /// list of tasks within a single context.
        /// </summary>
        [Required]
        public List<Job> Jobs { get; set; } = new List<Job>();

        /// <summary>
        /// Gets or sets a list of optional trigger configurations that will automate the execution of this configuration.
        /// </summary>
        public List<Trigger> Triggers { get; set; } = new List<Trigger>();

        /// <summary>
        /// Gets or sets a list of revision audit records noting recent changes to this configuration.
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