using Daniel.Models;

namespace Daniel.Service
{
    public class UserService: IUserservice
    {
        public UserService() { }

        public Task<List<UserProfile>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
