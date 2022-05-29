using _4SemEksamen.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _4SemEksamen.Managers
{
    public class UserManager
    {
        private UserContext _context;
        public UserManager(UserContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }
        public User Get(int id)
        {
            User user = _context.User.Find(id);
            return user;
        }
        public User Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Update(int id, User user)
        {
            user.UserId = id;
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public User Delete(int id)
        {
            User user = _context.User.Find(id);

            _context.User.Remove(user);

            _context.SaveChanges();

            return user;
        }
    }
}
