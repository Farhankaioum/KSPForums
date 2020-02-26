using KSPForums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KSPForums.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(Forum forum, string searchQuery);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        public IEnumerable<Post> GetPostByForum(int id);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        IEnumerable<Post> GetLatestPosts(int nPosts);
    }
}
