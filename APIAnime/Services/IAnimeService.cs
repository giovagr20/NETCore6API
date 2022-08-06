using System;
using APIAnime.Services.DTO;

namespace APIAnime.Services
{
    public interface IAnimeService
    {
        Task<IEnumerable<AnimeDTO>> GetAnimeDTO();

        Task<AnimeDTO> GetAnimeDTOById(int id);

        Task SaveAnimeDTO(AnimeDTO anime);


    }
}

