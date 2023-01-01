using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicMarket.Core.Models;

namespace MusicMarket.Core.Repositories
{
    public interface IMusicRepository : IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<Music> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
    }
}