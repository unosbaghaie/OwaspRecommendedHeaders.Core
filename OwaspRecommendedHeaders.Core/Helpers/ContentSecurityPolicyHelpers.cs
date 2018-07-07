using OwaspRecommendedHeaders.Core.Enums;
using OwaspRecommendedHeaders.Core.Models;

namespace OwaspRecommendedHeaders.Core.Helpers
{
    public static class ContentSecurityPolicyHelpers
    {
        /// <summary>
        /// Used to create the default "self" CSP directive.
        /// This can be applied to any of the CSP rules individually
        /// or to the 'default-src' rule to cover them all.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="ContenSecurityPolicyElement"/>
        /// class which represents a 'self' CSP rule.
        /// </returns>
        public static ContenSecurityPolicyElement CreateSelfDirective()
        {
            return new ContenSecurityPolicyElement
            {
                CommandType = CspCommandType.Directive,
                DirectiveOrUri = "self"
            };
        }
    }
}