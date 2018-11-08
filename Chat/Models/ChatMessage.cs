using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class ChatMessage
    {
        public ChatUser User { get; set; }

        //Время сообщения
        public DateTime Date = DateTime.Now;

        //Сообщение
        public string Text = "";

    }
}