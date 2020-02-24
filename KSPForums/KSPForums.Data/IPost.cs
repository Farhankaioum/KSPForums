using KSPForums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KSPForums.Data
{
    public interface IPost
    {
        IPost GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);

       

    }
}
