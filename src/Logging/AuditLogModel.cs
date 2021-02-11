//-----------------------------------------------------------------------
// <copyright file="AuditLogModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Logging
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Publisher.Models.Security;

    /// <summary>
    /// Contains an enumerated list of audit event types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditEvent
    {
        /// <summary>
        /// Informational audit event.
        /// </summary>
        Information,

        /// <summary>
        /// Error audit event.
        /// </summary>
        Error,

        /// <summary>
        /// Security audit event.
        /// </summary>
        Security,

        /// <summary>
        /// Pipeline audit event.
        /// </summary>
        Pipeline,

        /// <summary>
        /// Configuration audit event.
        /// </summary>
        Configuration
    }

    /// <summary>
    /// Contains an enumerated list of security event results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditResult
    {
        /// <summary>
        /// Successful event.
        /// </summary>
        Success,

        /// <summary>
        /// Unsuccessful event.
        /// </summary>
        Fail,

        /// <summary>
        /// Informational event.
        /// </summary>
        Info
    }

    /// <summary>
    /// This class represents an event log entry within the application.
    /// </summary>
    public class AuditLogModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the security event log record.
        /// </summary>
        public int AuditLogId { get; set; }

        /// <summary>
        /// Gets or sets the event date time the event occurred.
        /// </summary>
        [Required]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Gets or sets the optional associated user that generated the event.
        /// </summary>
        [MaxLength(450)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public AuditEvent Event { get; set; }

        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        [MaxLength(30)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the event result.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public AuditResult Result { get; set; }

        /// <summary>
        /// Gets or sets an additional event message.
        /// </summary>
        [MaxLength(1000)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the client's IP address.
        /// </summary>
        [MaxLength(30)]
        public string ClientAddress { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        [MaxLength(250)]
        public string Request { get; set; }

        /// <summary>
        /// Gets or sets the associated user.
        /// </summary>
        public MicroUserModel User { get; set; }
    }
}