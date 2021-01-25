//-----------------------------------------------------------------------
// <copyright file="JobPoolConfiguration.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class contains job runner pool configuration information.
    /// </summary>
    public class JobPoolConfiguration
    {
        /// <summary>
        /// Gets or sets the docker container image name used to run the job.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Image { get; set; }
    }
}