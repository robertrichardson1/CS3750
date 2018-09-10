using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace McvMusicStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new McvMusicStoreContext(
                    serviceProvider.GetRequiredService<DbContextOptions<McvMusicStoreContext>>()))
            {
                if (context.Song.Any())
                {
                    return; //DB has been seeded.
                }
                context.Song.AddRange(
                    new Song
                    {
                        Title = "Perfect",
                        ReleaseDate = DateTime.Parse("2017-1-11"),
                        Genre = "Pop",
                        Album = "Divie",
                        Artist = "Ed Sheeran"
                    },

                    new Song
                    {
                        Title = "Speak Life",
                        ReleaseDate = DateTime.Parse("2015-3-13"),
                        Genre = "Gospel Rock",
                        Album = "Eye On It",
                        Artist = "TobyMac"
                    },
                    new Song
                    {
                        Title = "Believer",
                        ReleaseDate = DateTime.Parse("2017-2-23"),
                        Genre = "Alternative Rock",
                        Album = "Evolve",
                        Artist = "Imagine Dragons"
                    },

                    new Song
                    {
                        Title = "The Sound of Silence",
                        ReleaseDate = DateTime.Parse("2015-4-16"),
                        Genre = "Alternative",
                        Album = "Immortalized",
                        Artist = "Disturbed"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
