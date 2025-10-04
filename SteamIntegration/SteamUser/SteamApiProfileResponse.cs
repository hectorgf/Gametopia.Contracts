using Gametopia.Contracts.Utils.Converters;
using System.Text.Json.Serialization;

namespace Gametopia.Contracts.SteamIntegration.SteamUser
{
    public class SteamApiProfileResponse
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }
        
        [JsonPropertyName("avatar")]
        public string AvatarUrl { get; set; }
        
        [JsonPropertyName("profileurl")]
        public string ProfileUrl { get; set; }
        
        [JsonPropertyName("personaname")]
        public string DisplayName { get; set; }

        [JsonPropertyName("communityvisibilitystate")]
        public int IsPrivate { get; set; }
        
        [JsonPropertyName("lastlogoff")]
        [JsonConverter(typeof(UnixTimestampToDateTimeConverter))]
        public DateTime LastLogOff { get; set; }
    }
}