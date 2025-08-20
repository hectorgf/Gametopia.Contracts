using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs
{
    /// <summary>
    /// Data Transfer Object representing a game.
    /// Contains basic information about a game.
    /// </summary>
    public class GameDto
    {
        /// <summary>
        /// Gets or sets the unique application identifier for the game.
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets the name of the game.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the game's icon.
        /// </summary>
        public string IconUrl { get; set; } = string.Empty;
    }
}
