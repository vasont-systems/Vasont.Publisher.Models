//-----------------------------------------------------------------------
// <copyright file="JobTask.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of job task types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobTaskType
    {
        /// <summary>
        /// Step is used for input compilation.
        /// </summary>
        Build,

        /// <summary>
        /// Step is used for input utility based changes.
        /// </summary>
        Utility,

        /// <summary>
        /// Step is used for output publishing.
        /// </summary>
        Publish
    }

    /// <summary>
    /// Contains an enumerated list of available commands to execute within the job task.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobTaskCommand
    {
        /// <summary>
        /// An Antenna House script is to be executed.
        /// </summary>
        AntennaHouse,

        /// <summary>
        /// An Apache Ant script is to be executed.
        /// </summary>
        ApacheAnt,

        /// <summary>
        /// An Archive files command is to be executed.
        /// </summary>
        ArchiveFiles,

        /// <summary>
        /// An AWS Bucket command is to be executed.
        /// </summary>
        AwsBucket,

        /// <summary>
        /// A Microsoft Azure Blob command is to be executed.
        /// </summary>
        AzureBlob,

        /// <summary>
        /// A Bash shell script command is to be executed.
        /// </summary>
        Bash,

        /// <summary>
        /// A Windows .bat or .cmd batch script is to be executed.
        /// </summary>
        BatchScript,

        /// <summary>
        /// A Windows command line program is to be executed.
        /// </summary>
        CommandLine,

        /// <summary>
        /// A copy files command is to be executed.
        /// </summary>
        CopyFiles,

        /// <summary>
        /// A cURL Upload command is to be executed.
        /// </summary>
        CurlUpload,

        /// <summary>
        /// A delay is to be executed.
        /// </summary>
        Delay,

        /// <summary>
        /// A delete files command is to be executed.
        /// </summary>
        DeleteFiles,

        /// <summary>
        /// A DITA-OT script is to be executed.
        /// </summary>
        DitaOt,

        /// <summary>
        /// A DocBook script is to be executed.
        /// </summary>
        DocBook,

        /// <summary>
        /// A DropBox command is to be executed.
        /// </summary>
        DropBox,

        /// <summary>
        /// An e-mail delivery is to be executed.
        /// </summary>
        Email,

        /// <summary>
        /// An Extract archive files command is to be executed.
        /// </summary>
        ExtractFiles,

        /// <summary>
        /// An install of an SSH key is to be executed.
        /// </summary>
        InstallSshKey,

        /// <summary>
        /// A Java Saxon script is to be executed.
        /// </summary>
        JavaSaxon,

        /// <summary>
        /// A Google Drive command is to be executed.
        /// </summary>
        GoogleDriveUpload,

        /// <summary>
        /// A move files command is to be executed.
        /// </summary>
        MoveFiles,

        /// <summary>
        /// A Microsoft OneDrive command is to be executed.
        /// </summary>
        OneDriveUpload,

        /// <summary>
        /// A Python script is to be executed.
        /// </summary>
        Python,

        /// <summary>
        /// An SSH command is to be executed.
        /// </summary>
        Ssh,

        /// <summary>
        /// An SFTP command is to be executed.
        /// </summary>
        SftpUpload,

        /// <summary>
        /// A XLTPROC script is to be executed.
        /// </summary>
        XltProc
    }

    /// <summary>
    /// Gets or sets the job task configuration for a pipeline job execution.
    /// </summary>
    public class JobTask
    {
        /// <summary>
        /// Gets or sets the job step identifier.
        /// </summary>
        /// <value>The job step identifier.</value>
        public Guid JobStepId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the job task internal name.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = SchemaDefaults.DefaultJobTaskName;

        /// <summary>
        /// Gets or sets the job task description.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        [Required]
        public string Version { get; set; } = SchemaDefaults.DefaultTaskVersion;

        /// <summary>
        /// Gets or sets the job task plugin command to execute within the job.
        /// </summary>
        [Required]
        public JobTaskCommand Command { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the step is enabled.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the job task output variables used within the overall job execution.
        /// </summary>
        public List<JobStepOutputVariable> OutputVariables { get; set; } = new List<JobStepOutputVariable>();

        /// <summary>
        /// Gets or sets the custom configuration parameters for the selected step plugin.
        /// </summary>
        public Dictionary<string, string> Configuration { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the run timeout minutes.
        /// </summary>
        /// <value>The run timeout minutes.</value>
        public int RunTimeoutMinutes { get; set; } = SchemaDefaults.DefaultTaskTimeoutMinutes;
    }
}