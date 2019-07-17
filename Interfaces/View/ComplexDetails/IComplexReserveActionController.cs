using JavelinBL2;
using JavelinModelV2.Orders.Complex;
using JavelinView3.Base.Orders.Models;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    /// <summary>
    /// данный интерфейс имплементят вью контроллеры для действий над комплексным заказом, например, финализации
    /// </summary>
    public interface IComplexReserveActionController
    {
        /// <summary>
        /// применимо ли действие для данного заказа
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        bool IsApplicable(ComplexReserve complex, ControllerContainer bl);

        /// <summary>
        /// свойства кнопки - css class, подпись кнопки, ссылка, уникальный код, rate - порядок выполнения если несколько одинаковых кодов
        /// </summary>
        /// <returns></returns>
        ComplexReserveActionModel GetComplexReserveActionModel(ControllerContainer bl, ComplexReserve complex);

        ///// <summary>
        ///// возвращает дополнительный класс для стилизации кнопки
        ///// </summary>
        ///// <returns></returns>
        //string GetCssClass();

        ///// <summary>
        ///// вовзращает подпись к контролу
        ///// </summary>
        ///// <returns></returns>
        //string GetItemText(ControllerContainer bl, ComplexReserve complex);

        ///// <summary>
        ///// действие при нажатии
        ///// </summary>
        ///// <returns></returns>
        //string GetActionUrl();
    }
}
