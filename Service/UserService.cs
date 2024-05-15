namespace Comparing_Apis.Service
{
    public class UserService : IUserService
    {
        public User GetUser(int userId)
        {
            // Simulate retrieving a user
            return new User
            {
                UserId = userId,
                Name = "John Doe",
                Email = "john.doe@example.com"
            };
        }

        public int AddUser(string name, string email)
        {
            // Simulate adding a user and returning the userId
            return 1; // Dummy userId
        }
    }
}
