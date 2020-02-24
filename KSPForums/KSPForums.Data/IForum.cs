using KSPForums.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KSPForums.Data
{
    public interface IForum
    {
        public Forum GetById(int id);
        public IEnumerable<Forum> GetAll();
        public IEnumerable<ApplicationUser> GetAllActiveUsers();

        public Task Create(Forum forum);
        public Task Delete(int forumId);
        public Task UpdateForumTitle(int forumId, string newTitle);
        public Task UpdateForumDescription (int forumId, string newDescription);
        
    }
}
