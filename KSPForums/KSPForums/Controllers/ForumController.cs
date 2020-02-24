using System.Collections.Generic;
using System.Linq;
using KSPForums.Data;
using KSPForums.Models.Forum;
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
        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = _postServices.GetFilteredPosts(id.ToString());
            //if (forum == null)
            //{
            //    return NotFound();
            //}
            
            return View();
        }
    }
}