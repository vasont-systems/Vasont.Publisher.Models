//-----------------------------------------------------------------------
// <copyright file="DisplayValuePair.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Common
{
    /// <summary>
    /// This class represents a base for displaying a name value pair combination.
    /// </summary>
    /// <typeparam name="TDisplay">Contains the display data type.</typeparam>
    /// <typeparam name="TValue">Contains the value data type.</typeparam>
    public abstract class DisplayValuePair<TDisplay, TValue>
    {
        /// <summary>
        /// Gets or sets the pair display value.
        /// </summary>
        public TDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets the pair value.
        /// </summary>
        public TValue Value { get; set; }
    }
}