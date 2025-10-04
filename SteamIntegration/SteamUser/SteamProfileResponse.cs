using Gametopia.Contracts.Utils.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gametopia.Contracts.SteamIntegration.SteamUser
{
    public class SteamProfileResponse
    {
        public string SteamId { get; set; }
        public string AvatarUrl { get; set; }
        public string ProfileUrl { get; set; }
        public string DisplayName { get; set; }
        public int IsPrivate { get; set; }
        public DateTime LastLogOff { get; set; }
    }
}
