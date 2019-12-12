using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Algorand.Tools.Api.Models
{
    public class AssetRoot
    {
        [JsonPropertyName("assets")]
        public List<AssetMain> Assets { get; set; }
    }
}