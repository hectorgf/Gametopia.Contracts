using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gametopia.Contracts.DTOs
{
    public class ReportDto
    {
        public string Reason { get; set; } = null!;
        public string? Comment { get; set; }
    }
}
