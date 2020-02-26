using KSPForums.Data;
using KSPForums.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPForums.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        

        //for get all post
        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                    .Include(post => post.User)
                    .Include(post => post.Replies)
                        .ThenInclude(reply => reply.User)
                    .Include(post => post.Forum);
        }

        //for get post via id
        public Post GetById(int id)
        {
            var post = _context.Posts.Where(post => post.Id == id)
                .Include(post => post.User)
                .Include(post => post.Replies)
                    .ThenInclude(reply => reply.User)
                .Include(post => post.Forum)
                .First();
            return post;
        }

      


        // for getting latest post
        public IEnumerable<Post> GetLatestPosts(int nPosts)
        {
          return GetAll().OrderByDescending(post => post.Created).AsEnumerable().Take(nPosts);
        }

        // for adding new post in Post table
        async Task  IPost.Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }

        //for delete post
        Task IPost.Delete(int id)
        {
            throw new NotImplementedException();
        }

        //For edit post content
        Task IPost.EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        // for get all post
        IEnumerable<Post> IPost.GetAll()
        {
            throw new NotImplementedException();
        }


        // for getting all post via search query
        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
           return GetAll().Where(post => post.Title.Contains(searchQuery) || post.Content.Contains(searchQuery));
        }
        IEnumerable<Post> IPost.GetFilteredPosts(Forum forum, string searchQuery)
        {
           return string.IsNullOrEmpty(searchQuery)? forum.Posts :
                    forum.Posts.Where(post => post.Title.Contains(searchQuery) || post.Content.Contains(searchQuery));

        }

        // for get post by forum id
        IEnumerable<Post> IPost.GetPostByForum(int id)
        {
            var posts = _context.Forums
                .Where(forum => forum.Id == id).First()
                .Posts;

            return posts;
        }

       
    }
}
