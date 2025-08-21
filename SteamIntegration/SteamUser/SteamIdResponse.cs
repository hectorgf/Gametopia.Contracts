using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.SteamIntegration.SteamUser
{
    public class SteamIdResponse
    {
        public string SteamId { get; set; } = string.Empty;
        public bool Success { get; set; } = false;
    }
}
