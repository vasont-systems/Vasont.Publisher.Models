//-----------------------------------------------------------------------
// <copyright file="PublishRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Publish
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains a publish request model passed to trigger a publish operation within the GlobalLink Publisher API.
    /// </summary>
    public class PublishRequestModel
    {
        /// <summary>
        /// Gets or sets the pipeline identifier used for the publish operation.
        /// </summary>
        /// <value>The pipeline identifier.</value>
        public Guid PipelineId { get; set; }

        /// <summary>
        /// Gets or sets the name of the root file.
        /// </summary>
        /// <value>The name of the root file.</value>
        public string RootFileName { get; set; }

        /// <summary>
        /// Gets or sets the name of the root component.
        /// </summary>
        /// <value>The name of the root component.</value>
        public string RootComponentName { get; set; }

        /// <summary>
        /// Gets or sets the webhook URI to call for publish run notifications.
        /// </summary>
        /// <value>The webhook URI.</value>
        public Uri WebhookUri { get; set; }

        /// <summary>
        /// Gets or sets the start date to initiate the request.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets a dictionary of additional parameters used for the publication request.
        /// </summary>
        /// <value>The parameters.</value>
        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
    }
}