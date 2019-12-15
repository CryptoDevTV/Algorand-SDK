using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class NodeStatus
    {
        [JsonPropertyName("catchupTime")]
        public long CatchupTime { get; set; }

        [JsonPropertyName("hasSyncedSinceStartup")]
        public bool HasSyncedSinceStartup { get; set; }

        [JsonPropertyName("lastConsensusVersion")]
        public string LastConsensusVersion { get; set; }

        [JsonPropertyName("lastRound")]
        public long LastRound { get; set; }

        [JsonPropertyName("nextConsensusVersion")]
        public string NextConsensusVersion { get; set; }

        [JsonPropertyName("nextConsensusVersionRound")]
        public long NextConsensusVersionRound { get; set; }

        [JsonPropertyName("nextConsensusVersionSupported")]
        public bool NextConsensusVersionSupported { get; set; }

        [JsonPropertyName("timeSinceLastRound")]
        public long TimeSinceLastRound { get; set; }
    }
}