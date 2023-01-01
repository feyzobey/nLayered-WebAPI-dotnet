using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicMarket.Core.Models;

namespace MusicMarket.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}