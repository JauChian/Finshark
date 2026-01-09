using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    // Query parameters for filtering, sorting, and paging
    public class QueryObject
    {
        // Stock symbol filter
        public string? Symbol { get; set; } = null;
        // Company name filter
        public string? CompanyName { get; set; } = null;
        // Sort field
        public string? SortBy { get; set; } = null;
        // Descending sort flag
        public bool IsDecsending { get; set; } = false;
        // Page number (1-based)
        public int PageNumber { get; set; } = 1;
        // Page size
        public int PageSize { get; set; } = 20;
    }
}
