using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.WebApi.Profile
{
    /// <summary>
    /// Data Transfer Object for profile update requests.
    /// Contains the information required to update a user's profile.
    /// </summary>
    public class ProfileUpdateRequestDto
    {
        /// <summary>
        /// Gets or sets the Steam username associated with the user.
        /// </summary>
        public string SteamUser { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the nickname of the user.
        /// </summary>
        public string Nick { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the second name of the user.
        /// </summary>
        public string SecondName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string LastName { get; set; } = string.Empty;
    }
}