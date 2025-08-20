using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.Enums
{
    /// <summary>
    /// Provides enumerations related to user relationships and reporting within the application.
    /// </summary>
    public class UserRelations
    {
        /// <summary>
        /// Specifies the type of relationship between users.
        /// </summary>
        public enum UserRelationType
        {
            /// <summary>
            /// No specific relationship.
            /// </summary>
            None = 0,

            /// <summary>
            /// The user is blocked.
            /// </summary>
            Blocked = 1,

            /// <summary>
            /// The user is followed.
            /// </summary>
            Followed = 2,

            /// <summary>
            /// The user is reported.
            /// </summary>
            Reported = 3
        }

        /// <summary>
        /// Specifies the reason for reporting a user.
        /// </summary>
        public enum ReportReason
        {
            /// <summary>
            /// No specific reason.
            /// </summary>
            None = 0,

            /// <summary>
            /// The user is reported for spam.
            /// </summary>
            Spam = 1,

            /// <summary>
            /// The user is reported for harassment.
            /// </summary>
            Harassment = 2,

            /// <summary>
            /// The user is reported for hate speech.
            /// </summary>
            HateSpeech = 3,

            /// <summary>
            /// The user is reported for inappropriate content.
            /// </summary>
            InappropriateContent = 4,

            /// <summary>
            /// The user is reported for another reason.
            /// </summary>
            Other = 5
        }
    }
}
