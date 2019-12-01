using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class TransactionRoot
    {
        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}