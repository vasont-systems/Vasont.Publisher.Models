//-----------------------------------------------------------------------
// <copyright file="PipelineRunMetadataKeys.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    /// <summary>
    /// This class contains a collection of pipeline run metadata constants containing common reserved key names for metadata values required to be stored
    /// within the pipeline run metadata object.
    /// </summary>
    public static class PipelineRunMetadataKeys
    {
        /// <summary>
        /// This metadata key will provide a URI to the original source of a pipeline run request.
        /// </summary>
        public const string SourceUri = "SourceUri";

        /// <summary>
        /// This metadata key will provide a URI to the final artifacts of a pipeline run request.
        /// </summary>
        public const string ArtifactUri = "ArtifactUri";

        /// <summary>
        /// This metadata key will provide a URI to the final compiled logging report from a pipeline run request.
        /// </summary>
        public const string LogUri = "LogUri";

        /// <summary>
        /// This metadata key will provide a details model for information related to the pipeline run.
        /// </summary>
        public const string ExecutionDetails = "ExecutionDetails";
    }
}