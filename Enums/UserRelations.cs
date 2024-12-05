using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.Enums
{
    public class UserRelations
    {
        public enum UserRelationType
        {
            None = 0,
            Blocked = 1,
            Followed = 2,
            Reported = 3
        }

        public enum ReportReason
        {
            None = 0,
            Spam = 1,
            Harassment = 2,
            HateSpeech = 3,
            InappropriateContent = 4,
            Other = 5
        }
    }
}
