//-----------------------------------------------------------------------
// <copyright file="JobStepOutputVariable.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a job step output variable configuration.
    /// </summary>
    public class JobStepOutputVariable
    {
        /// <summary>
        /// Gets or sets the job step output variable internal name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job step output variable description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}