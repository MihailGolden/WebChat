using System;
using System.Collections.Generic;
using System.Text;

namespace WebChat.Domain.Core
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public List<User> Users { get; set; }
    }
}
