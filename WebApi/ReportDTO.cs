using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gametopia.Contracts.Enums.UserRelations;

namespace Gametopia.Contracts.WebApi
{
    /// <summary>
    /// Data Transfer Object for user reports.
    /// Contains the reason for the report and an optional comment.
    /// </summary>
    public class ReportDto
    {
        /// <summary>
        /// Gets or sets the reason for reporting the user.
        /// </summary>
        public ReportReason Reason { get; set; } = ReportReason.None;

        /// <summary>
        /// Gets or sets an optional comment providing additional information about the report.
        /// </summary>
        public string? Comment { get; set; }
    }
}
