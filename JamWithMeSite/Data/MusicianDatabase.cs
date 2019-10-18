using JamWithMeSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamWithMeSite.Data
{
    public static class MusicianDatabase
    {

        /// <summary>
        /// Adds musician to the database. 
        /// </summary>
        /// <param name="m">The Musician to add</param>
        /// <param name="context">The database context to use</param>
        /// <returns></returns>
        public static async Task<Musician> Add(Musician m, ApplicationDbContext context)
        {
            await context.AddAsync(m);
            await context.SaveChangesAsync();
            return m;
        }
        public static async Task Delete(int id, ApplicationDbContext context)
        {
            Musician m = new Musician()
            {
                UserId = id
            };

            context.Entry(m).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }


        public static async Task<List<Musician>> GetAllMusicians(ApplicationDbContext context)
        {
            List<Musician> musiciansList = await context.Musicians
                                                    .OrderBy(m => m.Username)
                                                    .ToListAsync();
            return musiciansList;
        }

        public static async Task<Musician> GetMusicianById(int id, ApplicationDbContext context)
        {
            Musician musicianById = await (from m in context.Musicians
                                                    where m.UserId == id
                                                    select m).SingleOrDefaultAsync();

            return musicianById;
        }

    }
}
