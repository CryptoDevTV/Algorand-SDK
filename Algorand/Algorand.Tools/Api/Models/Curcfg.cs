using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Curcfg
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("@params")]
        public Params Params { get; set; }
    }
}