using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gametopia.Contracts.SteamIntegration.SteamUser
{
    public class SteamIdResponse
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; } = string.Empty;
        [JsonPropertyName("success")]
        public bool Success { get; set; } = false;
    }
}
