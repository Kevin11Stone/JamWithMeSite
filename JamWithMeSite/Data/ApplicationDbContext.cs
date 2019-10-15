using System;
using System.Collections.Generic;
using System.Text;
using JamWithMeSite.Areas.Identity.Data;
using JamWithMeSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JamWithMeSite.Data
{

    public class ApplicationDbContext : IdentityDbContext<JamWithMeSiteUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Musician> Musicians { get; set; }



    }
}
