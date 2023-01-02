using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicMarket.Core.Models;
using MusicMarket.Data.Configuration;

namespace MusicMarket.Data
{
    public class MusicMarketDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public MusicMarketDbContext(DbContextOptions<MusicMarketDbContext> options)
            : base(options)
        { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseNpgsql("Host=localhost;Port=5432;Database=MusicMarket;Username=postgres;Password=postgres");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MusicConfiguration());

            builder.ApplyConfiguration(new ArtistConfiguration());

            base.OnModelCreating(builder);
        }
    }
}