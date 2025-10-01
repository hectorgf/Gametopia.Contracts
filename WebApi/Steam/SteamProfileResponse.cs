using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gametopia.Contracts.WebApi.Steam
{
    public class SteamProfileResponse
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }
        [JsonPropertyName("avatar")]
        public string AvatarUrl { get; set; }
        [JsonPropertyName("profileurl")]
        public string ProfileUrl { get; set; }
        [JsonPropertyName("personaname")]
        public string DisplayName { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<string> GameIds { get; set; } = new List<string>();
        public List<string> GameNames { get; set; } = new List<string>();
        public int TotalGamesCount { get; set; }
        public int TotalPlaytimeMinutes { get; set; }
    }
}
