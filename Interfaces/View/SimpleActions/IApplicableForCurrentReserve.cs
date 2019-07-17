using JavelinBL2;
using JavelinModelV2.Orders.Simple;
using JavelinView3.Base.InterfacesForOverride._Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.SimpleActions
{
    /// <summary>
    /// определяет применимость чего-либо к переданному заказу
    /// </summary>
    public interface IApplicableForCurrentReserve : IViewControllerApplicable
    {
        bool IsApplicable(SimpleReserve reserve, ControllerContainer bl);
    }
}
