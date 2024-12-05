using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gametopia.Contracts.DTOs;

namespace Gametopia.Contracts.SteamIntegration.SteamGamesService
{
    public class SteamGamesResponse
    {
        public List<GameDto> Games { get; set; } = new List<GameDto> { };
    }
}
