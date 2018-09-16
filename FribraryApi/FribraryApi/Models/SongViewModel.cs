using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FribraryApi.Models
{
    public class SongViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ArtistViewModel Artist { get; set; }
    }
}
