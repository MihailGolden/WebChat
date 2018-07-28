using System;
using System.Collections.Generic;
using System.Text;

namespace WebChat.Domain.Core
{
    class Message
    {
        public int Id { get; set; }
        public string text { get; set; }
        public DateTime time { get; set; }
        public User user { get; set; }
    }
}
