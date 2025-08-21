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

        private int _successValue;

        [JsonPropertyName("success")]
        public int SuccessValue
        {
            get => _successValue;
            set
            {
                _successValue = value;
                Success = value == 1;
            }
        }

        [JsonIgnore]
        public bool Success { get; private set; }
    }

}
