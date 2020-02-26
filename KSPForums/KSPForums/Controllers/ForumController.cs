using System;
using System.Collections.Generic;
using System.Linq;
using KSPForums.Data;
using KSPForums.Data.Models;
using KSPForums.Models.Forum;
using KSPForums.Models.Post;
using Microsoft.AspNetCore.Mvc;

namespace KSPForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postServices;

        public ForumController(IForum forumService, IPost postServices)
        {
            _forumService = forumService;
            _postServices = postServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<ForumListingModel> forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel { 
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

        // find specific forum using id
        #region for forum Topic
        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumService.GetById(id);
            var posts = _postServices.GetFilteredPosts(forum, searchQuery).ToList();
            

            var postListings = posts.Select(post => new PostListingModel { 
                
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                DatePosted  = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum =  BuildForumListing(post)
                
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };
            return View(model);
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;

            return BuildForumListing(forum);
        }
        private ForumListingModel BuildForumListing(Forum forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
        #endregion

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery });
        }
    }
}