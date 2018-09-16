using AutoMapper;
using FribraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FribraryApi.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Song, SongViewModel>();
            CreateMap<Artist, ArtistViewModel>();
        }
    }
}
