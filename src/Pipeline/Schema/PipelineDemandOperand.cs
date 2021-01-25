//-----------------------------------------------------------------------
// <copyright file="PipelineDemandOperand.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.ComponentModel;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// An enumerated list of available operands used in pipeline execution demand configurations.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineDemandOperand
    {
        /// <summary>
        /// The demand value determines if the pipeline runner environment contains the demand name in the docker image.
        /// </summary>
        /// <remarks>Allowed values are only true or false.</remarks>
        Exists,

        /// <summary>
        /// The demand value must match exactly.
        /// </summary>
        [Description("==")]
        Equals,

        /// <summary>
        /// The demand value must not match exactly.
        /// </summary>
        [Description("!=")]
        NotEquals
    }
}