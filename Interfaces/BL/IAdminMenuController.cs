using JavelinBL2.Controllers.CommonControllers.Subcontrollers.Layout.Structures;
using JavelinModelV2;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс, который должны имплементировать контроллеры админки для того, чтобы быть доступными в меню
    /// </summary>
    public interface IAdminMenuController
    {
        /// <summary>
        /// возвращает признак доступности сервиса для текущего состояния контроллера
        /// </summary>
        /// <returns></returns>
        bool IsAccessible(ControllerContainer root);

        /// <summary>
        /// создает дефалтовый(через пустой конструктор) объект, который редактируем - нужен для проверки прав при помощи
        /// Root.CurrentClient.Mandates.MandateDataEdition.AllowedTypes.Contains(obj.GetStableTypeName())
        /// </summary>
        /// <returns></returns>
        JavelinObject GetDefaultObject();

        /// <summary>
        /// возвращает элемент меню для отрисовки сущности в меню
        /// </summary>
        /// <returns></returns>
        MenuItem GetMenuItem(ControllerContainer root);

    }
}
