using Kumustagram_API.DatabaseContext;
using Kumustagram_API.Models;
using Kumustagram_API.Repositories.Interfaces;


namespace Kumustagram_API.Repositories.Implementations
{
    public class UserRepository : IUser
    {
        private readonly KumustagramDbContext _context;

        public UserRepository(KumustagramDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            User user = _context.Users.Where(x => x.UserId == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found!");
            }

            return user;
        }

        public User GetUserByEmail(string email) 
        {
            User user = _context.Users.Where(x => x.Email == email).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            return user;
        }

        public User GetUserByResetPasswordToken(string resetPasswordToken) 
        {
            User user = _context.Users.Where(x => x.ResetPasswordToken == resetPasswordToken).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            return user;
        }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            User _user = _context.Users.Where(x => x.UserId == user.UserId).FirstOrDefault();
            if (_user == null)
            {
                throw new Exception("User not found!");
            }

            else { 
                if (user.Name != null) { _user.Name = user.Name; }
                if (user.Avatar != null) { _user.Avatar = user.Avatar; }
                if (user.Email != null) { _user.Email = user.Email; }
                if (user.Password != null) { _user.Password = user.Password; }

                _context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            User _user = _context.Users.Where(x => id == x.UserId).FirstOrDefault();
            if (_user == null) { throw new Exception("User not found!"); }

            _context.Users.Remove(_user);
            _context.SaveChanges();
        }
    }
}
