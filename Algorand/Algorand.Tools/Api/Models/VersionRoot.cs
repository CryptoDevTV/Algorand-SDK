using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class VersionRoot
    {
        [JsonPropertyName("versions")]
        public List<string> Versions { get; set; }

        [JsonPropertyName("genesis_id")]
        public string GenesisId { get; set; }

        [JsonPropertyName("genesis_hash_b64")]
        public string GenesisHashB64 { get; set; }

        [JsonPropertyName("build")]
        public Build Build { get; set; }
    }
}