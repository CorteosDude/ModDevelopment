using JavelinBL2;
using JavelinView3.Base.InterfacesForOverride._Common;
using JavelinView3.Base.InterfacesForOverride.Queues.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Queues
{
    public interface IQueueMenuItem 
    {
        /// <summary>
        /// возвращает элемент очереди для списка
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        QueueMenuEntry GetMenuItem(ControllerContainer bl);
    }
}
