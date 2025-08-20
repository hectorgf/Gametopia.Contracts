using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.Enums
{
    /// <summary>
    /// Provides common enumerations and types used across the application.
    /// </summary>
    public class Commons
    {
        /// <summary>
        /// Specifies the intended audience or integration context for certain features.
        /// </summary>
        public enum AudienceEnum
        {
            /// <summary>
            /// No specific audience or integration.
            /// </summary>
            None = 0,

            /// <summary>
            /// Integration with the Steam platform.
            /// </summary>
            SteamIntegration,

            /// <summary>
            /// Game storage or management context.
            /// </summary>
            GameStorage
        }
    }
}