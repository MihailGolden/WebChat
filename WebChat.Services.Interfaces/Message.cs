using System;
using WebChat.Domain.Core;

namespace WebChat.Services.Interfaces
{
    public interface Message
    {
        void SendMessage(User user);
    }
}
