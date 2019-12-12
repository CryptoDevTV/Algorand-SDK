using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Block
    {
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("previousBlockHash")]
        public string PreviousBlockHash { get; set; }

        [JsonPropertyName("seed")]
        public string Seed { get; set; }

        [JsonPropertyName("proposer")]
        public string Proposer { get; set; }

        [JsonPropertyName("round")]
        public int Round { get; set; }

        [JsonPropertyName("period")]
        public int Period { get; set; }

        [JsonPropertyName("txnRoot")]
        public string TxnRoot { get; set; }

        [JsonPropertyName("reward")]
        public int Reward { get; set; }

        [JsonPropertyName("rate")]
        public int Rate { get; set; }

        [JsonPropertyName("frac")]
        public long Frac { get; set; }

        [JsonPropertyName("txns")]
        public TransactionRoot Txns { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("currentProtocol")]
        public string CurrentProtocol { get; set; }

        [JsonPropertyName("nextProtocol")]
        public string NextProtocol { get; set; }

        [JsonPropertyName("nextProtocolApprovals")]
        public int NextProtocolApprovals { get; set; }

        [JsonPropertyName("nextProtocolVoteBefore")]
        public int NextProtocolVoteBefore { get; set; }

        [JsonPropertyName("nextProtocolSwitchOn")]
        public int NextProtocolSwitchOn { get; set; }

        [JsonPropertyName("upgradePropose")]
        public string UpgradePropose { get; set; }

        [JsonPropertyName("upgradeApprove")]
        public bool UgradeApprove { get; set; }
    }
}