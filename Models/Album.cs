using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class Album
    {
        public Album()
        {
            AlbumPhotos = new HashSet<AlbumPhoto>();
            Events = new HashSet<Event>();
        }

        public int AlbumId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<AlbumPhoto> AlbumPhotos { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
