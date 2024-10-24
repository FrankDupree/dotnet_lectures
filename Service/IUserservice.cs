using Daniel.Models;

namespace Daniel.Service
{
    public interface IUserservice
    {
        //Daniel read up on async and await c#
        public Task<List<UserProfile>> GetUsers();
        public Task<UserProfile> AddUser(UserProfile user);
    }
}
