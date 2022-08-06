using System;
using APIAnime.Model;

namespace APIAnime.Context
{
    public class SeedDb
    {
        private readonly DbContextData _context;

        public SeedDb(DbContextData context)
        {
            _context = context;
        }

        public async Task SeedDbAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            _context.Add(new AnimeModel
            {
                AnimeName = "Naruto Shippuden",
                Description = "Shonen about ninjas",
                HasSeasons = true,
                PictureUrl = "https://lsorg.org/images",
                TotalSeasons = 2
            });

            await _context.SaveChangesAsync();
        }
    }
}

