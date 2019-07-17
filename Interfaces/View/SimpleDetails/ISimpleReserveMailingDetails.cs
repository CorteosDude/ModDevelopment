using JavelinModelV2.Orders.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.SimpleDetails
{
    public interface ISimpleReserveMailingDetails
    {
        /// <summary>
        /// рисует детали простого заказа
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        ActionResult RenderDetails(SimpleReserve reserve);

        /// <summary>
        /// возвращает true, если переданный тип заказа поддерживается
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        bool IsReserveTypeSupported(SimpleReserve reserve);
    }
}
