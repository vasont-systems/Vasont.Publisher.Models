//-----------------------------------------------------------------------
// <copyright file="FeatureAbilities.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Security
{
    /// <summary>
    /// This class contains static feature ability keys used for feature security claims assignment.
    /// </summary>
    /// <remarks>
    /// Users will always be able to read their own request runs. Otherwise, specific feature abilities must be specified. Additional abilities are related to
    /// organizational request runs.
    /// <para>
    /// The concept of "manage" is a combination of create/update a record. We try to keep things as simple as possible within Publisher to read and/or manage
    /// records. In some cases delete will be included, in others it may not.
    /// </para>
    /// </remarks>
    public static class FeatureAbilities
    {
        /// <summary>
        /// Feature ability for user to manage their own request runs.
        /// </summary>
        public const string RequestUserManage = "request-run:user:manage";

        /// <summary>
        /// Feature ability for user to delete their own request run records.
        /// </summary>
        public const string RequestUserDelete = "request-run:user:delete";

        /// <summary>
        /// Feature ability for user to read all tenant request run records. Organization level read.
        /// </summary>
        public const string RequestTenantRead = "request-run:tenant:read";

        /// <summary>
        /// Feature ability for user to manage all tenant request run records.
        /// </summary>
        public const string RequestTenantManage = "request-run:tenant:manage";

        /// <summary>
        /// Feature ability for user to delete all tenant request run records.
        /// </summary>
        public const string RequestTenantDelete = "request-run:tenant:delete";

        /// <summary>
        /// Feature ability for user to be able to view/read pipeline configurations in detail.
        /// </summary>
        public const string PipelineTenantRead = "pipeline:tenant:read";

        /// <summary>
        /// Feature ability for user to be able to create, update, and delete pipeline configurations.
        /// </summary>
        public const string PipelineTenantManage = "pipeline:tenant:manage";

        /// <summary>
        /// Feature ability for user to be able read their own analytic reports.
        /// </summary>
        public const string ReportsUserRead = "reports:user:read";

        /// <summary>
        /// Feature ability for user to be able read tenant analytic reports.
        /// </summary>
        public const string ReportsTenantRead = "reports:tenant:read";

        /// <summary>
        /// Feature ability for users to be able to administrate a tenant settings and security configuration.
        /// </summary>
        public const string AdminTenantManage = "admin:tenant:manage";

        /// <summary>
        /// Feature ability covers all abilities.
        /// </summary>
        public const string AllAbilities = "tenant:all";
    }
}