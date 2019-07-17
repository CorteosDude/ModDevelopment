using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Queues
{
    /// <summary>
    /// очередь, к которой можно применить фильтрацию по клиенту
    /// </summary>
    public interface IQueueSupportingClientFilter
    {
        /// <summary>
        /// устанавливает определенную группу клиентов в фильтр
        /// </summary>
        /// <param name="id_ClientGroup"></param>
        void SetClientGroupForFilter(int id_ClientGroup);
    }
}
