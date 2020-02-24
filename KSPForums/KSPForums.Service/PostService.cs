using KSPForums.Data;
using KSPForums.Data.Models;
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

        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public IPost GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        Task IPost.Add(Post post)
        {
            throw new NotImplementedException();
        }

        Task IPost.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task IPost.EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Post> IPost.GetAll()
        {
            throw new NotImplementedException();
        }

        IPost IPost.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Post> IPost.GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Post> IPost.GetPostByForum(int id)
        {
            var posts = _context.Forums
                .Where(forum => forum.Id == id).First()
                .Posts;

            return posts;
        }

       
    }
}
