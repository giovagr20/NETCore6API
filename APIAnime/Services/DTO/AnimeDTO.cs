using System;
namespace APIAnime.Services.DTO
{
    public class AnimeDTO
    {
        public AnimeDTO()
        {
        }

        public int Id { get; set; }

        public string AnimeName { get; set; }

        public string Description { get; set; }

        public bool HasSeasons { get; set; }

        public int TotalSeasons { get; set; }

        public string PictureUrl { get; set; }

    }
}

