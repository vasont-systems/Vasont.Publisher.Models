//-----------------------------------------------------------------------
// <copyright file="TriggerSchedule.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a trigger schedule that will denote when a publisher pipeline event is to occur.
    /// </summary>
    public class TriggerSchedule
    {
        /// <summary>
        /// Gets or sets a list of days the scheduled trigger will occur.
        /// </summary>
        public List<string> Days { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the time of day in hours and minutes when the trigger will occur.
        /// </summary>
        [Required]
        [MaxLength(5)]
        public string Time { get; set; } = "00:00";

        /// <summary>
        /// Gets or sets the IANA time zone for the trigger time setting.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string TimeZone { get; set; } = "0";
    }
}