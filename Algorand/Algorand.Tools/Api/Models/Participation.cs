using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Participation
    {
        [JsonPropertyName("partpkb64")]
        public string Partpkb64 { get; set; }

        [JsonPropertyName("votefst")]
        public int Votefst { get; set; }

        [JsonPropertyName("votekd")]
        public int Votekd { get; set; }

        [JsonPropertyName("votelst")]
        public int Votelst { get; set; }

        [JsonPropertyName("vrfpkb64")]
        public string Vrfpkb64 { get; set; }
    }
}