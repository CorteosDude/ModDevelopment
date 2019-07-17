using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    /// <summary>
    /// уведомления в шапке лейаута, например, о замещении
    /// </summary>
    public interface ILayoutHeaderNotification : IController
    {
        ActionResult RenderHeaderNotification();
    }
}
