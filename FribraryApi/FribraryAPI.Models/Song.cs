using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryAPI.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
    }
}
