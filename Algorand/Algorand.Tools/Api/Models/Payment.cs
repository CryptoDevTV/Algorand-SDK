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
        public long Closeamount { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("torewards")]
        public long Torewards { get; set; }

        [JsonPropertyName("closerewards")]
        public long Closerewards { get; set; }
    }
}