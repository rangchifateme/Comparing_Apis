using System.ServiceModel;

namespace Comparing_Apis.Service
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUser(int userId);

        [OperationContract]
        int AddUser(string name, string email);
    }
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
