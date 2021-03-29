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
        public PipelineRunMetadataUriModel SourceUriDetails
        {
            get
            {
                PipelineRunMetadataUriModel result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.SourceUri, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataUriModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.SourceUri))
                {
                    this[PipelineRunMetadataKeys.SourceUri] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.SourceUri, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets the artifact URI from the metadata dictionary values.
        /// </summary>
        /// <value>The artifact URI.</value>
        [JsonIgnore]
        public PipelineRunMetadataUriModel ArtifactUri
        {
            get
            {
                PipelineRunMetadataUriModel result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.ArtifactUri, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataUriModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.ArtifactUri))
                {
                    this[PipelineRunMetadataKeys.ArtifactUri] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.ArtifactUri, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets the log URI from the metadata dictionary values.
        /// </summary>
        /// <value>The log URI.</value>
        [JsonIgnore]
        public PipelineRunMetadataUriModel LogUri
        {
            get
            {
                PipelineRunMetadataUriModel result = null;

                if (!this.TryGetValue(PipelineRunMetadataKeys.LogUri, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataUriModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.LogUri))
                {
                    this[PipelineRunMetadataKeys.LogUri] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.LogUri, JsonConvert.SerializeObject(value));
                }
            }
        }
    }
}