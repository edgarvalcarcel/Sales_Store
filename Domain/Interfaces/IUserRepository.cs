using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUSers();
        User GetUserById(int Id);
        User Upsert(User author);
    }
}
