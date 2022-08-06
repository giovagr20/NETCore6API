using System;
using APIAnime.Context;
using APIAnime.Model;
using APIAnime.Services.DTO;
using APIAnime.Services.Mapper;

namespace APIAnime.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly DbContextData _context;
        private readonly AnimeMapper _animeMapper;

        public AnimeService(DbContextData context, AnimeMapper animeMapper)
        {
            _context = context;
            _animeMapper = animeMapper;
        }

        async Task<IEnumerable<AnimeDTO>> IAnimeService.GetAnimeDTO()
        {
            IEnumerable<AnimeModel> animes = _context.Set<AnimeModel>();

            return await _animeMapper.listModelToListDto(animes);
        }

        async Task<AnimeDTO> IAnimeService.GetAnimeDTOById(int id)
        {
            if (id <= 0)
            {
                return new AnimeDTO();
            }

            var anime = await _context.Anime.FindAsync(id);

            if (anime == null)
            {
                return new AnimeDTO();
            }

            var animeDTO = await _animeMapper.ModelToDto(anime);

            return animeDTO;

        }

        async Task IAnimeService.SaveAnimeDTO(AnimeDTO anime)
        {
            if (anime == null)
            {
                throw new NotImplementedException("Deben enviar la informacion completa");
            }

            AnimeModel animeModel = await _animeMapper.DtoToModel(anime);

            if (animeModel == null )
            {
                throw new NotImplementedException("Ocurrio un error");
            }

            await _context.Anime.AddAsync(animeModel);

            await _context.SaveChangesAsync();

        }
    }
}

