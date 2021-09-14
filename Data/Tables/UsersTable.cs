using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RieltorComp.Models;

namespace RieltorComp.Data.Tables
{
    public class UsersTable
    {
        private readonly ApplicationContext _context;

        public UsersTable(ApplicationContext context)
        {
            _context = context;
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }

        public Users GetUser(string Username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == Username);
        }

        public void CreateUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void UpdateUsers(List<Users> users)
        {
            _context.Users.UpdateRange(users);
            _context.SaveChanges();
        }

        public void DeleteUser(Users user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}