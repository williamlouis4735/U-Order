using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
  

    public class UserService
    {
        private DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public UserDO Insert(UserDO user)
        {
            _context.Set<UserDO>().Add(user);
            _context.SaveChanges();
            return user;
        }
        public IEnumerable<UserDO> GetAll()
        {
          

            return _context.Set<UserDO>();
        }
    }
}
