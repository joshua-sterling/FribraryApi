using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FribraryApi.Models
{
    public class SongPostModel
    {
        public string Name { get; set; }
        public ArtistPostModel Artist { get; set; }
    }
}
