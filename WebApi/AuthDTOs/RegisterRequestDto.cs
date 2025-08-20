using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.WebApi.AuthDTOs
{
    /// <summary>
    /// Data Transfer Object for user registration requests.
    /// Contains the information required to register a new user.
    /// </summary>
    public class RegisterRequestDto
    {
        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the nickname of the user.
        /// </summary>
        public string Nick { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password for the new user account.
        /// </summary>
        public string Password { get; set; } = string.Empty;

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