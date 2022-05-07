using TSDC.Core.Domain.Master.Enums;

namespace TSDC.SharedMvc.Master.Models
{
    public class BaseSearchModel
    {
        public string? Keywords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public ActiveStatus? Status { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
