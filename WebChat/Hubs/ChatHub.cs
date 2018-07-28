using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WebChat.Models;

namespace WebChat.Hubs
{
    public class ChatHub : Hub
    {

        private static List<User> Users = new List<User>();

        //sending messages
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }

        //connecting a new user
        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

            if (!Users.Any(x => x.ConnectionId == id))
            {
                Users.Add(new User {ConnectionId = id, Name = userName});

                //sending message for current user
                Clients.Caller.onConnected(id, userName, Users);

                //sending massages for all users exeptnig current user
                Clients.AllExcept(id).onNewUserConnected(id, userName);
            }
        }

        //disconnecting a user
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = Users.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (item != null)
            {
                Users.Remove(item);
                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.Name);
            }

            return base.OnDisconnected(stopCalled);
        }
    }
}