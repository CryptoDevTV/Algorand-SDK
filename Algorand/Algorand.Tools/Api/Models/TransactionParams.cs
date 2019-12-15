using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class TransactionParams
    {
        [JsonPropertyName("fee")]
        public int Fee { get; set; }

        [JsonPropertyName("genesisID")]
        public string GenesisID { get; set; }

        [JsonPropertyName("genesishashb64")]
        public string Genesishashb64 { get; set; }

        [JsonPropertyName("lastRound")]
        public int LastRound { get; set; }

        [JsonPropertyName("consensusVersion")]
        public string ConsensusVersion { get; set; }

        [JsonPropertyName("minFee")]
        public int MinFee { get; set; }
    }
}