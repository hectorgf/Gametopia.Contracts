using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs
{
    public class ProfileUpdateDto
    {
        public string SteamUser { get; set; } = string.Empty;
        public string Nick { get; set; } = string.Empty;
    }

}