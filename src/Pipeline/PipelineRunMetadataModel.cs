//-----------------------------------------------------------------------
// <copyright file="PipelineRunMetadataModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// This helper model represents a metadata dictionary within the pipeline run model.
    /// </summary>
    public class PipelineRunMetadataModel : Dictionary<string, string>
    {
        /// <summary>
        /// Gets or sets the details from the metadata dictionary values.
        /// </summary>
        /// <value>The details model.</value>
        [JsonIgnore]
        public PipelineRunExecutionDetailsModel ExecutionDetails
        {
            get
            {
                PipelineRunExecutionDetailsModel result = null;

                if (this.TryGetValue(PipelineRunMetadataKeys.ExecutionDetails, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunExecutionDetailsModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.ExecutionDetails))
                {
                    this[PipelineRunMetadataKeys.ExecutionDetails] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.ExecutionDetails, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets the source URI from the metadata dictionary values.
        /// </summary>
        /// <value>The source URI.</value>
        [JsonIgnore]
        public PipelineRunMetadataTargetModel SourceDetails
        {
            get
            {
                PipelineRunMetadataTargetModel result = null;

                if (this.TryGetValue(PipelineRunMetadataKeys.Source, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataTargetModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.Source))
                {
                    this[PipelineRunMetadataKeys.Source] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.Source, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets the artifact URI from the metadata dictionary values.
        /// </summary>
        /// <value>The artifact URI.</value>
        [JsonIgnore]
        public PipelineRunMetadataTargetModel ArtifactDetails
        {
            get
            {
                PipelineRunMetadataTargetModel result = null;

                if (this.TryGetValue(PipelineRunMetadataKeys.Artifact, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataTargetModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.Artifact))
                {
                    this[PipelineRunMetadataKeys.Artifact] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.Artifact, JsonConvert.SerializeObject(value));
                }
            }
        }

        /// <summary>
        /// Gets or sets the log URI from the metadata dictionary values.
        /// </summary>
        /// <value>The log URI.</value>
        [JsonIgnore]
        public PipelineRunMetadataTargetModel LogDetails
        {
            get
            {
                PipelineRunMetadataTargetModel result = null;

                if (this.TryGetValue(PipelineRunMetadataKeys.Log, out string value))
                {
                    result = JsonConvert.DeserializeObject<PipelineRunMetadataTargetModel>(value);
                }

                return result;
            }

            set
            {
                if (this.ContainsKey(PipelineRunMetadataKeys.Log))
                {
                    this[PipelineRunMetadataKeys.Log] = JsonConvert.SerializeObject(value);
                }
                else
                {
                    this.Add(PipelineRunMetadataKeys.Log, JsonConvert.SerializeObject(value));
                }
            }
        }
    }
}