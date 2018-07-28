using System;
using System.Collections.Generic;
using System.Text;
using WebChat.Domain.Core;
using WebChat.Domain.Interfaces;

namespace WebChat.Infrastructure.Data
{
    class UserRepository : IUserRepository
    {
        private ChatContext Db

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUserList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
