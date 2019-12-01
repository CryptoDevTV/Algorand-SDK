using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Account
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("amountwithoutpendingrewards")]
        public int Amountwithoutpendingrewards { get; set; }

        [JsonPropertyName("participation")]
        public Participation Participation { get; set; }

        [JsonPropertyName("pendingrewards")]
        public int Pendingrewards { get; set; }

        [JsonPropertyName("rewards")]
        public int Rewards { get; set; }

        [JsonPropertyName("round")]
        public int Round { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}