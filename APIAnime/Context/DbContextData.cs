using System;
using APIAnime.Model;
using Microsoft.EntityFrameworkCore;

namespace APIAnime.Context
{
    public class DbContextData : DbContext 
    {
        public DbContextData(DbContextOptions<DbContextData> options) : base (options)
        {
        }

        public DbSet<AnimeModel> Anime { get; set; }
    }
}

