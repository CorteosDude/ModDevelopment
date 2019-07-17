using JavelinBL2.Models.CommonReserveModels;
using JavelinBL2.Models.SimpleReserveModels;
using JavelinModelV2.Orders.Simple;

namespace JavelinBL2.Interfaces.SimpleReserves
{
    /// <summary>
    /// интерфейс, который должны имплементировать контроллеры действий над простым заказом
    /// </summary>
    public interface ISimpleReserveAction
    {
        /// <summary>
        /// возвращает параметры кнопки, основываясь на параметрах заказа - если действие недоступно, возвращает null
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        SimpleReserveActionInfo GetActionInfo(SimpleReserve reserve);

        /// <summary>
        /// определяет, можно ли показывать кнопку экшна конечному клиенту на основании статусов заказов
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        bool AllowShowingActionToEndCustomer(SimpleReserve reserve);

        /// <summary>
        /// основной метод, который выполняет действие над заказом
        /// </summary>
        /// <param name="id_Reserve"></param>
        /// <returns></returns>
        ReserveActionResult PerformAction(SimpleReserveManagementParameters parameters);
    }
}
