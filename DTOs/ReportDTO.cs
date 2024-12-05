using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gametopia.Contracts.Enums.UserRelations;

namespace Gametopia.Contracts.DTOs
{
    public class ReportDto
    {
        public ReportReason Reason { get; set; } = ReportReason.None;
        public string? Comment { get; set; }
    }
}
