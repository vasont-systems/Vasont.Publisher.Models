//-----------------------------------------------------------------------
// <copyright file="PipelineVariable.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of pipeline variable data types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineVariableType
    {
        /// <summary>
        /// Variable type is a string.
        /// </summary>
        String,

        /// <summary>
        /// Variable type is a GUID.
        /// </summary>
        Guid,

        /// <summary>
        /// Variable type is an integer.
        /// </summary>
        Integer,

        /// <summary>
        /// Variable type is a boolean.
        /// </summary>
        Boolean,

        /// <summary>
        /// Variable type is a double.
        /// </summary>
        Double,

        /// <summary>
        /// Variable type is a date time.
        /// </summary>
        DateTime
    }

    /// <summary>
    /// This class represents a pipeline variable setting within the configuration.
    /// </summary>
    public class PipelineVariable
    {
        /// <summary>
        /// Gets or sets the internal name of the variable.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the default value of the variable.
        /// </summary>
        [MaxLength(1000)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the variable is read-only during execution.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the pipeline variable data type.
        /// </summary>
        public PipelineVariableType Type { get; set; } = PipelineVariableType.String;
    }
}