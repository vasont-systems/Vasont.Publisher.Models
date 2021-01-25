//-----------------------------------------------------------------------
// <copyright file="PipelineSourceBase.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of available pipeline source types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineSourceTypes
    {
        /// <summary>
        /// Content is derived from the publisher API.
        /// </summary>
        API,

        /// <summary>
        /// Content is derived from the local container storage.
        /// </summary>
        Local,

        /// <summary>
        /// Content is derived from a Git repository.
        /// </summary>
        Git,

        /// <summary>
        /// Content is derived from a GitHub repository.
        /// </summary>
        GitHub,

        /// <summary>
        /// Content is derived from an Azure blob repository.
        /// </summary>
        AzureBlob,

        /// <summary>
        /// Content is derived from a drop box cloud storage.
        /// </summary>
        Dropbox,

        /// <summary>
        /// Content is derived from a Microsoft OneDrive cloud storage.
        /// </summary>
        OneDrive
    }

    /// <summary>
    /// This class represents a pipeline source from which content will be derived from in order to execute the pipeline stages.
    /// </summary>
    public class PipelineSourceBase
    {
        /// <summary>
        /// Gets or sets the pipeline content source type.
        /// </summary>
        public PipelineSourceTypes SourceType { get; set; } = PipelineSourceTypes.API;

        /// <summary>
        /// Gets or sets an optional comment field for the source.
        /// </summary>
        [MaxLength(1000)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the pipeline source configuration dictionary.
        /// </summary>
        public Dictionary<string, string> Configuration { get; set; }
    }
}