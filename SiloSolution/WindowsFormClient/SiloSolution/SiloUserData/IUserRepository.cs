using SiloModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiloData
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);

        User SelectUser(string username);

        User Insert(User user);

        int Update(User user);
    }
}
