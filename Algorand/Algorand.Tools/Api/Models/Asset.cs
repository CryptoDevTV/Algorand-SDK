using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Asset
    {
        [JsonPropertyName("assetname")]
        public string Assetname { get; set; }

        [JsonPropertyName("clawbackaddr")]
        public string Clawbackaddr { get; set; }

        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        [JsonPropertyName("defaultfrozen")]
        public bool Defaultfrozen { get; set; }

        [JsonPropertyName("freezeaddr")]
        public string Freezeaddr { get; set; }

        [JsonPropertyName("managerkey")]
        public string Managerkey { get; set; }

        [JsonPropertyName("metadatahash")]
        public string Metadatahash { get; set; }

        [JsonPropertyName("reserveaddr")]
        public string Reserveaddr { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("unitname")]
        public string Unitname { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}