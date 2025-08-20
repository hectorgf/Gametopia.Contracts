using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs.AuthDTOs
{
    /// <summary>
    /// Data Transfer Object for user login requests.
    /// Contains the credentials required to authenticate a user.
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>
        /// Gets or sets the username of the user attempting to log in.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password of the user attempting to log in.
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
