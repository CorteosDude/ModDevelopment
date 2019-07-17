using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JavelinBL2;
using JavelinModelV2.Orders.Complex;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    /// <summary>
    /// интерфейс для получения сообщения по окончанию действия над комплексным заказом. Например: старт авторизации
    /// </summary>
    public interface ICompexReserveStateChangeNotification
    {
        /// <summary>
        /// получаем сообщение после любого  действия для отображения на странице  /ComplexReserveFinalization?id=654967
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        ActionResult RenderComplexReserveNotification(ComplexReserve complex);

        /// <summary>
        /// проверяет статус командировки
        /// </summary>
        /// <param name="complex"></param>
        /// <param name="bl"></param>
        /// <returns></returns>
        bool IsApplicable(ComplexReserve complex, ControllerContainer bl);
    }
}
