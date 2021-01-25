//-----------------------------------------------------------------------
// <copyright file="Revision.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of revision action types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RevisionActions
    {
        /// <summary>
        /// The revision was creating a new pipeline configuration.
        /// </summary>
        Create,

        /// <summary>
        /// The revision was updating the pipeline configuration.
        /// </summary>
        Update,

        /// <summary>
        /// The revision was archiving/removing the pipeline configuration.
        /// </summary>
        Archive
    }

    /// <summary>
    /// This class represents a recent record of change revision made to the configuration.
    /// </summary>
    public class Revision
    {
        /// <summary>
        /// Gets or sets the revision version number.
        /// </summary>
        [Required]
        public int Version { get; set; }

        /// <summary>
        /// Contains the revision action that occurred.
        /// </summary>
        public RevisionActions Change { get; set; }

        /// <summary>
        /// Gets or sets the optional comment for the revision.
        /// </summary>
        [MaxLength(1000)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user who created the revision.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string RevisionBy { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the user who created the revision.
        /// </summary>
        [Required]
        public Guid RevisionByUniqueId { get; set; }

        /// <summary>
        /// Gets or sets the date time when the revision occurred.
        /// </summary>
        public DateTime RevisionDate { get; set; }
    }
}