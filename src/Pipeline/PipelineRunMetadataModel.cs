//-----------------------------------------------------------------------
// <copyright file="PipelineRunMetadataModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// This helper model represents a metadata dictionary within the pipeline run model.
    /// </summary>
    public class PipelineRunMetadataModel : Dictionary<string, string>
    {
        /// <summary>
        /// Gets or sets the source URI from the metadata dictionary values.
        /// </summary>
        /// <value>The source URI.</value>
        [JsonIgnore]
        public Uri SourceUri
        {
            get
            {
                Uri result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.SourceUri, out string value))
                {
                    result = new Uri(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.SourceUri))
                {
                    this[PipelineRunMetadataKeys.SourceUri] = value.ToString();
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.SourceUri, value.ToString());
                }
            }
        }

        /// <summary>
        /// Gets or sets the artifact URI from the metadata dictionary values.
        /// </summary>
        /// <value>The artifact URI.</value>
        [JsonIgnore]
        public Uri ArtifactUri
        {
            get
            {
                Uri result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.ArtifactUri, out string value))
                {
                    result = new Uri(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.ArtifactUri))
                {
                    this[PipelineRunMetadataKeys.ArtifactUri] = value.ToString();
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.ArtifactUri, value.ToString());
                }
            }
        }

        /// <summary>
        /// Gets or sets the log URI from the metadata dictionary values.
        /// </summary>
        /// <value>The log URI.</value>
        [JsonIgnore]
        public Uri LogUri
        {
            get
            {
                Uri result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.LogUri, out string value))
                {
                    result = new Uri(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.LogUri))
                {
                    this[PipelineRunMetadataKeys.LogUri] = value.ToString();
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.LogUri, value.ToString());
                }
            }
        }
    }
}