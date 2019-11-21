using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamWithMeSite.Data;
using JamWithMeSite.Models;
using JamWithMeSite.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace JamWithMeSite.Controllers
{
    public class ForumController : Controller
    {

        private readonly IForum _forumService;
        private readonly IPost _postService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var forums = _forumService
                .GetAll()
                .Select(forum => new ForumListingModel
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
                });


            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }



        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = forum.Posts;
            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                Author = post.User.UserName,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)
            });
            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };
            return View(model);

        }

    }
}