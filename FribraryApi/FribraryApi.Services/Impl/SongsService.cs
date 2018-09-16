
using FribraryAPI.Models;
using FribraryApi.Services;
using System;
using System.Collections.Generic;
using System.Text;
using FribraryAPI.EntityFramework;
using FribraryApi.Services.Generic.Impl;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FribraryApi.Services.Impl
{
    public class SongsService : ReadWrite<Song>, ISongsService
    {
        public SongsService(FribraryApiContext context) : base(context)
        {
            
        }

        public override IQueryable<Song> GetAll()
        {
            return _context.Songs.Include(x => x.Artist);
        }
    }
}
