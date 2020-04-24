using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3analiza.components
{
    class NotificationBuilder : IBuilder
    {
        string author;
        string title;
        DateTime timestamp;
        Category level;
        ConsoleColor color;
        string text;

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, timestamp, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.timestamp = time;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }
    }
}
