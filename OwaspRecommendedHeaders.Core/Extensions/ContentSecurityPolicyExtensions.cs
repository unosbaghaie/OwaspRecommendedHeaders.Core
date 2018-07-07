using System.Collections.Generic;
using OwaspRecommendedHeaders.Core.Enums;
using OwaspRecommendedHeaders.Core.Models;

namespace OwaspRecommendedHeaders.Core.Extensions
{
    public static class ContentSecurityPolicyExtensions
    {
        /// <summary>
        /// Used to set the Content Security Policy URIs for a given <see cref="CspUriType"/>
        /// </summary>
        public static SecureHeadersMiddlewareConfiguration SetCspUris
            (this SecureHeadersMiddlewareConfiguration config, List<ContenSecurityPolicyElement> baseUri,
            CspUriType cspUriType)
        {
            if (config.UseContentSecurityPolicy)
            {
                config.ContentSecurityPolicyConfiguration?.SetCspUri(baseUri, cspUriType);
            }
            
            return config;
        }

        /// <summary>
        /// Used to set up the Content Security Policy Sandbox for a given <see cref="CspSandboxType"/>
        /// </summary>
        public static SecureHeadersMiddlewareConfiguration SetCspSandBox
            (this SecureHeadersMiddlewareConfiguration config, CspSandboxType sandboxType)
        {
            if (config.UseContentSecurityPolicy)
            {
                config.ContentSecurityPolicyConfiguration?.SetSandbox(sandboxType);
            }
            
            return config;
        }
    }
}