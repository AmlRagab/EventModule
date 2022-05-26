using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
