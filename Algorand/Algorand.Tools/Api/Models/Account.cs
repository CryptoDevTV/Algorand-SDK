using System;
using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class Account
    {
        
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        public double actualAmount;

        /// <summary>
        /// actual amount = Amount / 1e-6
        /// </summary>
        public double ActualAmount 
        {
            get
            {
                actualAmount = Amount / 1000000.0;
                return actualAmount; 
            } 
        }

        [JsonPropertyName("amountwithoutpendingrewards")]
        public long Amountwithoutpendingrewards { get; set; }

        [JsonPropertyName("participation")]
        public Participation Participation { get; set; }

        [JsonPropertyName("pendingrewards")]
        public long Pendingrewards { get; set; }

        [JsonPropertyName("rewards")]
        public long Rewards { get; set; }

        [JsonPropertyName("round")]
        public long Round { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}