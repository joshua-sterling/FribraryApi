using FribraryApi.Services.Generic;
using FribraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryApi.Services
{
    public interface ISongsService : IReadOnly<Song>
    {
    }
}
