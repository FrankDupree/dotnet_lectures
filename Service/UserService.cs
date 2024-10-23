using Daniel.Models;

namespace Daniel.Service
{
    public class UserService: IUserservice
    {
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
    }
}
