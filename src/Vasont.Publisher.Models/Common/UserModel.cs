//-----------------------------------------------------------------------
// <copyright file="UserModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of user types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishServerUserType
    {
        /// <summary>
        /// A standard user
        /// </summary>
        Standard,

        /// <summary>
        /// A GlobalLink Vasont global support technician.
        /// </summary>
        Support,

        /// <summary>
        /// A GlobalLink Vasont publish server administrator.
        /// </summary>
        Administrator
    }

    /// <summary>
    /// This class represents a user associated with a particular publish job.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        [StringLength(450)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [StringLength(256)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [StringLength(256)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [StringLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [StringLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the preferred language.
        /// </summary>
        /// <value>The preferred language.</value>
        [StringLength(5)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        [StringLength(100)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>The type of the user.</value>
        public PublishServerUserType UserType { get; set; } = PublishServerUserType.Standard;
    }
}