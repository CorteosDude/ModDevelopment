using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    public interface ILayoutSidebarItem : IModApplicable
    {
        /// <summary>
        /// иконка для боковой панели
        /// </summary>
        /// <returns></returns>
        string GetIcon();

        /// <summary>
        /// рисует контент для сайдбара
        /// </summary>
        /// <returns></returns>
        ActionResult RenderContent();
    }
}
