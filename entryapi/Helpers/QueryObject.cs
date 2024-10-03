using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entryapi.Helpers
{
    public class QueryObject
    {
        public string? Symbol { get; set; } = null;
        public string? CompanyName { get; set; } = null;
        // sorting
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        // pagination
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;

    }
}