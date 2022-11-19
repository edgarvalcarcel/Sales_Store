using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public SalesStoreContext _context;
        public UserRepository(SalesStoreContext context)
        {
            _context = context;
        }

        public User GetUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUSers()
        {
            throw new NotImplementedException();
        }

        public User Upsert(User author)
        {
            throw new NotImplementedException();
        }
    }
}
