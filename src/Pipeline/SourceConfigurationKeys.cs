//-----------------------------------------------------------------------
// <copyright file="SourceConfigurationKeys.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publisher.Models.Pipeline
{
    /// <summary>
    /// This class contains the basic expected source configuration keys used to store pipeline run source configuration values within the pipeline configuration.
    /// </summary>
    public static class SourceConfigurationKeys
    {
        /// <summary>
        /// API authority for token generation.
        /// </summary>
        public const string Authority = "authority";

        /// <summary>
        /// API resource endpoint URI.
        /// </summary>
        public const string ResourceUri = "resource-uri";

        /// <summary>
        /// API client identifier.
        /// </summary>
        public const string ClientId = "client-id";

        /// <summary>
        /// API client scopes requested.
        /// </summary>
        public const string ClientScopes = "client-scopes";

        /// <summary>
        /// API client secret.
        /// </summary>
        public const string ClientSecret = "client-secret";

        /// <summary>
        /// API client flow type.
        /// </summary>
        public const string ClientFlow = "client-flow";
    }
}