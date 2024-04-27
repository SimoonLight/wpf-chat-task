using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_chat_task.Models
{

    public class Database
    {
        public static List<Message> Messages = new List<Message>();
        public static List<_Time> times = new List<_Time>();
    }

    public class _Time
    {
        public string Time { get; set; }
        public _Time()
        {
            this.Time = string.Empty;
        }

        public _Time(string time)
        {
            this.Time = time;
        }

        public override string ToString()
        {
            return $"{this.Time}";
        }
    }

    public class Message
    {
        public string Text { get; set; }

        public Message()
        {
            this.Text = string.Empty;
        }

        public Message(string text)
        {
            this.Text = text;
        }

        public override string ToString()
        {
            return $"{this.Text}";
        }
    }
}
