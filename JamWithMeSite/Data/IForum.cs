using JamWithMeSite.Areas.Identity.Data;
using JamWithMeSite.Data.Models;
using JamWithMeSite.Models;
using JamWithMeSite.Models.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamWithMeSite.Data
{
    public interface IForum
    {

        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<JamWithMeSiteUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
