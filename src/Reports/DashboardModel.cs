//-----------------------------------------------------------------------
// <copyright file="DashboardModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Reports
{
    using System.Collections.Generic;
    using Vasont.Publisher.Models.Pipeline;

    /// <summary>
    /// This class contains the metrics KPI for the publisher dashboard interface.
    /// </summary>
    public class DashboardModel
    {
        /// <summary>
        /// Gets or sets the total runs submitted.
        /// </summary>
        /// <value>The total runs submitted.</value>
        public int TotalRunsSubmitted { get; set; }

        /// <summary>
        /// Gets or sets the total runs in progress.
        /// </summary>
        /// <value>The total runs in progress calculated from user's total runs not in a success or failed state.</value>
        public int TotalRunsInProgress { get; set; }

        /// <summary>
        /// Gets or sets the average processing time minutes.
        /// </summary>
        /// <value>The average processing time minutes calculated from an avg runtime across all user's runs start and end date difference.</value>
        public double AverageProcessingTimeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the total runs successful.
        /// </summary>
        /// <value>The total runs successful calculated from user's total runs in a success or success with issues state.</value>
        public int TotalRunsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the total runs failed.
        /// </summary>
        /// <value>The total runs failed calculated from user's total runs in a failed state.</value>
        public int TotalRunsFailed { get; set; }

        /// <summary>
        /// Gets or sets the recent runs.
        /// </summary>
        /// <value>The top 10 most recent pipeline runs.</value>
        public List<PipelineRunModel> RecentRuns { get; set; } = new List<PipelineRunModel>();
    }
}