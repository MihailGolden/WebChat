using System;
using System.Collections.Generic;
using WebChat.Domain.Core;

namespace WebChat.Domain.Interfaces
{
    public interface IUserRepository: IDisposable
    {
        IEnumerable<User> GetUserList();
        User GetUser(int id);
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }
}
