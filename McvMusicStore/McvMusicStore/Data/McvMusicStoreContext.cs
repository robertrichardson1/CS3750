using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace McvMusicStore.Models
{
    public class McvMusicStoreContext : DbContext
    {
        public McvMusicStoreContext (DbContextOptions<McvMusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<McvMusicStore.Models.Song> Song { get; set; }
    }
}
