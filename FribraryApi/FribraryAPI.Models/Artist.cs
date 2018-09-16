using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryAPI.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
