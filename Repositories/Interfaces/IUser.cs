using Kumustagram_API.Models;

namespace Kumustagram_API.Repositories.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByEmail(string email);
        User GetUserByResetPasswordToken(string resetPasswordToken);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
