using JavelinModelV2.Orders.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.SimpleDetails
{
    /// <summary>
    /// интерфейс, который поддерживают контроллеры выводящие детали обычного заказа
    /// </summary>
    public interface ISimpleReserveDetailsController
    {
        /// <summary>
        /// проверяет, поддерживается ли данный заказ
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        bool IsOrderSupported(SimpleReserve reserve);
        /// <summary>
        /// рисует детали заказа
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        ActionResult RenderDetails(SimpleReserve reserve, int mode);
        /// <summary>
        /// получить список названий ГДС, которые предоставили данные для формирования этого резерва
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        string GetProviderNames(SimpleReserve reserve);        
        /// <summary>
        /// рисует тултип с детализацией суммы заказа (как в рейтах)
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        ActionResult RenderPriceDetalisationTooltip(SimpleReserve reserve);
    }
}
