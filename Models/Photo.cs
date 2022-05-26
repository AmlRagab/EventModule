using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class Photo
    {
        public Photo()
        {
            AlbumPhotos = new HashSet<AlbumPhoto>();
        }

        public int PhotoId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AlbumPhoto> AlbumPhotos { get; set; }
    }
}
