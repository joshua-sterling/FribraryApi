
using FribraryApi.Services.Generic;
using FribraryAPI.Models;
using FribraryApi.Services;
using System;
using System.Collections.Generic;
using System.Text;
using FribraryAPI.EntityFramework;

namespace FribraryApi.Services.Impl
{
    public class SongsService : ReadOnly<Song>, ISongsService
    {
        public SongsService(FribraryApiContext context) : base(context)
        {

        }
    }
}
