using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// дополнительные фильтры на страницы представлений
    /// </summary>
    public interface IVariantsExtraFilterView
    {
        /// <summary>
        /// метод отрисовки интерфейса
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        ActionResult RenderView();

        /// <summary>
        /// проверка доступности
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        bool IsApplicable(ControllerContainer bl, string page);
    }
}
