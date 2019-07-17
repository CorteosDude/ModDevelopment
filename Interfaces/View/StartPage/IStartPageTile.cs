using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.StartPage
{
    /// <summary>
    /// данный интерфейс должна имплементировать плитка для стартовой страницы - накладывается на контроллер вьюхи
    /// </summary>
    public interface IStartPageTile
    {
        bool IsApplicable(ControllerContainer bl);

        /// <summary>
        /// получить приоритет для отображения элемента - больше - быстрее
        /// </summary>
        /// <returns></returns>
        int GetPriority();

        ActionResult RenderTile();
    }
}
