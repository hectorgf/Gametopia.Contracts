using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs.Profile
{
    public class ProfileUpdateRequestDto
    {
        public string SteamUser { get; set; } = string.Empty;
        public string Nick { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}