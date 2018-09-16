using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FribraryApi.Models;
using FribraryApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribraryApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Songs")]
    public class SongsController : Controller
    {

        private readonly ISongsService _songService;

        public SongsController(ISongsService songService)
        {
            _songService = songService;
        }

        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var queryResults = _songService.GetAll();

            var ResponseModel = new List<SongViewModel>();

            if (queryResults.ToList().Count > 0)
            {
                foreach (var result in queryResults)
                {
                    var newModel = new SongViewModel()
                    {
                        Id = result.Id,
                        Name = result.Name,
                        Artist = new ArtistViewModel()
                        {
                            Id = result.Artist.Id,
                            Name = result.Artist.Name
                        }
                    };
                    ResponseModel.Add(newModel);
                }
            }

            return Ok(ResponseModel);
        }

        // GET: api/Songs/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Songs
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
