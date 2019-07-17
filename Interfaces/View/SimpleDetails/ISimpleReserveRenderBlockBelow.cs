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
    /// отвечает за нижний блок деталей заказа
    /// </summary>
    public interface ISimpleReserveRenderBlockBelow
    {
        /// <summary>
        /// проверяет, поддерживается ли данный заказ
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        bool IsOrderSupported(SimpleReserve reserve);

        /// <summary>
        /// рисует блок снизу над деталями заказа
        /// </summary>
        /// <param name="reserve"></param>
        /// <returns></returns>
        ActionResult RenderBlockBelow(SimpleReserve reserve);
    }
}
