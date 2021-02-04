//-----------------------------------------------------------------------
// <copyright file="MicroUserModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class contains the bare minimum properties to represent a user in the interface.
    /// </summary>
    public class MicroUserModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the user.
        /// </summary>
        [StringLength(450)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user's e-mail address.
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [StringLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [StringLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the user name of the user.
        /// </summary>
        [StringLength(100)]
        public string UserName { get; set; }
    }
}