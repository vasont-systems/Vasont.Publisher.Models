//-----------------------------------------------------------------------
// <copyright file="PipelineRunMetadataUriModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System;

    /// <summary>
    /// This class represents a pipeline run Uri details model for describing the content at the specified metadata URI endpoint.
    /// </summary>
    public class PipelineRunMetadataUriModel
    {
        /// <summary>
        /// Gets or sets the item URI.
        /// </summary>
        /// <value>The item URI.</value>
        public Uri ItemUri { get; set; }

        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>The type of the content.</value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the length of the content.
        /// </summary>
        /// <value>The length of the content.</value>
        public long ContentLength { get; set; }
    }
}