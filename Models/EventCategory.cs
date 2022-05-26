using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class EventCategory
    {
        public int? CategoryId { get; set; }
        public int? EventId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Event Event { get; set; }
    }
}
