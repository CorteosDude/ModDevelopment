using JavelinBL2;
using JavelinModelV2.Orders.Enums;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// Интерфейс для кросс-поиска между жд и авиа
    /// </summary>
    public interface ISearchResultExtensions
    {        
        /// <summary>
        /// проверка доступности
        /// </summary>
        bool IsApplicable(ControllerContainer bl, ReserveTypeEnumeration reserveType);

        /// <summary>
        /// проверка доступности для клиенсткой части
        /// </summary>
        bool IsApplicable(ControllerContainer bl, string page);

        /// <summary>
        /// метод отрисовки интерфейса
        /// </summary>
        ActionResult Render(string requestId);
    }
}
