using OwaspRecommendedHeaders.Core.Enums;

namespace OwaspRecommendedHeaders.Core.Models
{
    public class ContenSecurityPolicyElement
    {
        public CspCommandType CommandType { get; set; }
        public string DirectiveOrUri { get; set; }
    }
}