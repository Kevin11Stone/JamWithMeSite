using JamWithMeSite.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamWithMeSite.Data.Models
{
    /// <summary>
    /// Represents a single post reply object.
    /// </summary>
    public class PostReply
    {

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual JamWithMeSiteUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
