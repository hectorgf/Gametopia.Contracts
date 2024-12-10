using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.WebApi.GametopiaUser
{
    public class ProfileUpdateRequest
    {
        public string SteamUser { get; set; }
        public string Nick { get; set; }
    }

}