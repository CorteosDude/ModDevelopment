using JavelinBL2;
using JavelinModelV2.Orders.Simple;
using JavelinView3.Base.InterfacesForOverride._Common;
using JavelinView3.Base.Structures.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.SimpleActions
{
    /// <summary>
    /// рисует дополнительные кнопки в заказе
    /// </summary>
    public interface IExtraButton : IApplicableForCurrentReserve
    {
        ExtraButtonModel GetButtonModel(ControllerContainer bl, SimpleReserve reserve);
    }
}
