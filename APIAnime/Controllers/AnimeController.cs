using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAnime.Services;
using APIAnime.Services.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIAnime.Controllers
{
    [Route("api/[controller]")]
    public class AnimeController : Controller
    {

        private readonly IAnimeService _animeService;

        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }



        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<AnimeDTO>> Get()
        {
            return await _animeService.GetAnimeDTO();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<AnimeDTO> GetById(int id)
        {
            return await _animeService.GetAnimeDTOById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

