using JamWithMeSite.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using JamWithMeSite.Models.Forum;
using System.Linq;
using System.Threading.Tasks;
using JamWithMeSite.Models;

namespace JamWithMeSite.Data.Models
{
    /// <summary>
    /// Represents a single post object. 
    /// </summary>
    public class Post
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual JamWithMeSiteUser User { get; set; }
        public virtual Forum Forum { get; set; }

        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}
