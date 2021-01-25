//-----------------------------------------------------------------------
// <copyright file="SchemaDefaults.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    /// <summary>
    /// Contains a collection of default values for the schema definition classes.
    /// </summary>
    public static class SchemaDefaults
    {
        /// <summary>
        /// The default job timeout minutes
        /// </summary>
        public const int DefaultJobTimeoutMinutes = 10;

        /// <summary>
        /// The default agent cancel timeout minutes
        /// </summary>
        public const int DefaultAgentCancelTimeoutMinutes = 60;

        /// <summary>
        /// The default maximum parallel threads a job can execute.
        /// </summary>
        public const int DefaultMaxParallelThreads = 4;

        /// <summary>
        /// The default job step name
        /// </summary>
        public const string DefaultJobStepName = "Step";

        /// <summary>
        /// The default job name
        /// </summary>
        public const string DefaultJobName = "Default";

        /// <summary>
        /// The default stage name
        /// </summary>
        public const string DefaultStageName = "Default";

        /// <summary>
        /// The default trigger schedule time
        /// </summary>
        public const string DefaultTriggerScheduleTime = "00:00";

        /// <summary>
        /// The default trigger schedule time zone
        /// </summary>
        public const string DefaultTriggerScheduleTimeZone = "0";

        /// <summary>
        /// The default task version
        /// </summary>
        public const string DefaultTaskVersion = "0.*";
    }
}