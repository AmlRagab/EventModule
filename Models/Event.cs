using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

#nullable disable

namespace EventModule.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string ArabicTitle { get; set; }
        public string EnglishTilte { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte[] CoverPhoto { get; set; }

        public int? SourceId { get; set; }
        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Source Source { get; set; }
    }
}
