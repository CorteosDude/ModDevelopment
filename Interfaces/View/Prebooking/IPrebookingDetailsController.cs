using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Prebooking
{
    /// <summary>
    /// интерфейс, который должен поддерживать контроллер для вывода деталей пребукинга
    /// </summary>
    public interface IPrebookingDetailsController : Marker.ISupportsRequestMarker
    {
        /// <summary>
        /// партиалка, отображающая детали пребукинга
        /// </summary>
        /// <returns></returns>
        ActionResult RenderPrebookingDetails(object req);

        /// <summary>
        /// рисует хлебные крошки на странице пребукинга
        /// </summary>
        /// <returns></returns>
        ActionResult RenderPrebookingBreadcrumbs(string requestID);
    }
}
