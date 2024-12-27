using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Gametopia.Contracts.Enums.Commons;

namespace Gametopia.Contracts.Utils
{
    public static class EnumConverter
    {
        public static string AudienceEnumConverter(AudienceEnum audienceEnum)
        {
            switch (audienceEnum)
            {
                case AudienceEnum.None:
                    throw new ArgumentNullException(nameof(audienceEnum));
                case AudienceEnum.SteamIntegration:
                    return "Gametopia.SteamIntegration";
                    case AudienceEnum.GameStorage:
                    return "Gametopia.GameStorage";
                default:
                    throw new ArgumentNullException(nameof(audienceEnum));
            }
        }
    }
}
