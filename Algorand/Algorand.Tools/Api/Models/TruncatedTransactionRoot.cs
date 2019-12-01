using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class TruncatedTransactionRoot
    {
        [JsonPropertyName("totalTxns")]
        public int TotalTxns { get; set; }

        [JsonPropertyName("truncatedTxns")]
        public TruncatedTransaction TruncatedTxns { get; set; }
    }
}