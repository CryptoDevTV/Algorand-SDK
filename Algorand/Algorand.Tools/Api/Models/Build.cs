using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Build
    {
        [JsonPropertyName("major")]
        public int Major { get; set; }

        [JsonPropertyName("minor")]
        public int Minor { get; set; }

        [JsonPropertyName("build_number")]
        public int BuildNumber { get; set; }

        [JsonPropertyName("commit_hash")]
        public string CommitHash { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }
    }
}