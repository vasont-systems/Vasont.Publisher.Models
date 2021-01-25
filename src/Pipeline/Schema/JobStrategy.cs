//-----------------------------------------------------------------------
// <copyright file="JobStrategy.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of job strategy types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineJobStrategyType
    {
        /// <summary>
        /// The job strategy is toward executing tasks in serial order.
        /// </summary>
        Serial,

        /// <summary>
        /// The job strategy is toward executing tasks in parallel.
        /// </summary>
        Parallel
    }

    /// <summary>
    /// This class defines the job strategy configuration values.
    /// </summary>
    public class JobStrategy
    {
        /// <summary>
        /// Gets or sets the job execution strategy type.
        /// </summary>
        public PipelineJobStrategyType Type { get; set; } = PipelineJobStrategyType.Parallel;

        /// <summary>
        /// Gets or sets the maximum parallel threads to execute within the job.
        /// </summary>
        /// <remarks>Setting the value to 0 will not limit the number of parallel threads executing at one time in the job, which is the default.</remarks>
        public short MaxParallel { get; set; } = SchemaDefaults.DefaultMaxParallelThreads;
    }
}