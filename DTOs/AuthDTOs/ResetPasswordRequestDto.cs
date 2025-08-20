using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs.AuthDTOs
{
    /// <summary>
    /// Data Transfer Object for password reset requests.
    /// Contains the information required to reset a user's password.
    /// </summary>
    public class ResetPasswordRequestDto
    {
        /// <summary>
        /// Gets or sets the email address of the user requesting the password reset.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the token used to authorize the password reset.
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the new password to be set for the user.
        /// </summary>
        public string NewPassword { get; set; } = string.Empty;
    }
}