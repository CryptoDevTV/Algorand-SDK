using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Payment
    {
        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("close")]
        public string Close { get; set; }

        [JsonPropertyName("closeamount")]
        public int Closeamount { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("torewards")]
        public int Torewards { get; set; }

        [JsonPropertyName("closerewards")]
        public int Closerewards { get; set; }
    }
}