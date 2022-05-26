using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class AlbumPhoto
    {
        public int AlbumId { get; set; }
        public int PhotoId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
