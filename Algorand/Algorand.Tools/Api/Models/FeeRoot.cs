using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class FeeRoot
    {
        [JsonPropertyName("fee")]
        public int Fee { get; set; }
    }
}