using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class Source
    {
        public Source()
        {
            Events = new HashSet<Event>();
        }

        public int SourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
