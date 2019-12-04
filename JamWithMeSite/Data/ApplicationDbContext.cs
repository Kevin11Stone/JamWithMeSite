using System;
using System.Collections.Generic;
using System.Text;
using JamWithMeSite.Areas.Identity.Data;
using JamWithMeSite.Data.Models;
using JamWithMeSite.Models;
using JamWithMeSite.Models.Forum;
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

        public DbSet<JamWithMeSiteUser> JamWithMeSiteUsers { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostsReplies { get; set; }



    }
}
