using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Layout
{
    /// <summary>
    /// дополнительные элементы, которые рисуются на страницах лейаута
    /// </summary>
    public interface IExtraLayoutSection : IController
    {
        ActionResult RenderHeaderSection(ControllerContainer root, bool isMobile);
    }
}
