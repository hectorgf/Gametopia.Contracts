using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gametopia.Contracts.WebApi;

namespace Gametopia.Contracts.SteamIntegration.SteamGamesService
{
    /// <summary>
    /// Response object containing a list of games retrieved from Steam integration.
    /// </summary>
    public class SteamGamesResponse
    {
        /// <summary>
        /// Gets or sets the list of games associated with the Steam account.
        /// </summary>
        public List<GameDto> Games { get; set; } = new List<GameDto> { };
    }
}
