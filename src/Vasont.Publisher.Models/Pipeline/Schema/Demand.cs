//-----------------------------------------------------------------------
// <copyright file="Demand.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a demand to be included in the publisher pipeline configuration.
    /// </summary>
    /// <remarks>Demands are specific tag requirements of a build image/runner needed for the particular publisher pipeline configuration to be executed.</remarks>
    public class Demand
    {
        /// <summary>
        /// Gets or sets the demand name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the demand operand.
        /// </summary>
        public PipelineDemandOperand Operand { get; set; } = PipelineDemandOperand.Equals;

        /// <summary>
        /// Gets or sets the demand value.
        /// </summary>
        [MaxLength(1000)]
        public string Value { get; set; }
    }
}