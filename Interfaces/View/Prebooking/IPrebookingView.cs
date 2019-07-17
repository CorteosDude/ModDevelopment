using JavelinBL2;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Prebooking
{
    /// <summary>
    /// интерфейс для отрисовки дополнительных представлений на пребукинге
    /// </summary>
    public interface IPrebookingView : IController
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
