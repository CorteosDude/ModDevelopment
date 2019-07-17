using JavelinBL2;
using JavelinModelV2.Orders.Simple;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.SimpleActions
{
    /// <summary>
    /// Используется для реализации механизма прерывания основного потока выполнения простого действия с заказом (бронирование, выписка и т.п.), 
    /// на уровне контроллера представления, для выполнения дополнительных действий, таких как выбор мест перед выпиской в жд.
    /// </summary>
    public interface IUseSpecificActionForSimpleReserve : IController
    {
        /// <summary>
        /// Проверяет необходимость прерывания основного потока выполнения простого действия с заказом для выполнения дополнительных действий.
        /// </summary>
        bool IsApplicable(ControllerContainer bl, SimpleReserve reserve, string actionType);

        /// <summary>
        /// Точка входа для спец. действия. Возвращает Json со статусом customActionRequired и содержащий доп поля: executeActionUrl, actionEventPrefix
        /// Пример Json:
        /// return Json(new
        /// {
        ///     state = "customActionRequired",
        ///     view,
        ///     reserveStatus = reserve.CurrentState.ToString().ToLower(),
        ///     executeActionUrl = GetExecuteActionUrl(reserve, isInComplexReserve),
        ///     actionEventPrefix = GetActionEventPrefix(),
        /// }, JsonRequestBehavior.AllowGet);
        /// </summary>        
        ActionResult ExecuteSpecificAction(SimpleReserve reserve, bool isInComplexReserve);

        /// <summary>
        /// Возвращает URL для отображения формы дополнительного действия
        /// </summary>
        string GetExecuteActionUrl(SimpleReserve reserve, bool isInComplexReserve);

        /// <summary>
        /// Префикс имени события для клиенсткой части
        /// Используется для генерации событий клиентской части
        /// Примеры событий:
        /// actionEventPrefix + `.ready` - активирует форму доп. действий из внешней функции на клиенте, 
        /// имеет смысл если форма отображена в модальном окне и после отображения надо инициализировать модель vue
        /// actionEventPrefix +'.complete' - Событие вызывается формой доп. действий после завершения всех необходимых операций
        /// и информирует клиенсткую часть о необходимости продолжить выполнение основного flow
        /// </summary>
        string GetActionEventPrefix();

        /// <summary>
        /// Разрешенный тип основного действия
        /// </summary>
        string GetAllowedActionType();
    }
}
