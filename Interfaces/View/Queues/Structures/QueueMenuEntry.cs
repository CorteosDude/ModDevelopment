using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Queues.Structures
{
    /// <summary>
    /// элемент меню для очереди
    /// </summary>
    public class QueueMenuEntry
    {
        /// <summary>
        /// куда кидать пользователя при клике в меню
        /// </summary>
        public string Url { get; set; }

        public string Title { get; set; }

        public QueueMenuEntry()
        {

        }

        public QueueMenuEntry(string url, string title) : this()
        {
            Url = url;
            Title = title;
        }
    }
}
