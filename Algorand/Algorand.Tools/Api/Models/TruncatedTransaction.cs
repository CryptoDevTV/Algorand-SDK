using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class TruncatedTransaction
    {
        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}