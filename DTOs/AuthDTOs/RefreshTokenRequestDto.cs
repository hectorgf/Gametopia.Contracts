using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs.AuthDTOs
{
    /// <summary>
    /// Data Transfer Object for refresh token requests.
    /// Contains the information required to obtain a new access token using a refresh token.
    /// </summary>
    public class RefreshTokenRequestDto
    {
        /// <summary>
        /// Gets or sets the username associated with the refresh token.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the refresh token used to request a new access token.
        /// </summary>
        public string RefreshToken { get; set; } = string.Empty;
    }
}
