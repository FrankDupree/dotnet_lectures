using Daniel.Models;

namespace Daniel.Service
{
    public class UserService: IUserservice
    {
        //imagine this is the database records
        private List<UserProfile> userProfiles = new List<UserProfile>();

        public UserService() {

            userProfiles.Add(new UserProfile
            {
                name = "Frank",
                country = "Nigeria",
                tribe = "canada"
            });

            userProfiles.Add(new UserProfile
            {
                name = "Daniel",
                country = "Nigeria",
                tribe = "calarbar"
            });

        }

        public async Task<List<UserProfile>> GetUsers()
        {
            return userProfiles.ToList();
        }

        public async Task<UserProfile> AddUser(UserProfile user)
        {
            userProfiles.Add(user);
            return user;
        }
    }
}
