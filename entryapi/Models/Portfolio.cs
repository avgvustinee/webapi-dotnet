using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace entryapi.Models
{
    [Table("Portfolio")]
    // joint table class
    public class Portfolio
    {
        // foreign key to AppUser
        public string AppUserId { get; set; }

        // foreign key to Stock
        public int StockId { get; set; }
        // navigation property
        public AppUser AppUser { get; set; }
        public Stock Stock { get; set; }

    }
}